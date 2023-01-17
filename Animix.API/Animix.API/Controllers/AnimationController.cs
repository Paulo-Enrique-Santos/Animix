using Animix.Domain.Interface.Service;
using Animix.Domain.Model.Request;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Animix.API.Controllers
{
    [Route("api/Animacao")]
    [ApiController]
    public class AnimationController : ControllerBase
    {
        private readonly IAnimationService _animationService;

        public AnimationController(IAnimationService animationService)
        {
            _animationService = animationService;
        }

        [HttpPost("/CriarAnimacao")]
        public async Task<ActionResult> CreateAnimation([FromQuery] AnimationCreateRequest request)
        {
            var response = await _animationService.CreateAnimationAsync(request);

            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpDelete("/DeletarAnimacao")]
        public async Task<ActionResult> DeleteAnimation(int idAnimation)
        {
            var response = await _animationService.DeleteAnimationAsync(idAnimation);

            if (response.IsSuccess)
                return Ok(response.Message);

            return BadRequest(response.Message);
        }

        [HttpGet("/DownloadImageAnimacao")]
        public async Task<IActionResult> DownloadImage(int idAnimation)
        {
            var response = await _animationService.GetAnimationByIdAsync(idAnimation);
            var file = new FileContentResult(response.Data.Image, MediaTypeNames.Application.Pdf);
            file.FileDownloadName = response.Data.Name + ".png";
            return file;
        }

        [HttpGet("/BuscarAnimacaoPorId")]
        public async Task<ActionResult> GetAnimationById(int idAnimation)
        {
            var response = await _animationService.GetAnimationByIdAsync(idAnimation);

            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpPatch("/EditarAnimacao")]
        public async Task<ActionResult> UpdateAnimation([FromQuery] AnimationUpdateRequest request)
        {
            var response = await _animationService.UpdateAnimationAsync(request);

            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }
    }
}

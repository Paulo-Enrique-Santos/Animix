using Animix.Domain.Interface.Service;
using Animix.Domain.Model.Request;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Animix.API.Controllers
{
    [Route("api/Personagem")]
    [ApiController]

    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpPost("/CriarPersonagem")]
        public async Task<ActionResult> CreateCharacter([FromQuery] CharacterCreateRequest request)
        {
            var response = await _characterService.CreateCharacterAsync(request);

            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpDelete("/DeletarPersonagem")]
        public async Task<ActionResult> DeleteCharacter(int idAnimation)
        {
            var response = await _characterService.DeleteCharacterAsync(idAnimation);

            if (response.IsSuccess)
                return Ok(response.Message);

            return BadRequest(response.Message);
        }

        [HttpGet("/DownloadImagemPersonagem")]
        public async Task<IActionResult> DownloadImageCharacter(int idAnimation)
        {
            var response = await _characterService.GetCharacterByIdAsync(idAnimation);
            var file = new FileContentResult(response.Data.Image, MediaTypeNames.Application.Pdf);
            file.FileDownloadName = response.Data.Name + ".png";
            return file;
        }

        [HttpGet("/BuscarPersonagemPorId")]
        public async Task<ActionResult> GetCharacterById(int idAnimation)
        {
            var response = await _characterService.GetCharacterByIdAsync(idAnimation);

            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpPatch("/EditarPersonagem")]
        public async Task<ActionResult> UpdateCharacter([FromQuery] CharacterUpdateRequest request)
        {
            var response = await _characterService.UpdateCharacterAsync(request);

            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }
    }
}

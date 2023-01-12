﻿using Animix.Domain.Interface.Service;
using Animix.Domain.Model.Request;
using Microsoft.AspNetCore.Mvc;

namespace Animix.API.Controllers
{
    [Route("api/Animation")]
    [ApiController]
    public class AnimationController : ControllerBase
    {
        private readonly IAnimationService _animationService;

        public AnimationController(IAnimationService animationService)
        {
            _animationService = animationService;
        }

        [HttpPost("/CriarAnimacao")]
        public async Task<ActionResult> CreateAnimationAsync([FromQuery]AnimationCreateRequest request)
        {
            var response = await _animationService.CreateAnimationAsync(request);

            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpDelete("/DeletarAnimacao")]
        public async Task<ActionResult> DeleteAnimationAsync([FromQuery] int idAnimation)
        {
            var response = await _animationService.DeleteAnimationAsync(idAnimation);

            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }
    }
}
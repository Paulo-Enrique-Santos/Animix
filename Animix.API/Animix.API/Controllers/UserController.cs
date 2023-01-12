using Animix.Domain.Interface.Service;
using Animix.Domain.Model.Request;
using Microsoft.AspNetCore.Mvc;

namespace Animix.API.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("/RegisterUser")]
        public async Task<ActionResult> RegisterUser([FromQuery] UserRegisterRequest request)
        {
            var response = await _userService.RegisterUserAsync(request);

            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpGet("/LoginUser")]
        public async Task<ActionResult> LoginUser([FromQuery] UserLoginRequest request)
        {
            var response = await _userService.LoginUserAsync(request);

            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }
    }
}

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

        [HttpPost]
        public async Task<ActionResult> RegisterUser([FromQuery] UserRegisterRequest request)
        {
            var result = await _userService.RegisterUserAsync(request);

            if (result.IsSuccess)
                return Ok(result.Data);

            return BadRequest(result.Message);
        }
    }
}

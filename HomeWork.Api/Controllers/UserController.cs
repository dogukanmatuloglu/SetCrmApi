using HomeWork.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Api.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [Route("api/v1/getUser")]
       public async Task<IActionResult> StartAsync(string userId)
        {
           var result=   await _userService.StartAsync(userId);
            return Ok(result);
        }
    }
}

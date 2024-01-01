using JWT.API.Domain.ValueObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpGet]
        public async Task Login(LoginUser user)
        {

        }

        [HttpPost]
        public async Task<bool> Register(LoginUser user)
        {

        }
    }
}

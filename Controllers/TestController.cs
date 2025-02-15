using md_notes.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Principal;

namespace md_notes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Authorize]
        [HttpGet("/user-info")]
        public async Task<IActionResult> GetMyClaims()
        {
            var user = HttpContext.Items["User"] as User;

            return Ok(user);
        }
    }
}

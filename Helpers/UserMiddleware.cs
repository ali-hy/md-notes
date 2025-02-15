
using md_notes.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace md_notes.Helpers
{
    public class UserMiddleware
    {
        private readonly RequestDelegate _next;

        public UserMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, AppDbContext dbContext)
        {
            User? user = null;

            if (context.User.Identity is ClaimsIdentity identity)
                user = await dbContext.Users.SingleOrDefaultAsync<User>(u => u.UserName == context.User.Identity.Name);

            if (user != null)
                context.Items["User"] = user;

            await _next(context);
        }
    }
}

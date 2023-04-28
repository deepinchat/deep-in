using Microsoft.AspNetCore.Http;

namespace DeepIn.Application.Services;

public class UserContext : IUserContext
{
    private IHttpContextAccessor _context;

    public UserContext(IHttpContextAccessor context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public string UserId => _context.HttpContext.User.FindFirst("sub").Value;
}

using Microsoft.AspNetCore.Mvc;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController : ControllerBase
{
    
    protected IActionResult HandleException(Exception ex, string message)
    {
        return BadRequest(new { error = message, details = ex.Message });
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController : ControllerBase
{
    protected readonly ILogger<BaseController> _logger;

    public BaseController(ILogger<BaseController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Manipula exceções e retorna uma resposta de BadRequest.
    /// </summary>
    /// <param name="ex">A exceção capturada.</param>
    /// <param name="message">A mensagem de erro personalizada.</param>
    /// <returns>Um objeto IActionResult.</returns>
    protected IActionResult HandleException(Exception ex, string message)
    {
        _logger.LogError(ex, message);
        return BadRequest(new { error = message, details = ex.Message });
    }

    protected IActionResult HandleSuccess(object data)
    {
        return Ok(new { success = true, data });
    }

    protected IActionResult HandleFailure(string message)
    {
        return BadRequest(new { success = false, error = message });
    }
}

using Microsoft.AspNetCore.Mvc;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.Entities;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PropriedadeController : BaseController
{
    private readonly IPropriedadeService _propriedadeService;

    public PropriedadeController(IPropriedadeService propriedadeService, ILogger<PropriedadeController> logger) : base(logger)
    {
        _propriedadeService = propriedadeService;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            _logger.LogInformation($"Obtendo Propriedade por Id: {id}");
            var propriedade = await _propriedadeService.ObterPorIdAsync(id);
            if (propriedade == null)
            {
                _logger.LogWarning($"Propriedade com Id {id} não encontrada");
                return NotFound();
            }
            return HandleSuccess(propriedade);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao obter Propriedade por Id");
            return HandleException(ex, "Erro ao obter Propriedade por Id");
        }
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            _logger.LogInformation("Obtendo todas as Propriedades");
            var propriedades = await _propriedadeService.ObterTodosAsync();
            if (propriedades == null || !propriedades.Any())
            {
                _logger.LogWarning("Nenhuma Propriedade encontrada");
                return NotFound();
            }
            return HandleSuccess(propriedades);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao obter todas as Propriedades");
            return HandleException(ex, "Erro ao obter todas as Propriedades");
        }
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Create([FromBody] Propriedade propriedade)
    {
        try
        {
            await _propriedadeService.AdicionarPropriedadeAsync(propriedade);
            _logger.LogInformation($"Propriedade com Id {propriedade.Id} criada");
            return CreatedAtAction(nameof(GetById), new { id = propriedade.Id }, propriedade);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar Propriedade");
            return HandleException(ex, "Erro ao criar Propriedade");
        }
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Update(Guid id, [FromBody] Propriedade propriedade)
    {
        try
        {
            if (id != propriedade.Id)
            {
                _logger.LogWarning($"Propriedade com Id {id} não encontrada");
                return BadRequest();
            }

            await _propriedadeService.AtualizarPropriedadeAsync(propriedade);
            _logger.LogInformation($"Propriedade com Id {id} atualizada");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao atualizar Propriedade");
            return HandleException(ex, "Erro ao atualizar Propriedade");
        }
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            var propriedade = await _propriedadeService.ObterPorIdAsync(id);
            if (propriedade == null)
            {
                _logger.LogWarning($"Propriedade com Id {id} não encontrada");
                return NotFound();
            }

            await _propriedadeService.RemoverPropriedadeAsync(propriedade);
            _logger.LogInformation($"Propriedade com Id {id} removida");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao remover Propriedade");
            return HandleException(ex, "Erro ao remover Propriedade");
        }
    }
}

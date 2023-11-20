using Microsoft.AspNetCore.Mvc;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.DTOs;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReclamacaoController : BaseController
{
    private readonly IReclamacaoService _reclamacaoService;

    public ReclamacaoController(IReclamacaoService reclamacaoService, ILogger<ReclamacaoController> logger) : base(logger)
    {
        _reclamacaoService = reclamacaoService;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            _logger.LogInformation($"Obtendo Reclamacao por Id: {id}");
            var reclamacao = await _reclamacaoService.ObterPorIdAsync(id);
            if (reclamacao == null)
            {
                _logger.LogWarning($"Reclamacao com Id {id} não encontrado");
                return NotFound();
            }
            return HandleSuccess(reclamacao);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao obter Reclamacao por Id");
            return HandleException(ex, "Erro ao obter Reclamacao por Id");
        }
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            _logger.LogInformation("Obtendo todos os Reclamacaos");
            var reclamacoes = await _reclamacaoService.ObterTodosAsync();
            if (reclamacoes == null || !reclamacoes.Any())
            {
                _logger.LogWarning("Nenhum Reclamacao encontrado");
                return NotFound();
            }
            return HandleSuccess(reclamacoes);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao obter todos os Reclamacaos");
            return HandleException(ex, "Erro ao obter todos os Reclamacaos");
        }
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Create([FromBody] ReclamacaoDto reclamacao)
    {
        try
        {
            await _reclamacaoService.AdicionarReclamacaoAsync(reclamacao);
            _logger.LogInformation($"Reclamacao com Id {reclamacao.Id} criado");
            return CreatedAtAction(nameof(GetById), new { id = reclamacao.Id }, reclamacao);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar Reclamacao");
            return HandleException(ex, "Erro ao criar Reclamacao");
        }
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Update(Guid id, [FromBody] ReclamacaoDto reclamacao)
    {
        try
        {
            if (id != reclamacao.Id)
            {
                _logger.LogWarning($"Reclamacao com Id {id} não encontrado");
                return BadRequest();
            }

            await _reclamacaoService.AtualizarReclamacaoAsync(reclamacao);
            _logger.LogInformation($"Reclamacao com Id {reclamacao.Id} atualizado");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao atualizar Reclamacao");
            return HandleException(ex, "Erro ao atualizar Reclamacao");
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
            var reclamacao = await _reclamacaoService.ObterPorIdAsync(id);
            if (reclamacao == null)
            {
                _logger.LogWarning($"Reclamacao com Id {id} não encontrado");
                return NotFound();
            }

            await _reclamacaoService.RemoverReclamacaoAsync(reclamacao);
            _logger.LogInformation($"Reclamacao com Id {id} removido");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao remover Reclamacao");
            return HandleException(ex, "Erro ao remover Reclamacao");
        }
    }
}

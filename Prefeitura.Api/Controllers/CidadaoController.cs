using Microsoft.AspNetCore.Mvc;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.DTOs;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CidadaoController : BaseController
{
    private readonly ICidadaoService _cidadaoService;

    public CidadaoController(ICidadaoService cidadaoService, ILogger<CidadaoController> logger) : base(logger)
    {
        _cidadaoService = cidadaoService;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            _logger.LogInformation($"Obtendo Cidadao com Id {id}");
            var cidadao = await _cidadaoService.ObterCidadaoPorIdAsync(id);
            if (cidadao == null)
            {
                _logger.LogWarning($"Cidadao com Id {id} não encontrado");
                return NotFound();
            }
            return HandleSuccess(cidadao);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao obter Cidadao por ID");
            return HandleException(ex, "Erro ao obter Cidadao por ID");
        }
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            _logger.LogInformation("Obtendo todos os Cidadaos");
            var cidadaos = await _cidadaoService.ObterCidadaosAsync();
            if (cidadaos == null || !cidadaos.Any())
            {
                _logger.LogWarning("Nenhum Cidadao encontrado");
                return NotFound();
            }
            return HandleSuccess(cidadaos);
        }
        catch (Exception ex)
        {
            return HandleException(ex, "Erro ao obter todos os Cidadaos");
        }
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Create([FromBody] CidadaoDto cidadao)
    {
        try
        {
            await _cidadaoService.AdicionarCidadaoAsync(cidadao);
            _logger.LogInformation($"Cidadao com Id {cidadao.Id} criado");
            return CreatedAtAction(nameof(GetById), new { id = cidadao.Id }, cidadao);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar Cidadao");
            return HandleException(ex, "Erro ao criar Cidadao");
        }
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Update(Guid id, [FromBody] CidadaoDto cidadao)
    {
        try
        {
            cidadao.Id = id;
            var resultado = await _cidadaoService.AtualizarCidadaoAsync(cidadao);
            if (resultado == null)
            {
                _logger.LogWarning($"Cidadao com Id {id} não encontrado");
                return BadRequest();
            }
            _logger.LogInformation($"Cidadao com Id {id} atualizado");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao atualizar Cidadao");
            return HandleException(ex, "Erro ao atualizar Cidadao");
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
            var cidadao = await _cidadaoService.ObterCidadaoPorIdAsync(id);
            if (cidadao == null)
            {
                _logger.LogWarning($"Cidadao com Id {id} não encontrado");
                return NotFound();
            }

            await _cidadaoService.RemoverCidadaoAsync(cidadao);
            _logger.LogInformation($"Cidadao com Id {id} removido");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao remover Cidadao");
            return HandleException(ex, "Erro ao remover Cidadao");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.DTOs;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicoMunicipalController : BaseController
{
    private readonly IServicoMunicipalService _servicoMunicipalService;

    public ServicoMunicipalController(IServicoMunicipalService servicoMunicipalService, ILogger<ServicoMunicipalController> logger) : base(logger)
    {
        _servicoMunicipalService = servicoMunicipalService;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            _logger.LogInformation($"Obtendo ServicoMunicipal por Id: {id}");
            var servicoMunicipal = await _servicoMunicipalService.ObterServicoMunicipalPorIdAsync(id);
            if (servicoMunicipal == null)
            {
                _logger.LogWarning($"ServicoMunicipal com Id {id} não encontrado");
                return NotFound();
            }
            return HandleSuccess(servicoMunicipal);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao obter ServicoMunicipal por Id");
            return HandleException(ex, "Erro ao obter ServicoMunicipal por Id");
        }
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            _logger.LogInformation("Obtendo todos os ServicosMunicipais");
            var servicosMunicipais = await _servicoMunicipalService.ObterServicosMunicipaisAsync();
            if (servicosMunicipais == null || !servicosMunicipais.Any())
            {
                _logger.LogWarning("Nenhum ServicoMunicipal encontrado");
                return NotFound();
            }
            return HandleSuccess(servicosMunicipais);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao obter todos os ServicosMunicipais");
            return HandleException(ex, "Erro ao obter todos os ServicosMunicipais");
        }
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Create([FromBody] ServicoMunicipalDto servicoMunicipal)
    {
        try
        {
            await _servicoMunicipalService.AdicionarServicoMunicipalAsync(servicoMunicipal);
            _logger.LogInformation($"ServicoMunicipal com Id {servicoMunicipal.Id} criado");
            return CreatedAtAction(nameof(GetById), new { id = servicoMunicipal.Id }, servicoMunicipal);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar ServicoMunicipal");
            return HandleException(ex, "Erro ao criar ServicoMunicipal");
        }
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Update(Guid id, [FromBody] ServicoMunicipalDto servicoMunicipal)
    {
        try
        {
            if (id != servicoMunicipal.Id)
            {
                _logger.LogWarning($"ServicoMunicipal com Id {id} não encontrado");
                return BadRequest();
            }

            await _servicoMunicipalService.AtualizarServicoMunicipalAsync(servicoMunicipal);
            _logger.LogInformation($"ServicoMunicipal com Id {id} atualizado");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao atualizar ServicoMunicipal");
            return HandleException(ex, "Erro ao atualizar ServicoMunicipal");
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
            var servicoMunicipal = await _servicoMunicipalService.ObterServicoMunicipalPorIdAsync(id);
            if (servicoMunicipal == null)
            {
                _logger.LogWarning($"ServicoMunicipal com Id {id} não encontrado");
                return NotFound();
            }

            await _servicoMunicipalService.RemoverServicoMunicipalAsync(servicoMunicipal);
            _logger.LogInformation($"ServicoMunicipal com Id {id} removido");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao remover ServicoMunicipal");
            return HandleException(ex, "Erro ao remover ServicoMunicipal");
        }
    }
}

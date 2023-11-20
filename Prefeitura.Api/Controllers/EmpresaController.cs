using Microsoft.AspNetCore.Mvc;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.DTOs;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmpresaController : BaseController
{
    private readonly IEmpresaService _empresaService;

    public EmpresaController(IEmpresaService empresaService, ILogger<EmpresaController> logger) : base(logger)
    {
        _empresaService = empresaService;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            _logger.LogInformation($"Obtendo Empresa por Id: {id}");
            var empresa = await _empresaService.ObterEmpresaPorId(id);
            if (empresa == null)
            {
                _logger.LogWarning($"Empresa com Id {id} não encontrada");
                return NotFound();
            }
            return HandleSuccess(empresa);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao obter Empresa por Id");
            return HandleException(ex, "Erro ao obter Empresa por Id");
        }
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            _logger.LogInformation("Obtendo todas as Empresas");
            var empresas = await _empresaService.ObterEmpresas();
            if (empresas == null || !empresas.Any())
            {
                _logger.LogWarning("Nenhuma Empresa encontrada");
                return NotFound();
            }
            return HandleSuccess(empresas);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao obter todas as Empresas");
            return HandleException(ex, "Erro ao obter todas as Empresas");
        }
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Create([FromBody] EmpresaDto empresa)
    {
        try
        {
            await _empresaService.AdicionarEmpresa(empresa);
            _logger.LogInformation($"Empresa com Id {empresa.Id} criada");
            return CreatedAtAction(nameof(GetById), new { id = empresa.Id }, empresa);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar Empresa");
            return HandleException(ex, "Erro ao criar Empresa");
        }
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Update(Guid id, [FromBody] EmpresaDto empresa)
    {
        try
        {
            if (id != empresa.Id)
            {
                _logger.LogWarning($"Empresa com Id {id} não encontrada");
                return BadRequest();
            }

            await _empresaService.AtualizarEmpresa(empresa);
            _logger.LogInformation($"Empresa com Id {empresa.Id} atualizada");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao atualizar Empresa");
            return HandleException(ex, "Erro ao atualizar Empresa");
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
            var empresa = await _empresaService.ObterEmpresaPorId(id);
            if (empresa == null)
            {
                _logger.LogWarning($"Empresa com Id {id} não encontrada");
                return NotFound();
            }

            await _empresaService.RemoverEmpresa(empresa);
            _logger.LogInformation($"Empresa com Id {id} removida");
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao remover Empresa");
            return HandleException(ex, "Erro ao remover Empresa");
        }
    }
}

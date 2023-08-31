using Microsoft.AspNetCore.Mvc;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.Entities;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmpresaController : BaseController
{
    private readonly IEmpresaService _empresaService;

    public EmpresaController(IEmpresaService empresaService)
    {
        _empresaService = empresaService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var empresa = await _empresaService.ObterEmpresaPorId(id);
        if (empresa == null)
        {
            return NotFound();
        }
        return Ok(empresa);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var empresas = await _empresaService.ObterEmpresas();
        return Ok(empresas);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Empresa empresa)
    {
        await _empresaService.AdicionarEmpresa(empresa);
        return CreatedAtAction(nameof(GetById), new { id = empresa.Id }, empresa);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Empresa empresa)
    {
        if (id != empresa.Id)
        {
            return BadRequest();
        }

        await _empresaService.AtualizarEmpresa(empresa);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var empresa = await _empresaService.ObterEmpresaPorId(id);
        if (empresa == null)
        {
            return NotFound();
        }

        await _empresaService.RemoverEmpresa(empresa);
        return NoContent();
    }
}

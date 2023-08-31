using Microsoft.AspNetCore.Mvc;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.Entities;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicoMunicipalController : Controller
{
    private readonly IServicoMunicipalService _servicoMunicipalService;

    public ServicoMunicipalController(IServicoMunicipalService servicoMunicipalService)
    {
        _servicoMunicipalService = servicoMunicipalService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var servicoMunicipal = await _servicoMunicipalService.ObterServicoMunicipalPorIdAsync(id);
        if (servicoMunicipal == null)
        {
            return NotFound();
        }
        return Ok(servicoMunicipal);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var servicosMunicipais = await _servicoMunicipalService.ObterServicosMunicipaisAsync();
        return Ok(servicosMunicipais);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ServicoMunicipal servicoMunicipal)
    {
        await _servicoMunicipalService.AdicionarServicoMunicipalAsync(servicoMunicipal);
        return CreatedAtAction(nameof(GetById), new { id = servicoMunicipal.Id }, servicoMunicipal);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] ServicoMunicipal servicoMunicipal)
    {
        if (id != servicoMunicipal.Id)
        {
            return BadRequest();
        }

        await _servicoMunicipalService.AtualizarServicoMunicipalAsync(servicoMunicipal);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var servicoMunicipal = await _servicoMunicipalService.ObterServicoMunicipalPorIdAsync(id);
        if (servicoMunicipal == null)
        {
            return NotFound();
        }

        await _servicoMunicipalService.RemoverServicoMunicipalAsync(servicoMunicipal);
        return NoContent();
    }
}

using Microsoft.AspNetCore.Mvc;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.Entities;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReclamacaoController : Controller
{
    private readonly IReclamacaoService _reclamacaoService;

    public ReclamacaoController(IReclamacaoService reclamacaoService)
    {
        _reclamacaoService = reclamacaoService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var reclamacao = await _reclamacaoService.ObterPorIdAsync(id);
        if (reclamacao == null)
        {
            return NotFound();
        }
        return Ok(reclamacao);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var reclamacoes = await _reclamacaoService.ObterTodosAsync();
        return Ok(reclamacoes);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Reclamacao reclamacao)
    {
        await _reclamacaoService.AdicionarReclamacaoAsync(reclamacao);
        return CreatedAtAction(nameof(GetById), new { id = reclamacao.Id }, reclamacao);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Reclamacao reclamacao)
    {
        if (id != reclamacao.Id)
        {
            return BadRequest();
        }

        await _reclamacaoService.AtualizarReclamacaoAsync(reclamacao);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var reclamacao = await _reclamacaoService.ObterPorIdAsync(id);
        if (reclamacao == null)
        {
            return NotFound();
        }

        await _reclamacaoService.RemoverReclamacaoAsync(reclamacao);
        return NoContent();
    }
}

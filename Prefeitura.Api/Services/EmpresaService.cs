using AutoMapper;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.DTOs;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Api.Services;

public class EmpresaService : IEmpresaService
{
    private readonly IEmpresaRepository _empresaRepository;
    private readonly IMapper _mapper;

    public EmpresaService(IEmpresaRepository empresaRepository, IMapper mapper)
    {
        _empresaRepository = empresaRepository;
        _mapper = mapper;
    }

    public async Task<EmpresaDto> AdicionarEmpresa(EmpresaDto empresaDto)
    {
        var empresa = _mapper.Map<Empresa>(empresaDto);
        var resultado = await _empresaRepository.Adicionar(empresa);
        return _mapper.Map<EmpresaDto>(resultado);
    }

    public async Task<EmpresaDto> AtualizarEmpresa(EmpresaDto empresaDto)
    {
        var empresa = _mapper.Map<Empresa>(empresaDto);
        var resultado = await _empresaRepository.Atualizar(empresa);
        return _mapper.Map<EmpresaDto>(resultado);
    }

    public async Task<EmpresaDto> RemoverEmpresa(EmpresaDto empresaDto)
    {
        var empresa = _mapper.Map<Empresa>(empresaDto);
        var resultado = await _empresaRepository.Remover(empresa);
        return _mapper.Map<EmpresaDto>(resultado);
    }

    public async Task<IEnumerable<EmpresaDto>> ObterEmpresaPorCnpj(string cnpj)
    {
        var empresa = await _empresaRepository.ObterPorCnpjAsync(cnpj);
        return _mapper.Map<IEnumerable<EmpresaDto>>(empresa);
    }

    public async Task<EmpresaDto> ObterEmpresaPorId(Guid id)
    {
        var empresa = await _empresaRepository.ObterPorIdAsync(id);
        return _mapper.Map<EmpresaDto>(empresa);
    }

    public async Task<IEnumerable<EmpresaDto>> ObterEmpresaPorInscricaoEstadual(string inscricaoEstadual)
    {
        var empresa = await _empresaRepository.ObterPorInscricaoEstadualAsync(inscricaoEstadual);
        return _mapper.Map<IEnumerable<EmpresaDto>>(empresa);
    }

    public async Task<IEnumerable<EmpresaDto>> ObterEmpresaPorInscricaoMunicipal(string inscricaoMunicipal)
    {
        var empresa = await _empresaRepository.ObterPorInscricaoMunicipalAsync(inscricaoMunicipal);
        return _mapper.Map<IEnumerable<EmpresaDto>>(empresa);
    }

    public async Task<IEnumerable<EmpresaDto>> ObterEmpresas()
    {
        var empresas = await _empresaRepository.ObterTodosAsync();
        return _mapper.Map<IEnumerable<EmpresaDto>>(empresas);
    }

    public async Task<IEnumerable<EmpresaDto>> ObterEmpresasPorEmail(string email)
    {
        var empresa = await _empresaRepository.ObterPorEmailAsync(email);
        return _mapper.Map<IEnumerable<EmpresaDto>>(empresa);
    }

    public async Task<IEnumerable<EmpresaDto>> ObterEmpresasPorEmailResponsavel(string emailResponsavel)
    {
        var empresa = await _empresaRepository.ObterPorEmailResponsavelAsync(emailResponsavel);
        return _mapper.Map<IEnumerable<EmpresaDto>>(empresa);
    }

    public async Task<IEnumerable<EmpresaDto>> ObterEmpresasPorEndereco(EnderecoDto enderecoDto)
    {
        var endereco = _mapper.Map<Endereco>(enderecoDto);
        var empresa = await _empresaRepository.ObterPorEnderecoAsync(endereco);
        return _mapper.Map<IEnumerable<EmpresaDto>>(empresa);
    }

    public async Task<IEnumerable<EmpresaDto>> ObterEmpresasPorNome(string nome)
    {
        var empresa = await _empresaRepository.ObterPorNomeAsync(nome);
        return _mapper.Map<IEnumerable<EmpresaDto>>(empresa);
    }

    public async Task<IEnumerable<EmpresaDto>> ObterEmpresasPorResponsavel(string responsavel)
    {
        var empresa = await _empresaRepository.ObterPorResponsavelAsync(responsavel);
        return _mapper.Map<IEnumerable<EmpresaDto>>(empresa);
    }

    public async Task<IEnumerable<EmpresaDto>> ObterEmpresasPorTelefone(string telefone)
    {
        var empresa = await _empresaRepository.ObterPorTelefoneAsync(telefone);
        return _mapper.Map<IEnumerable<EmpresaDto>>(empresa);
    }

    public async Task<IEnumerable<EmpresaDto>> ObterEmpresasPorTelefoneResponsavel(string telefoneResponsavel)
    {
        var empresa = await _empresaRepository.ObterPorTelefoneResponsavelAsync(telefoneResponsavel);
        return _mapper.Map<IEnumerable<EmpresaDto>>(empresa);
    }
}

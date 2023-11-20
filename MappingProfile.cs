using System;
using AutoMapper;
using Prefeitura.Core.DTOs;
using Prefeitura.Core.Entities;

namespace Prefeitura.Api.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Cidadao, CidadaoDto>().ReverseMap();
        CreateMap<Empresa, EmpresaDto>().ReverseMap();
        CreateMap<Propriedade, PropriedadeDto>().ReverseMap();
        CreateMap<Reclamacao, ReclamacaoDto>().ReverseMap();
        CreateMap<ServicoMunicipal, ServicoMunicipalDto>().ReverseMap();
        CreateMap<Familia, FamiliaDto>().ReverseMap();
        CreateMap<Endereco, EnderecoDto>().ReverseMap();
    }
}

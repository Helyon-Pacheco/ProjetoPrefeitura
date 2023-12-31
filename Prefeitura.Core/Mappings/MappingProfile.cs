﻿using AutoMapper;
using Prefeitura.Core.DTOs;
using Prefeitura.Core.Entities;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Cidadao, CidadaoDto>().ReverseMap();
        CreateMap<Empresa, EmpresaDto>().ReverseMap();
        CreateMap<Propriedade, PropriedadeDto>().ReverseMap();
        CreateMap<Reclamacao, ReclamacaoDto>().ReverseMap();
        CreateMap<ServicoMunicipal, ServicoMunicipalDto>().ReverseMap();
        CreateMap<Endereco, EnderecoDto>().ReverseMap();
    }
}

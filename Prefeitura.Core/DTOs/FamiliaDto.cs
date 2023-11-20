namespace Prefeitura.Core.DTOs;

public class FamiliaDto
{
    public Guid Id { get; set; }
    public ICollection<CidadaoDto> Membros { get; set; }

    public FamiliaDto()
    {
        Membros = new List<CidadaoDto>();
    }
}
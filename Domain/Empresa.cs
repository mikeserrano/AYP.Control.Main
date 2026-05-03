using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Empresa
{
    [Key]
    public int Id { get; set; }

    [MaxLength(200)]
    [Required]
    public string NombEmpr { get; set; } = "";

    [MaxLength(255)]
    public string DireEmpr1 { get; set; } = "";

    [MaxLength(255)]
    public string DireEmpr2 { get; set; } = "";

    public int PaisId { get; set; } = 1;

    public int EstadoId { get; set; } = 1;

    public int MunicipioId { get; set; } = 1;

    public int DistritoId { get; set; } = 1;

    [MaxLength(255)]
    public string ActiEmpr { get; set; } = "";

    public byte[]? LogoEmpr { get; set; }


}

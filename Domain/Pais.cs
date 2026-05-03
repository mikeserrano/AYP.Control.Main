using System.ComponentModel.DataAnnotations;
namespace Domain;

public class Pais
    {
    [Key]
    public int MyProperty { get; set; }

    [MaxLength(100)]
    public string NombPais { get; set; } = "";
}


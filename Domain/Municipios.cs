using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Municipios
    {
        public int Id { get; set; } = 1;

        public int EstadoId { get; set; } = 1;

        [MaxLength(255)]
        public string NombMuni { get; set; } = "";
    }
}

using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Estados
    {
        public int Id { get; set; } = 1;

        public int PaisId { get; set; } = 1;

        [MaxLength(100)]
        public string NombEsta { get; set; } = "";
    }
}

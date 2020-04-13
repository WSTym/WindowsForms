using System.ComponentModel.DataAnnotations;

namespace SistemaEscolar.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        [StringLength(50)]
        public string Edereco { get; set; }
        public long Telefone { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace SistemaEscolar.Models
{
    public abstract class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        [StringLength(14)]
        public string CPF { get; set; }
        [StringLength(50)]
        public string Edereco { get; set; }
        [StringLength(20)]
        public string Telefone { get; set; }
    }
}

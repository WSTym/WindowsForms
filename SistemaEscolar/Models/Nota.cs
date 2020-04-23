using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    public class Nota
    {
        [Key]
        public int Id { get; set; }
        public float Valor { get; set; }
        public bool Falta { get; set; }
        [ForeignKey("Aluno")]
        public int IdAluno { get; set; }
        [ForeignKey("Avaliacao")]
        public int IdAvaliacao { get; set; }
        public virtual Aluno Aluno { get; set; }
        public virtual Avaliacao Avaliacao { get; set; }
    }
}

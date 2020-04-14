using SistemaEscolar.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar
{
    [Table("Professores")]
    public class Professor : Pessoa
    {
        [StringLength(30)]
        public string Capacitacao { get; set; }
        [ForeignKey("Disciplina")]
        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }
    }
}

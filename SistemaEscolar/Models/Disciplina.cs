using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    public class Disciplina
    {
        public Disciplina()
        {
            this.Avaliacoes = new List<Avaliacao>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string Nome { get; set; }
        [ForeignKey("Turma")]
        public int TurmaId { get; set; }
        public virtual Turma Turma { get; set; }
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}

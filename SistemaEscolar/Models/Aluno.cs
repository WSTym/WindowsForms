using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            this.Avaliacoes = new List<Avaliacao>();
        }
        public int Matricula { get; set; }
        [ForeignKey("Turma")]
        public int TurmaId { get; set; }
        public virtual Turma Turma { get; set; }
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}

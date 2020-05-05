using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    [Table("Disciplinas")]
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
        [StringLength(4)]
        public string CargaHoraria { get; set; }
        [StringLength(2)]
        public string AulasSemanais { get; set; }
        [ForeignKey("Turma")]
        public int TurmaId { get; set; }
        public virtual Avaliacao Turma { get; set; }
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}

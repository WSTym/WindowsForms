using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    [Table("Turmas")]
    public class Turma
    {
        public Turma()
        {
            this.Alunos = new List<Aluno>();
            this.Disciplinas = new List<Disciplina>();
        }

        [Key]
        public int Id { get; set; }
        public int Ano { get; set; }
        public int CargaHoraria { get; set; }
        [ForeignKey("Curso")]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; }
        public virtual ICollection<Disciplina> Disciplinas { get; set; }
    }
}

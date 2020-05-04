using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    [Table("Turmas")]
    public class Turma
    {
        /*public Turma()
        {
            this.Cursos = new List<Curso>();
            *//*this.Alunos = new List<Aluno>();
            this.Disciplinas = new List<Disciplina>();*//*
        }*/

        [Key]
        public int Id { get; set; }
        [StringLength(4)]
        public string Ano { get; set; }
        public string Turno { get; set; }
        [StringLength(4)]
        public string CargaHoraria { get; set; }
        [StringLength(2)]
        public string Semestre { get; set; }

        [ForeignKey("Curso")]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }


       /* public virtual ICollection<Aluno> Alunos { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<Disciplina> Disciplinas { get; set; }*/
    }
}

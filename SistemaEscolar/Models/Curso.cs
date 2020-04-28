using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    [Table("Cursos")]
    public class Curso
    {
        public Curso()
        {
            this.Turmas = new List<Turma>(); 
        }

        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string Nome { get; set; }
        [StringLength(200)]
        public string Descricao { get; set; }

        public virtual ICollection<Turma> Turmas { get; set; }
    }
}

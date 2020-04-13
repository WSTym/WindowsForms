using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscolar.Models
{
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
        public int CargaHoaria { get; set; }

        public virtual ICollection<Turma> Turmas { get; set; }
    }
}

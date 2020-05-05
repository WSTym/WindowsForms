using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    [Table("Cursos")]
    public class Curso
    {
        private readonly ObservableListSource<Avaliacao> _turmas = new ObservableListSource<Avaliacao>();

        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string Nome { get; set; }
        [StringLength(200)]
        public string Descricao { get; set; }

        public virtual ObservableListSource<Avaliacao> Turmas { get { return _turmas; } }

    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    [Table("Avaliacoes")]
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Tema { get; set; }
        [StringLength(5)]
        public string Valor { get; set; }
        public string Data { get; set; }
        [ForeignKey("Disciplina")]
        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        /*public string verificaSituacaoAluno(List<float> notas)
        {
            var soma = .0f;
            string resultado;
            foreach (var nota in notas) soma += nota;
            var media = soma / notas.Count;
            if (media >= 70.0) resultado = "Aprovado";
            else if (media < 70 && media >= 60)  resultado = "Recuperação";
            else  resultado = "Reprovado";
            return resultado;
        }*/
    }
}

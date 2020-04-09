using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Models
{
    class Avaliacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public string Data { get; set; }
        public List<float> Notas { get; set; }
        public bool Falta { get; set; }

        public string verificaSituacaoAluno(List<float> notas)
        {
            var soma = .0f;
            string resultado;
            foreach (var nota in notas) soma += nota;
            var media = soma / notas.Count;
            if (media >= 70.0) resultado = "Aprovado";
            else if (media < 70 && media >= 60)  resultado = "Recuperação";
            else  resultado = "Reprovado";
            return resultado;
        }
    }
}

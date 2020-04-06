using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_com_Entity
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
    }
}

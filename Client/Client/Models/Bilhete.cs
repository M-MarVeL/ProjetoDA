using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models {
    public class Bilhete {

        [Key]
        public int Id { get; set; }
        public int Lugar { get; set; }
        public bool Estado { get; set; }
        public Funcionario FuncionarioId { get; set; }
        public Cliente ClienteId { get; set; }
    }
}

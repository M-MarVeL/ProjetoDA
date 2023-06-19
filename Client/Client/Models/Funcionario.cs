using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models {
    public class Funcionario : Pessoa {
        public float Salario { get; set; }
        public string Funcao { get; set; }
    }
}

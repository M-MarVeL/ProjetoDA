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

        public int FuncionarioId { get; set; }
        public int ClienteId { get; set; }
        public int SessaoId { get; set;  }

        public virtual Funcionario Funcionario { get; }
        public virtual Cliente Cliente { get; }
        public virtual Sessao Sessao { get; }

    }
}

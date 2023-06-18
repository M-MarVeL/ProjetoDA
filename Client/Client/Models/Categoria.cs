using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models {
    public class Categoria {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Activo { get; set; }

        public override string ToString() {
            return this.Nome;
        }
    }
}

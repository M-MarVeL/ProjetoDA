using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models {
    public class Sala {
        
        [Key]
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Colunas { get; set; }
        public int Filas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models {
    public class Sessao {

        [Key]
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public float Preco { get; set; }

        public Sala salaId { get; set; }
        public Filme filmeId { get; set; }
    
    }
}

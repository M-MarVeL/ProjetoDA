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

        public int salaId { get; set; }
        public int filmeId { get; set; }
    
        public virtual Sala Sala { get; }
        public virtual Filme Filme { get; }

    }
}

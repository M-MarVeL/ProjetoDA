using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models {
    public class Filme {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public bool Activo { get; set; }
        public Categoria CategoriaId { get; set; }
    }
}

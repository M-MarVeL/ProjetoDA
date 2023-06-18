﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models {
    public class Pessoa {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
    }
}
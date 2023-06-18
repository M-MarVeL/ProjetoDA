using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controllers;

namespace Client.Views {
    public partial class Principal : UserControl {
        public Principal() {
            InitializeComponent();
        }

        public void CarregarSessao() {
            sessaoData.DataSource = SessaoController.getPrincipalSessao();
        }
    }
}

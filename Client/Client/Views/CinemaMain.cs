using Client.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Views {
    public partial class CinemaMain : Form {
        public CinemaMain() {
            InitializeComponent();
        }

        private void btnCriarCinema_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(tbNomeCinema.Text) || string.IsNullOrEmpty(tbMorada.Text) || string.IsNullOrEmpty(tbEmail.Text)) {
                MessageBox.Show("Preencha/os campo/s");
            } else {
                try {
                    CinemaController.inserirCinema(tbNomeCinema.Text, tbMorada.Text, tbEmail.Text);
                    FuncionarioController.inserirFuncionarios("Admin", "Admin", 0, "Admin");
                    ClienteController.inserirCliente("Anonimo", "Anonimo", 999999999);
                    this.Hide();
                    Form form = new FormMain();
                    form.ShowDialog();

                } catch (Exception ex){
                    MessageBox.Show("Erro: " + ex);
                }

                

            }
        }
    }
}

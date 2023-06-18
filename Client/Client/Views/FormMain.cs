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
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
            LoadUserControlHide();
        }

        private void UserControlHide() {
            principal1.Visible = false;
            filmes1.Visible = false;
            funcionarios1.Visible = false;
            cinema1.Visible = false;
            clientes1.Visible = false;
            sessoes1.Visible = false;
        }

        private void LoadUserControlHide() {
            UserControlHide();
            principal1.Visible = true;
            principal1.CarregarSessao();
        }

        private void homePanel_Click(object sender, EventArgs e) {
            LoadUserControlHide();
            principal1.CarregarSessao();
        }

        private void filmesPanel_Click(object sender, EventArgs e) {
            UserControlHide();
            filmes1.Visible = true;
            filmes1.CarregarDados();
        }

        private void FuncPanel_Click(object sender, EventArgs e) {
            UserControlHide();
            funcionarios1.Visible = true;
            funcionarios1.CarregarDados();
        }

        private void cinemaPanel_Click(object sender, EventArgs e) {
            UserControlHide();
            cinema1.Visible = true;
        }

        private void clientePanel_Click(object sender, EventArgs e) {
            UserControlHide();
            clientes1.Visible = true;
        }

        private void sessoesPanel_Click(object sender, EventArgs e) {
            UserControlHide();
            sessoes1.Visible = true;
        }
    }
}

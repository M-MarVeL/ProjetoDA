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
    public partial class Sessoes : UserControl {
        public Sessoes() {
            InitializeComponent();
        }

        public void CarregarDados() {
            dataSessao.DataSource = null;
            dataSessao.DataSource = SessaoController.getPrincipalSessao();

            getSalas();

            getFilmes();
        }

        private void LimparDados() {
            tbId.Text = "";
            cbFilme.Text = "";
            cbSala.Text = "";
            tbPreco.Text = "";
        }

        private void getSalas() {
            var salas = SalaController.getAllSalas();

            cbSala.Items.Clear();

            foreach (var s in salas) {
                cbSala.Items.Add(s.Nome);
            }
        }

        private void getFilmes() {
            var filmes = FilmeController.getActiveFilmes();

            cbFilme.Items.Clear();

            foreach (var f in filmes) {
                cbFilme.Items.Add(f.Nome);
            }
        }

        private void getDados(string id, string data, string filme, string sala, string preco) {
            tbId.Text = id;
            dtData.Value = DateTime.Parse(data);
            cbFilme.Text = FilmeController.getNameFilme(int.Parse(filme));
            cbSala.Text = SalaController.getNameSala(int.Parse(sala));
            tbPreco.Text = preco;
        }

        private void dataSessao_CellClick(object sender, DataGridViewCellEventArgs e) {
            string id = dataSessao.CurrentRow.Cells[0].Value.ToString();
            string data = dataSessao.CurrentRow.Cells[1].Value.ToString();
            string filme = dataSessao.CurrentRow.Cells[4].Value.ToString();
            string sala = dataSessao.CurrentRow.Cells[3].Value.ToString();
            string preco = dataSessao.CurrentRow.Cells[2].Value.ToString();

            getDados(id, data, filme, sala, preco);
        }

        private void btnNovo_Click(object sender, EventArgs e) {
            SessaoController.inserirDados(dtData.Value, cbSala.Text, cbFilme.Text, float.Parse(tbPreco.Text));
            CarregarDados();
            LimparDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e) {
            if(!(tbId.Text == null)) {
                SessaoController.alterarDados(int.Parse(tbId.Text), dtData.Value, cbSala.Text, cbFilme.Text, float.Parse(tbPreco.Text));
                CarregarDados();
                LimparDados();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (!(tbId.Text == null)) {
                SessaoController.eliminarDados(int.Parse(tbId.Text));
                CarregarDados();
                LimparDados();
            }
        }
    }
}

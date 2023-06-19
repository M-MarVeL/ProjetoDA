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
    public partial class Filmes : UserControl {
        public Filmes() {
            InitializeComponent();
            tbId.Text = null;
        }

        public void CarregarDados() {

            filmesData.DataSource = null;
            filmesData.DataSource = FilmeController.getAllFilmes();

            categoriasData.DataSource = null;
            categoriasData.DataSource = CategoriaController.getAllCategorias();

            dpGetCategorias();

        }

        public void LimparCategorias() {
            tbId.Text = null;
            tbCategoria.Text = "";
            cbActivo.Checked = false;
        }

        private void btnCategoria_Click(object sender, EventArgs e) {

            CategoriaController.inserirCategoria(tbCategoria.Text, cbActivo.Checked);
            CarregarDados();
            LimparCategorias();

        }

        public void dpGetCategorias() {
            var categorias = CategoriaController.getActiveCategorias();

            cbCategorias.Items.Clear();

            foreach (var c in categorias) {
                cbCategorias.Items.Add(c.Nome);
            }
        }

        private void categoriasData_CellClick(object sender, DataGridViewCellEventArgs e) {


            string id = categoriasData.CurrentRow.Cells[0].Value.ToString();
            string nome = categoriasData.CurrentRow.Cells[1].Value.ToString();
            string activo = categoriasData.CurrentRow.Cells[2].Value.ToString();

            CategoriasToShow(id, nome, bool.Parse(activo));

        }

        private void CategoriasToShow(string id, string nome, bool activo) {
            tbCategoria.Text = nome;
            tbId.Text = id;
            cbActivo.Checked = activo;
        }

        private void btnCategoriaAlterar_Click(object sender, EventArgs e) {
            if (!(tbId.Text is null)) {
                CategoriaController.alterarCategoria(int.Parse(tbId.Text), tbCategoria.Text, cbActivo.Checked);
                CarregarDados();
                LimparCategorias();
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e) {
            if (!(tbId.Text is null)) {
                CategoriaController.eliminarCategoria(int.Parse(tbId.Text));
                CarregarDados();
                LimparCategorias();
            }
        }

        private void btnNovoFilme_Click(object sender, EventArgs e) {

            FilmeController.inserirFilme(tbNomeFilme.Text, int.Parse(tbDuracaoFilme.Text), cbFilme.Checked, cbCategorias.Text);
            CarregarDados();
        }

        private void filmesData_CellClick(object sender, DataGridViewCellEventArgs e) {

            string id = filmesData.CurrentRow.Cells[0].Value.ToString();
            string nome = filmesData.CurrentRow.Cells[1].Value.ToString();
            string duracao = filmesData.CurrentRow.Cells[2].Value.ToString();
            string activo = filmesData.CurrentRow.Cells[3].Value.ToString();
            string categoria = filmesData.CurrentRow.Cells[4].Value.ToString();


            FilmesToShow(id, nome, duracao, bool.Parse(activo), categoria);
        }

        private void LimparFilmes() {
            tbIdFilme.Text = "";
            tbNomeFilme.Text = "";
            tbDuracaoFilme.Text = "";
            cbFilme.Checked = false;
            cbCategorias.Text = "";
        }

        private void FilmesToShow(string id, string nome, string duracao, bool activo, string categoria) {
            tbIdFilme.Text = id;
            tbNomeFilme.Text = nome;
            tbDuracaoFilme.Text = duracao;
            cbFilme.Checked = activo;
            cbCategorias.Text = CategoriaController.getNomeCategoria(int.Parse(categoria));
        }

        private void btnAlterarFilme_Click(object sender, EventArgs e) {
            if (!(tbIdFilme.Text is null)) {
                FilmeController.alterarFilme(int.Parse(tbIdFilme.Text), tbNomeFilme.Text, int.Parse(tbDuracaoFilme.Text), cbFilme.Checked, cbCategorias.Text);
                CarregarDados();
                LimparFilmes();
            }
        }

        private void btnEliminarFilme_Click(object sender, EventArgs e) {
            if (!(tbIdFilme.Text is null)) {
                FilmeController.eliminarFilme(int.Parse(tbIdFilme.Text));
                CarregarDados();
                LimparFilmes();
            }
        }
    }
}

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
    public partial class Cinema : UserControl {
        public Cinema() {
            InitializeComponent();
        }

        public void CarregarDados() {
            dataSalas.DataSource = null;
            dataSalas.DataSource = SalaController.getAllSalas();
        }

        private void LimparDados() {
            tbId.Text = "";
            tbNomeSala.Text = "";
            tbFilas.Text = "";
            tbColunas.Text = "";
        }

        private void putDados(string id, string nome, string colunas, string filas) {
            tbId.Text = id;
            tbNomeSala.Text = nome;
            tbFilas.Text = filas;
            tbColunas.Text = colunas;
        }

        private void btnNovo_Click(object sender, EventArgs e) {
            SalaController.inserirSala(tbNomeSala.Text, int.Parse(tbFilas.Text), int.Parse(tbColunas.Text));
            CarregarDados();
            LimparDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e) {

            if(!(tbId.Text == null)) {
                SalaController.alterarSala(int.Parse(tbId.Text), tbNomeSala.Text, int.Parse(tbFilas.Text), int.Parse(tbColunas.Text));
                CarregarDados();
                LimparDados();
            }
        }

        private void dataSalas_CellClick(object sender, DataGridViewCellEventArgs e) {

            string id = dataSalas.CurrentRow.Cells[0].Value.ToString();
            string nome = dataSalas.CurrentRow.Cells[1].Value.ToString();
            string filas = dataSalas.CurrentRow.Cells[2].Value.ToString();
            string colunas = dataSalas.CurrentRow.Cells[3].Value.ToString();

            putDados(id, nome, colunas, filas);
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (!(tbId.Text == null)) {
                SalaController.eliminarSala(int.Parse(tbId.Text));
                CarregarDados();
                LimparDados();
            }
        }
    }
}

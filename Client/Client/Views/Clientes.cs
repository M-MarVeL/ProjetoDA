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
    public partial class Clientes : UserControl {
        public Clientes() {
            InitializeComponent();
        }

        public void CarregarDados() {
            dataClientes.DataSource = null;
            dataClientes.DataSource = ClienteController.getAllClientes();
        }

        private void LimparDados() {
            tbId.Text = "";
            tbNome.Text = "";
            tbMorada.Text = "";
            tbNif.Text = "";
        }

        private void putDados(string id, string nome, string morada, string nif) {
            tbId.Text = id;
            tbNome.Text = nome;
            tbMorada.Text = morada;
            tbNif.Text = nif;
        }


        private void btnNovo_Click(object sender, EventArgs e) {
            ClienteController.inserirCliente(tbNome.Text, tbMorada.Text, int.Parse(tbNif.Text));
            CarregarDados();
            LimparDados();
        }

        private void dataClientes_CellClick(object sender, DataGridViewCellEventArgs e) {
            string id = dataClientes.CurrentRow.Cells[1].Value.ToString();
            string nome = dataClientes.CurrentRow.Cells[2].Value.ToString();
            string morada = dataClientes.CurrentRow.Cells[3].Value.ToString();
            string nif = dataClientes.CurrentRow.Cells[0].Value.ToString();

            putDados(id, nome, morada, nif);
        }

        private void btnAlterar_Click(object sender, EventArgs e) {
            if(!(tbId.Text == null)) {
                ClienteController.alterarCliente(int.Parse(tbId.Text), tbNome.Text, tbMorada.Text, int.Parse(tbNif.Text));
                CarregarDados();
                LimparDados();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e) {
            if(!(tbId.Text == null)) {
                ClienteController.eliminarCliente(int.Parse(tbId.Text));
                CarregarDados();
                LimparDados();
            }
        }
    }
}

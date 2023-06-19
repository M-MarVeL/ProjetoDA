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
    public partial class Funcionarios : UserControl {
        public Funcionarios() {
            InitializeComponent();
        }

        public void CarregarDados() {
            dataFuncionario.DataSource = null;
            dataFuncionario.DataSource = FuncionarioController.getFuncionarios();
        }

        private void LimparDados() {
            tbNome.Text = "";
            tbMorada.Text = "";
            tbSalario.Text = "";
            tbFuncao.Text = "";
        }

        private void getDadosFuncionarios(string id, string nome, string morada, string salario, string funcao) {
            tbId.Text = id;
            tbNome.Text = nome;
            tbMorada.Text = morada;
            tbSalario.Text = salario;
            tbFuncao.Text = funcao;
        }

        private void btnNovo_Click(object sender, EventArgs e) {
            FuncionarioController.inserirFuncionarios(tbNome.Text, tbMorada.Text, float.Parse(tbSalario.Text), tbFuncao.Text);
            CarregarDados();
            LimparDados();
        }

        private void dataFuncionario_CellClick(object sender, DataGridViewCellEventArgs e) {
            string id = dataFuncionario.CurrentRow.Cells[2].Value.ToString();
            string nome = dataFuncionario.CurrentRow.Cells[3].Value.ToString();
            string morada = dataFuncionario.CurrentRow.Cells[4].Value.ToString();
            string salario = dataFuncionario.CurrentRow.Cells[0].Value.ToString();
            string funcao = dataFuncionario.CurrentRow.Cells[1].Value.ToString();

            getDadosFuncionarios(id, nome, morada, salario, funcao);

        }

        private void btnAlterar_Click(object sender, EventArgs e) {
            if (!(tbId.Text is null)) {
                FuncionarioController.alterarFuncionario(int.Parse(tbId.Text), tbNome.Text, tbMorada.Text, float.Parse(tbSalario.Text), tbFuncao.Text);
                CarregarDados();
                LimparDados();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (!(tbId.Text is null)) {
                FuncionarioController.eliminarFuncionario(int.Parse(tbId.Text));
                CarregarDados();
                LimparDados();
            }
        }
    }
}

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
            CarregarFuncionario();
        }


        private void CarregarFuncionario() {
            var funcionario = FuncionarioController.getAllFuncionarios();

            foreach (var f in funcionario) {
                cbFuncionario.Items.Add(f);
            }
        }


        public void sessaoData_CellClick(object sender, DataGridViewCellEventArgs e) {
            atendimento1.idSessao = int.Parse(sessaoData.CurrentRow.Cells[0].Value.ToString());
            atendimento1.DataHora = DateTime.Parse(sessaoData.CurrentRow.Cells[1].Value.ToString());
            atendimento1.Preco = float.Parse(sessaoData.CurrentRow.Cells[2].Value.ToString());
            atendimento1.SalaId = int.Parse(sessaoData.CurrentRow.Cells[3].Value.ToString());
            atendimento1.FilmeId = int.Parse(sessaoData.CurrentRow.Cells[4].Value.ToString());
            atendimento1.nomeFuncionario = cbFuncionario.Text;
            atendimento1.Visible = true;
            atendimento1.CarregarDados();
        }

        public void CarregarSessaoForm() {
            atendimento1.Visible = false;
            this.Visible = true;
        }

    }
}

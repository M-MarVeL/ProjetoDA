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
    public partial class Atendimento : UserControl {

        public int idSessao;
        public DateTime DataHora;
        public float Preco;
        public int SalaId;
        public int FilmeId;

        public Atendimento() {
            InitializeComponent();
        }

        private void cbAnonimo_CheckedChanged(object sender, EventArgs e) {
            if(cbAnonimo.Checked == true) { changeCliente(true); } 
            else { changeCliente(false); }

        }

        private void changeCliente(bool estado) {
            tbNome.ReadOnly = estado;
            tbMorada.ReadOnly = estado;
            tbNIF.ReadOnly = estado;
        }

        public void CarregarDados() {
            getDados();
        }

       private void getDados() {
            var sala = SalaController.getSalabyId(SalaId);
            // var bilhetes = BilheteController.GetBilhete(int.Parse(tbSessaoId.Text));

            int chair = 1;

            for (int i = 0; i < sala.Filas; i++) {
                for (int j = 0; j < sala.Colunas; j++) {
                    Label lbchair = new Label();

                    lbchair.Text = chair + "";
                    lbchair.AutoSize = false;
                    lbchair.Dock = DockStyle.Fill;
                    lbchair.TextAlign = ContentAlignment.MiddleCenter;

                    lbchair.BackColor = Color.Green;

                    tableLugares.Controls.Add(lbchair, i, j);

                    chair++;

                    lbchair.Click += lbchair_Click;
                }
            }
        }

        private void lbchair_Click(object sender, EventArgs e) {
            Label lbchair = sender as Label;

            if(lbchair.BackColor == Color.Green) {
                lbchair.BackColor = Color.Red;
            } else if(lbchair.BackColor == Color.Red) {
                lbchair.BackColor = Color.Green;
            }
        }


        private void cbSessao_SelectedValueChanged(object sender, EventArgs e) {
            // getDados();
        }

        private void btnNovoBilhete_Click(object sender, EventArgs e) {
            foreach (Control control in tableLugares.Controls) {
                if(control is Label label) {
                    if(label.BackColor == Color.Red) {
                        
                    }
                }
            }
        }
    }
}

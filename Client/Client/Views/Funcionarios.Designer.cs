
namespace Client.Views {
    partial class Funcionarios {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFuncionario = new System.Windows.Forms.DataGridView();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFuncao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(508, 159);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 48);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Funcionario";
            // 
            // dataFuncionario
            // 
            this.dataFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFuncionario.Location = new System.Drawing.Point(53, 237);
            this.dataFuncionario.Name = "dataFuncionario";
            this.dataFuncionario.Size = new System.Drawing.Size(550, 180);
            this.dataFuncionario.TabIndex = 2;
            this.dataFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFuncionario_CellClick);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(16, 52);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(220, 20);
            this.tbNome.TabIndex = 3;
            // 
            // tbMorada
            // 
            this.tbMorada.Location = new System.Drawing.Point(16, 91);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.Size = new System.Drawing.Size(220, 20);
            this.tbMorada.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Morada";
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(16, 139);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(220, 20);
            this.tbSalario.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salario";
            // 
            // tbFuncao
            // 
            this.tbFuncao.Location = new System.Drawing.Point(16, 187);
            this.tbFuncao.Name = "tbFuncao";
            this.tbFuncao.Size = new System.Drawing.Size(220, 20);
            this.tbFuncao.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Função";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(271, 159);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 48);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(389, 159);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(95, 48);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(599, 15);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(48, 20);
            this.tbId.TabIndex = 12;
            this.tbId.Visible = false;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tbFuncao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMorada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.dataFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Name = "Funcionarios";
            this.Size = new System.Drawing.Size(672, 449);
            ((System.ComponentModel.ISupportInitialize)(this.dataFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataFuncionario;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbMorada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFuncao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox tbId;
    }
}

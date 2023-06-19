
namespace Client.Views {
    partial class Cinema {
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataSalas = new System.Windows.Forms.DataGridView();
            this.tbNomeSala = new System.Windows.Forms.TextBox();
            this.tbColunas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // dataSalas
            // 
            this.dataSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalas.Location = new System.Drawing.Point(38, 191);
            this.dataSalas.Name = "dataSalas";
            this.dataSalas.Size = new System.Drawing.Size(497, 176);
            this.dataSalas.TabIndex = 1;
            this.dataSalas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSalas_CellClick);
            // 
            // tbNomeSala
            // 
            this.tbNomeSala.Location = new System.Drawing.Point(38, 51);
            this.tbNomeSala.Name = "tbNomeSala";
            this.tbNomeSala.Size = new System.Drawing.Size(159, 20);
            this.tbNomeSala.TabIndex = 2;
            // 
            // tbColunas
            // 
            this.tbColunas.Location = new System.Drawing.Point(38, 96);
            this.tbColunas.Name = "tbColunas";
            this.tbColunas.Size = new System.Drawing.Size(159, 20);
            this.tbColunas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filas";
            // 
            // tbFilas
            // 
            this.tbFilas.Location = new System.Drawing.Point(38, 135);
            this.tbFilas.Name = "tbFilas";
            this.tbFilas.Size = new System.Drawing.Size(159, 20);
            this.tbFilas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Colunas";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(234, 126);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(73, 36);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(313, 126);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(73, 36);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(392, 126);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 36);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(462, 13);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(85, 20);
            this.tbId.TabIndex = 10;
            this.tbId.Visible = false;
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tbFilas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbColunas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomeSala);
            this.Controls.Add(this.dataSalas);
            this.Controls.Add(this.label1);
            this.Name = "Cinema";
            this.Size = new System.Drawing.Size(580, 401);
            ((System.ComponentModel.ISupportInitialize)(this.dataSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataSalas;
        private System.Windows.Forms.TextBox tbNomeSala;
        private System.Windows.Forms.TextBox tbColunas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbId;
    }
}

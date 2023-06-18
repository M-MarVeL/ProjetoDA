
namespace Client.Views {
    partial class Filmes {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFilme = new System.Windows.Forms.CheckBox();
            this.btnEliminarFilme = new System.Windows.Forms.Button();
            this.btnAlterarFilme = new System.Windows.Forms.Button();
            this.btnNovoFilme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.tbDuracaoFilme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeFilme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.cbActivo = new System.Windows.Forms.CheckBox();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.btnCategoriaAlterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.categoriasData = new System.Windows.Forms.DataGridView();
            this.filmesData = new System.Windows.Forms.DataGridView();
            this.tbIdFilme = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmesData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIdFilme);
            this.groupBox1.Controls.Add(this.cbFilme);
            this.groupBox1.Controls.Add(this.btnEliminarFilme);
            this.groupBox1.Controls.Add(this.btnAlterarFilme);
            this.groupBox1.Controls.Add(this.btnNovoFilme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbCategorias);
            this.groupBox1.Controls.Add(this.tbDuracaoFilme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNomeFilme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filmes";
            // 
            // cbFilme
            // 
            this.cbFilme.AutoSize = true;
            this.cbFilme.Location = new System.Drawing.Point(182, 125);
            this.cbFilme.Name = "cbFilme";
            this.cbFilme.Size = new System.Drawing.Size(56, 17);
            this.cbFilme.TabIndex = 19;
            this.cbFilme.Text = "Activo";
            this.cbFilme.UseVisualStyleBackColor = true;
            // 
            // btnEliminarFilme
            // 
            this.btnEliminarFilme.Location = new System.Drawing.Point(216, 160);
            this.btnEliminarFilme.Name = "btnEliminarFilme";
            this.btnEliminarFilme.Size = new System.Drawing.Size(67, 29);
            this.btnEliminarFilme.TabIndex = 8;
            this.btnEliminarFilme.Text = "Eliminar";
            this.btnEliminarFilme.UseVisualStyleBackColor = true;
            this.btnEliminarFilme.Click += new System.EventHandler(this.btnEliminarFilme_Click);
            // 
            // btnAlterarFilme
            // 
            this.btnAlterarFilme.Location = new System.Drawing.Point(143, 160);
            this.btnAlterarFilme.Name = "btnAlterarFilme";
            this.btnAlterarFilme.Size = new System.Drawing.Size(67, 29);
            this.btnAlterarFilme.TabIndex = 7;
            this.btnAlterarFilme.Text = "Alterar";
            this.btnAlterarFilme.UseVisualStyleBackColor = true;
            this.btnAlterarFilme.Click += new System.EventHandler(this.btnAlterarFilme_Click);
            // 
            // btnNovoFilme
            // 
            this.btnNovoFilme.Location = new System.Drawing.Point(275, 125);
            this.btnNovoFilme.Name = "btnNovoFilme";
            this.btnNovoFilme.Size = new System.Drawing.Size(67, 29);
            this.btnNovoFilme.TabIndex = 2;
            this.btnNovoFilme.Text = "Novo";
            this.btnNovoFilme.UseVisualStyleBackColor = true;
            this.btnNovoFilme.Click += new System.EventHandler(this.btnNovoFilme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categorias";
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(65, 90);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(173, 21);
            this.cbCategorias.TabIndex = 2;
            // 
            // tbDuracaoFilme
            // 
            this.tbDuracaoFilme.Location = new System.Drawing.Point(65, 64);
            this.tbDuracaoFilme.Name = "tbDuracaoFilme";
            this.tbDuracaoFilme.Size = new System.Drawing.Size(173, 20);
            this.tbDuracaoFilme.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duração";
            // 
            // tbNomeFilme
            // 
            this.tbNomeFilme.Location = new System.Drawing.Point(65, 34);
            this.tbNomeFilme.Name = "tbNomeFilme";
            this.tbNomeFilme.Size = new System.Drawing.Size(173, 20);
            this.tbNomeFilme.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbId);
            this.groupBox2.Controls.Add(this.cbActivo);
            this.groupBox2.Controls.Add(this.btnEliminarCategoria);
            this.groupBox2.Controls.Add(this.tbCategoria);
            this.groupBox2.Controls.Add(this.btnCategoriaAlterar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnCategoria);
            this.groupBox2.Location = new System.Drawing.Point(418, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(268, 19);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(20, 20);
            this.tbId.TabIndex = 19;
            this.tbId.Visible = false;
            // 
            // cbActivo
            // 
            this.cbActivo.AutoSize = true;
            this.cbActivo.Location = new System.Drawing.Point(190, 66);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(56, 17);
            this.cbActivo.TabIndex = 18;
            this.cbActivo.Text = "Activo";
            this.cbActivo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(179, 148);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(67, 29);
            this.btnEliminarCategoria.TabIndex = 17;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(73, 30);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(173, 20);
            this.tbCategoria.TabIndex = 11;
            // 
            // btnCategoriaAlterar
            // 
            this.btnCategoriaAlterar.Location = new System.Drawing.Point(106, 148);
            this.btnCategoriaAlterar.Name = "btnCategoriaAlterar";
            this.btnCategoriaAlterar.Size = new System.Drawing.Size(67, 29);
            this.btnCategoriaAlterar.TabIndex = 16;
            this.btnCategoriaAlterar.Text = "Alterar";
            this.btnCategoriaAlterar.UseVisualStyleBackColor = true;
            this.btnCategoriaAlterar.Click += new System.EventHandler(this.btnCategoriaAlterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(230, 113);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(67, 29);
            this.btnCategoria.TabIndex = 9;
            this.btnCategoria.Text = "Novo";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // categoriasData
            // 
            this.categoriasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriasData.Location = new System.Drawing.Point(430, 259);
            this.categoriasData.Name = "categoriasData";
            this.categoriasData.Size = new System.Drawing.Size(292, 202);
            this.categoriasData.TabIndex = 2;
            this.categoriasData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriasData_CellClick);
            // 
            // filmesData
            // 
            this.filmesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmesData.Location = new System.Drawing.Point(30, 259);
            this.filmesData.Name = "filmesData";
            this.filmesData.Size = new System.Drawing.Size(382, 202);
            this.filmesData.TabIndex = 3;
            this.filmesData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmesData_CellClick);
            // 
            // tbIdFilme
            // 
            this.tbIdFilme.Location = new System.Drawing.Point(345, 19);
            this.tbIdFilme.Name = "tbIdFilme";
            this.tbIdFilme.Size = new System.Drawing.Size(20, 20);
            this.tbIdFilme.TabIndex = 20;
            this.tbIdFilme.Visible = false;
            // 
            // Filmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filmesData);
            this.Controls.Add(this.categoriasData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Filmes";
            this.Size = new System.Drawing.Size(740, 495);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmesData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarFilme;
        private System.Windows.Forms.Button btnAlterarFilme;
        private System.Windows.Forms.Button btnNovoFilme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.TextBox tbDuracaoFilme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbActivo;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Button btnCategoriaAlterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.DataGridView categoriasData;
        private System.Windows.Forms.DataGridView filmesData;
        private System.Windows.Forms.CheckBox cbFilme;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbIdFilme;
    }
}

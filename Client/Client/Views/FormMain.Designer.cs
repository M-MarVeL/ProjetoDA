
namespace Client.Views {
    partial class FormMain {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.filmesPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FuncPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cinemaPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.sessoesPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.clientePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.filmes1 = new Client.Views.Filmes();
            this.funcionarios1 = new Client.Views.Funcionarios();
            this.principal1 = new Client.Views.Principal();
            this.cinema1 = new Client.Views.Cinema();
            this.clientes1 = new Client.Views.Clientes();
            this.sessoes1 = new Client.Views.Sessoes();
            this.homePanel.SuspendLayout();
            this.filmesPanel.SuspendLayout();
            this.FuncPanel.SuspendLayout();
            this.cinemaPanel.SuspendLayout();
            this.sessoesPanel.SuspendLayout();
            this.clientePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestão \r\n   de \r\nCinema\r\n";
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.homePanel.Controls.Add(this.label2);
            this.homePanel.Location = new System.Drawing.Point(6, 99);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(148, 51);
            this.homePanel.TabIndex = 2;
            this.homePanel.Click += new System.EventHandler(this.homePanel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Home";
            this.label2.Click += new System.EventHandler(this.homePanel_Click);
            // 
            // filmesPanel
            // 
            this.filmesPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.filmesPanel.Controls.Add(this.label3);
            this.filmesPanel.Location = new System.Drawing.Point(6, 165);
            this.filmesPanel.Name = "filmesPanel";
            this.filmesPanel.Size = new System.Drawing.Size(148, 52);
            this.filmesPanel.TabIndex = 3;
            this.filmesPanel.Click += new System.EventHandler(this.filmesPanel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filmes";
            this.label3.Click += new System.EventHandler(this.filmesPanel_Click);
            // 
            // FuncPanel
            // 
            this.FuncPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.FuncPanel.Controls.Add(this.label4);
            this.FuncPanel.Location = new System.Drawing.Point(6, 232);
            this.FuncPanel.Name = "FuncPanel";
            this.FuncPanel.Size = new System.Drawing.Size(148, 52);
            this.FuncPanel.TabIndex = 5;
            this.FuncPanel.Click += new System.EventHandler(this.FuncPanel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Funcionarios";
            this.label4.Click += new System.EventHandler(this.FuncPanel_Click);
            // 
            // cinemaPanel
            // 
            this.cinemaPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.cinemaPanel.Controls.Add(this.label5);
            this.cinemaPanel.Location = new System.Drawing.Point(6, 300);
            this.cinemaPanel.Name = "cinemaPanel";
            this.cinemaPanel.Size = new System.Drawing.Size(148, 52);
            this.cinemaPanel.TabIndex = 6;
            this.cinemaPanel.Click += new System.EventHandler(this.cinemaPanel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinema";
            this.label5.Click += new System.EventHandler(this.cinemaPanel_Click);
            // 
            // sessoesPanel
            // 
            this.sessoesPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.sessoesPanel.Controls.Add(this.label6);
            this.sessoesPanel.Location = new System.Drawing.Point(6, 434);
            this.sessoesPanel.Name = "sessoesPanel";
            this.sessoesPanel.Size = new System.Drawing.Size(148, 52);
            this.sessoesPanel.TabIndex = 7;
            this.sessoesPanel.Click += new System.EventHandler(this.sessoesPanel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sessões";
            this.label6.Click += new System.EventHandler(this.sessoesPanel_Click);
            // 
            // clientePanel
            // 
            this.clientePanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.clientePanel.Controls.Add(this.label7);
            this.clientePanel.Location = new System.Drawing.Point(6, 366);
            this.clientePanel.Name = "clientePanel";
            this.clientePanel.Size = new System.Drawing.Size(148, 52);
            this.clientePanel.TabIndex = 8;
            this.clientePanel.Click += new System.EventHandler(this.clientePanel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "Clientes";
            this.label7.Click += new System.EventHandler(this.clientePanel_Click);
            // 
            // filmes1
            // 
            this.filmes1.Location = new System.Drawing.Point(164, 0);
            this.filmes1.Name = "filmes1";
            this.filmes1.Size = new System.Drawing.Size(805, 531);
            this.filmes1.TabIndex = 0;
            // 
            // funcionarios1
            // 
            this.funcionarios1.Location = new System.Drawing.Point(164, 9);
            this.funcionarios1.Name = "funcionarios1";
            this.funcionarios1.Size = new System.Drawing.Size(805, 552);
            this.funcionarios1.TabIndex = 10;
            // 
            // principal1
            // 
            this.principal1.Location = new System.Drawing.Point(164, 9);
            this.principal1.Name = "principal1";
            this.principal1.Size = new System.Drawing.Size(805, 542);
            this.principal1.TabIndex = 9;
            // 
            // cinema1
            // 
            this.cinema1.Location = new System.Drawing.Point(164, 9);
            this.cinema1.Name = "cinema1";
            this.cinema1.Size = new System.Drawing.Size(805, 552);
            this.cinema1.TabIndex = 11;
            // 
            // clientes1
            // 
            this.clientes1.Location = new System.Drawing.Point(163, 9);
            this.clientes1.Name = "clientes1";
            this.clientes1.Size = new System.Drawing.Size(806, 552);
            this.clientes1.TabIndex = 12;
            // 
            // sessoes1
            // 
            this.sessoes1.Location = new System.Drawing.Point(163, 9);
            this.sessoes1.Name = "sessoes1";
            this.sessoes1.Size = new System.Drawing.Size(806, 552);
            this.sessoes1.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 532);
            this.Controls.Add(this.clientePanel);
            this.Controls.Add(this.sessoesPanel);
            this.Controls.Add(this.cinemaPanel);
            this.Controls.Add(this.FuncPanel);
            this.Controls.Add(this.filmesPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmes1);
            this.Controls.Add(this.funcionarios1);
            this.Controls.Add(this.principal1);
            this.Controls.Add(this.cinema1);
            this.Controls.Add(this.clientes1);
            this.Controls.Add(this.sessoes1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Cinema";
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.filmesPanel.ResumeLayout(false);
            this.filmesPanel.PerformLayout();
            this.FuncPanel.ResumeLayout(false);
            this.FuncPanel.PerformLayout();
            this.cinemaPanel.ResumeLayout(false);
            this.cinemaPanel.PerformLayout();
            this.sessoesPanel.ResumeLayout(false);
            this.sessoesPanel.PerformLayout();
            this.clientePanel.ResumeLayout(false);
            this.clientePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Filmes filmes1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel filmesPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel FuncPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel cinemaPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel sessoesPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel clientePanel;
        private System.Windows.Forms.Label label7;
        private Principal principal1;
        private Funcionarios funcionarios1;
        private Cinema cinema1;
        private Clientes clientes1;
        private Sessoes sessoes1;
    }
}
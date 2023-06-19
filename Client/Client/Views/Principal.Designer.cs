
namespace Client.Views {
    partial class Principal {
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
            this.sessaoData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.atendimento1 = new Client.Views.Atendimento();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoData)).BeginInit();
            this.SuspendLayout();
            // 
            // sessaoData
            // 
            this.sessaoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessaoData.Location = new System.Drawing.Point(25, 83);
            this.sessaoData.Name = "sessaoData";
            this.sessaoData.Size = new System.Drawing.Size(618, 151);
            this.sessaoData.TabIndex = 0;
            this.sessaoData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sessaoData_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sessões";
            // 
            // atendimento1
            // 
            this.atendimento1.Location = new System.Drawing.Point(0, 0);
            this.atendimento1.Name = "atendimento1";
            this.atendimento1.Size = new System.Drawing.Size(772, 495);
            this.atendimento1.TabIndex = 2;
            this.atendimento1.Visible = false;
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(577, 16);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(164, 21);
            this.cbFuncionario.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.atendimento1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sessaoData);
            this.Name = "Principal";
            this.Size = new System.Drawing.Size(775, 498);
            ((System.ComponentModel.ISupportInitialize)(this.sessaoData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sessaoData;
        private System.Windows.Forms.Label label1;
        private Atendimento atendimento1;
        private System.Windows.Forms.ComboBox cbFuncionario;
    }
}

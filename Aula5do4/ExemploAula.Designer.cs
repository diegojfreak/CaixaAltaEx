namespace Aula5do4
{
    partial class ExemploAula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Processamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoAlta = new System.Windows.Forms.RadioButton();
            this.rdoBaixa = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 23);
            this.txtNome.TabIndex = 0;
            // 
            // Processamento
            // 
            this.Processamento.Location = new System.Drawing.Point(204, 98);
            this.Processamento.Name = "Processamento";
            this.Processamento.Size = new System.Drawing.Size(75, 23);
            this.Processamento.TabIndex = 1;
            this.Processamento.Text = "OK";
            this.Processamento.UseVisualStyleBackColor = true;
            this.Processamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // rdoAlta
            // 
            this.rdoAlta.AutoSize = true;
            this.rdoAlta.Checked = true;
            this.rdoAlta.Location = new System.Drawing.Point(12, 80);
            this.rdoAlta.Name = "rdoAlta";
            this.rdoAlta.Size = new System.Drawing.Size(78, 19);
            this.rdoAlta.TabIndex = 3;
            this.rdoAlta.TabStop = true;
            this.rdoAlta.Text = "Caixa Alta";
            this.rdoAlta.UseVisualStyleBackColor = true;
            // 
            // rdoBaixa
            // 
            this.rdoBaixa.AutoSize = true;
            this.rdoBaixa.Location = new System.Drawing.Point(112, 80);
            this.rdoBaixa.Name = "rdoBaixa";
            this.rdoBaixa.Size = new System.Drawing.Size(85, 19);
            this.rdoBaixa.TabIndex = 4;
            this.rdoBaixa.Text = "Caixa Baixa";
            this.rdoBaixa.UseVisualStyleBackColor = true;
            // 
            // ExemploAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 133);
            this.Controls.Add(this.rdoBaixa);
            this.Controls.Add(this.rdoAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Processamento);
            this.Controls.Add(this.txtNome);
            this.Name = "ExemploAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExemploAula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button Processamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoAlta;
        private System.Windows.Forms.RadioButton rdoBaixa;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aula5do4
{
    public partial class ExemploAula : Form
    {
        public ExemploAula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string digitado = txtNome.Text;
            if (rdoAlta.Checked)
            {
                digitado = digitado.ToUpper();
            }

            if (rdoBaixa.Checked)
            {
                digitado = digitado.ToLower();
            }

            MessageBox.Show(digitado);

            rdoAlta.Checked = true;
            txtNome.Text = " ";
            txtNome.Focus();

        }
    }
}

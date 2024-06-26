using System;
using System.Windows.Forms;

namespace Idade
{
    public partial class frmIdade : Form
    {
        public frmIdade()
        {
            InitializeComponent();
        }

        private void frmIdade_Load(object sender, EventArgs e)
        {
            txtDia_At.Text = DateTime.Now.Day.ToString();
            txtMes_At.Text = DateTime.Now.Month.ToString();
            txtAno_At.Text = DateTime.Now.Year.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtDia_Nasc.Text == "")
            {
                MessageBox.Show("Informe o dia de nascimento", "Ops !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDia_Nasc.Focus();
            }
            else if (Convert.ToInt32(txtDia_Nasc.Text) < 1 || Convert.ToInt32(txtDia_Nasc.Text) > 31)
            {
                MessageBox.Show("O dia de nascimento deve ser maior que 1 e igual ou inferior a 31", "Ops !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDia_Nasc.Focus();
                txtDia_Nasc.Clear();
            }

            else if (txtMes_Nasc.Text == "")
            {
                MessageBox.Show("Informe o mês de nascimento", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMes_Nasc.Focus();

            }

            else if (Convert.ToInt32(txtMes_Nasc.Text) < 1 || Convert.ToInt32(txtMes_Nasc.Text) > 12)
            {
                MessageBox.Show("O mês de nascimento deve ser maior que 1 e igual ou menor a 12", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMes_Nasc.Focus();
                txtMes_Nasc.Clear();

            }

            else if (txtAno_At.Text == "")
            {
                MessageBox.Show("Informe o ano de nascimento", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAno_Nasc.Focus();
            }
            else if (Convert.ToInt32(txtAno_Nasc.Text) < 1 || Convert.ToInt32(txtAno_Nasc.Text) >= Convert.ToInt32(txtAno_At.Text))
            {
                MessageBox.Show("O ano deve ser maior que zero e menor que o atual!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAno_Nasc.Focus();
                txtAno_Nasc.Clear();
            }

            else if (Convert.ToDecimal(txtMes_Nasc.Text) < Convert.ToDecimal(txtMes_At.Text))
            {
                txtIdade.Text = Convert.ToString(Convert.ToInt32(txtAno_At) - Convert.ToInt32(txtAno_Nasc.Text));
            }

            else if (Convert.ToDecimal(txtMes_Nasc.Text) > Convert.ToDecimal(txtMes_At.Text))
            {
                txtIdade.Text = Convert.ToString(Convert.ToInt32(txtAno_At.Text) - Convert.ToInt32(txtAno_Nasc.Text) - 1);
            }

            else if (Convert.ToDecimal(txtMes_Nasc.Text) == Convert.ToDecimal(txtMes_At.Text))
            {
                if (Convert.ToDecimal(txtDia_Nasc.Text) <= Convert.ToDecimal(txtDia_At.Text))
                    txtIdade.Text = Convert.ToString(Convert.ToInt32(txtAno_At) - Convert.ToInt32(txtAno_Nasc.Text));

                else
                    txtIdade.Text = Convert.ToString(Convert.ToInt32(txtAno_At) - Convert.ToInt32(txtAno_Nasc.Text) - 1);


            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDia_Nasc.Clear();
            txtMes_Nasc.Clear();
            txtAno_Nasc.Clear();

            txtDia_Nasc.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDia_Nasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMes_Nasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtAno_Nasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtDia_At_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}

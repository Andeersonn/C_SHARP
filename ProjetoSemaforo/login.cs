using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSemaforo
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string senha;
            senha = txtsenha.Text;
            senha = senha.ToUpper();
            if (senha == "UNISAGRADO")
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("senha invalida!Tente Novamente.",
                    "VALIDAÇÃO LOGIN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtsenha.Text = "";
                txtsenha.Focus();


            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void formlogin_Load(object sender, EventArgs e)
        {

        }
    }
}

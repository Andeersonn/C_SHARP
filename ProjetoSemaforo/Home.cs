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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdistancia.Text = "";
            txttempog.Text = "";
            txtvelocidadem.Text = "";
            txtvelocidademax.Text = "";
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            float distancia = 0, tempo = 0, velocidademedia = 0;

            distancia = float.Parse(txtdistancia.Text);
            tempo = float.Parse(txttempog.Text);
            velocidademedia = distancia / tempo;

            txtvelocidadem.Text = velocidademedia.ToString();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnvisualizar_Click(object sender, EventArgs e)
        {
            this.Hide();

            formvisual formDestino = new formvisual(txtvelocidademax.Text, txtvelocidadem.Text);
            formDestino.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtvelocidadem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdistancia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

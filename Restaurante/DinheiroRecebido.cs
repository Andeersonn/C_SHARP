using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class DinheiroRecebido : Form
    {

       
        public DinheiroRecebido(string pago)
        {
            InitializeComponent();
            textBox2.Text = pago;
            textBox2.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DinheiroRecebido_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fechamento finalizar = new fechamento(textBox1.Text,textBox2.Text);
            finalizar.ShowDialog();
            this.Close();
 
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "PC";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "MAC";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Notebook";
        }

        private void Forma_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                label6.Text = "FAX";
            else
                label6.Text = "";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                label7.Text = "Calculadora";
            else
                label7.Text = "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                label8.Text = "Copiadora";
            else
                label8.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = listBox1.SelectedItem.ToString();
        }

        private void Pagamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = Pagamentos.SelectedItem.ToString();
        }
    }
}

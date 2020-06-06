using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurante
{
    public partial class fechamento : Form
    {
        public fechamento()
        {
            InitializeComponent();
         
        }
        public fechamento(string valor, string valor2)
        {
            InitializeComponent();
            textBoxrecebido.Text = valor;
            textBoxvlrpago.Text = valor2;


            double recebido = double.Parse(textBoxrecebido.Text);
            double total = double.Parse(textBoxvlrpago.Text);
            double troco;
            troco = recebido - total;
            //troco = double.Parse(textBoxtroco.Text);
            textBoxtroco.Text = troco.ToString("C", CultureInfo.CurrentCulture);

        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda Finalizada Com Sucesso!","Validação Comppra",MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();

        }

        private void maskedvalorpago_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void fechamento_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            rddinheiro.Enabled = true;
            rddebito.Enabled = true;
            rdcedito.Enabled = true;
        }

        private void textvalor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxvlrpago_TextChanged(object sender, EventArgs e)
        {
                        
        }

        private void texttroco_TextChanged(object sender, EventArgs e)
        { 

            
       
    }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            if(rddebito.Enabled == true)
            {
                groupBox2.Enabled = true;
                radioButton6.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = false;
                radioButton6.Enabled = true;
            }
        }

        private void rdcedito_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            if(rdcedito.Checked == true)
            {
                groupBox2.Enabled = true;
                radioButton6.Enabled = true;
            }else
            {
                groupBox2.Enabled = false;
            }
        }

        private void rddinheiro_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            if(rddinheiro.Enabled == true)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {


        }
    }
}

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
    public partial class Form1 : Form
    {
            
            double chopp = 0;
            double quantChopp = 0;
            double petisco = 0;
            double quantPetisco = 0;
            double refeicao = 0;
            double quantRefeicao = 0;
            double parcial = 0;
            double servico = 0;
        


    public Form1()
    {
        InitializeComponent();
        textBox3.Focus();

        }   

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Enabled == true)
            {
                btnfechar.Enabled = false;
            }else
            {
                btnfechar.Enabled = true;
            }
            this.Hide();

            DinheiroRecebido fechar = new DinheiroRecebido(textBoxtotalpagar.Text);
            fechar.ShowDialog();
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxchop.Checked == true)
            {
                if (maskshop.Text == "")
                {

                    quantChopp = 0;

                }
                else
                {
                    chopp = double.Parse(maskshop.Text);
                    quantChopp = chopp * 4.50;
                }

            }
            if (checkBoxchop.Checked == false)
            {
                maskshop.Text = "";
                quantChopp = 0;

            }

            if (checkBoxpetisco.Checked == true)
            {
                if (maskpetisco.Text == "")
                {
                    petisco = 0;
                }
                else
                {
                    petisco = double.Parse(maskpetisco.Text);
                    quantPetisco = petisco * 7.90;
                }

            }
            if (checkBoxpetisco.Checked == false)
            {
                maskpetisco.Text = "";
                quantPetisco = 0;

            }

            if (checkBoxrefeicao.Checked == true)
            {
                if (maskrefeicao.Text == "")
                {
                    refeicao = 0;
                }
                else
                {
                    refeicao = double.Parse(maskrefeicao.Text);
                    quantRefeicao = refeicao * 15.90;
                }

            }
            if (checkBoxrefeicao.Checked == false)
            {
                maskrefeicao.Text = "";
                quantRefeicao = 0;

            }

            parcial = quantChopp;
            parcial += quantPetisco;
            parcial += quantRefeicao;
            servico = parcial * 0.10;
            double total = parcial + servico;
            textBox1.Text = parcial.ToString("C", CultureInfo.CurrentCulture);
            textBox2.Text = servico.ToString("C", CultureInfo.CurrentCulture);
            textBoxtotalpagar.Text = total.ToString();
            //textBoxtotalpagar.Text = totalpagar.ToString();*/

              
                

            
           
  
   
        }

        private void textBoxchop_TextChanged(object sender, EventArgs e)
        {
                

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxchop_CheckedChanged(object sender, EventArgs e)
        {
            
            if(checkBoxchop.Checked == true)
            {
                maskshop.Enabled = true;
            }
            else
            {
                maskshop.Enabled = false;
            }
        }

        private void checkBoxpetisco_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxpetisco.Checked == true)
            {
                maskpetisco.Enabled = true;
            }
            else
            {
                maskpetisco.Enabled = false;
            }
        }

        private void checkBoxrefeicao_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxrefeicao.Checked == true)
            {
                maskrefeicao.Enabled = true;
            }
            else
            {
                maskrefeicao.Enabled = false;
            }
        }

        private void maskedmesa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

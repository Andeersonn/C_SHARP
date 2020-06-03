using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSemaforo
{
    public partial class formvisual : Form
    {
        public formvisual(string valor1, string vm)
        {
           InitializeComponent();

             float acima = 0, permitida = 0, media = 0;
            string path = Directory.GetCurrentDirectory();

           txtvelocidadep.Text = valor1;
            txtvelocidadem.Text = vm;

            permitida = float.Parse(valor1);
            media = float.Parse(vm);

            if (media > permitida)
            {
                timer1.Enabled = true;
                acima = (media - permitida);
                lblqtdex.Text = acima.ToString();
                pictureBox1.Image = Image.FromFile("D:\\3Semeste-C.COMPUTACAO\\C#-ELVIO\\trabalhoSemaforo07-04\\ProjetoSemaforo\\Sinal_vermelho.jpg");
                lblmensagem1.Text = "Voce esta correndo risco com esta velocidade!!!";
                lblmensagem2.Text = "Respeite os Limites de velocidade.";

            }
            else
            {
                lblqtdex.Text = "";
                lblmensagem1.Text = "";
                pictureBox1.Image = Image.FromFile("D:\\3Semeste-C.COMPUTACAO\\C#-ELVIO\\trabalhoSemaforo07-04\\ProjetoSemaforo\\Sinal_verde.jpg");
                lblmensagem2.ForeColor = Color.Blue;
                lblmensagem2.Text = "Voce esta dentro da Velocidade!";

            }

            //permitida = float.Parse(valor1);
            //media = float.Parse(vm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formvisual_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblmensagem2.ForeColor = lblmensagem2.ForeColor==Color.Red ? Color.Black:Color.Red;
        }

        private void lblqtdex_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

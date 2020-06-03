namespace ProjetoSemaforo
{
    partial class Home
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
            this.btnnovo = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnvisualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtvelocidademax = new System.Windows.Forms.TextBox();
            this.txtdistancia = new System.Windows.Forms.TextBox();
            this.txttempog = new System.Windows.Forms.TextBox();
            this.txtvelocidadem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(59, 386);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(145, 34);
            this.btnnovo.TabIndex = 0;
            this.btnnovo.Text = "&Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(321, 386);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(141, 34);
            this.btncalc.TabIndex = 1;
            this.btncalc.Text = "&Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnvisualizar
            // 
            this.btnvisualizar.Location = new System.Drawing.Point(588, 386);
            this.btnvisualizar.Name = "btnvisualizar";
            this.btnvisualizar.Size = new System.Drawing.Size(155, 34);
            this.btnvisualizar.TabIndex = 2;
            this.btnvisualizar.Text = "&Visualizar";
            this.btnvisualizar.UseVisualStyleBackColor = true;
            this.btnvisualizar.Click += new System.EventHandler(this.btnvisualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "km/h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo Gasto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "horas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Distancia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Velocidade Media:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "km/h";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "km/h";
            // 
            // txtvelocidademax
            // 
            this.txtvelocidademax.Location = new System.Drawing.Point(18, 49);
            this.txtvelocidademax.Name = "txtvelocidademax";
            this.txtvelocidademax.Size = new System.Drawing.Size(100, 20);
            this.txtvelocidademax.TabIndex = 11;
            // 
            // txtdistancia
            // 
            this.txtdistancia.Location = new System.Drawing.Point(80, 45);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(100, 20);
            this.txtdistancia.TabIndex = 12;
            this.txtdistancia.TextChanged += new System.EventHandler(this.txtdistancia_TextChanged);
            // 
            // txttempog
            // 
            this.txttempog.Location = new System.Drawing.Point(80, 94);
            this.txttempog.Name = "txttempog";
            this.txttempog.Size = new System.Drawing.Size(100, 20);
            this.txttempog.TabIndex = 13;
            // 
            // txtvelocidadem
            // 
            this.txtvelocidadem.Location = new System.Drawing.Point(157, 289);
            this.txtvelocidadem.Name = "txtvelocidadem";
            this.txtvelocidadem.Size = new System.Drawing.Size(195, 20);
            this.txtvelocidadem.TabIndex = 14;
            this.txtvelocidadem.TextChanged += new System.EventHandler(this.txtvelocidadem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtvelocidademax);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(501, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 145);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Velocidade Maxima Permitida";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtdistancia);
            this.groupBox3.Controls.Add(this.txttempog);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(50, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 145);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados da Viagem";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtvelocidadem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnvisualizar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.btnnovo);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnvisualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtvelocidademax;
        private System.Windows.Forms.TextBox txtdistancia;
        private System.Windows.Forms.TextBox txttempog;
        private System.Windows.Forms.TextBox txtvelocidadem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
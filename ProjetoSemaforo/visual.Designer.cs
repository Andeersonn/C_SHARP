namespace ProjetoSemaforo
{
    partial class formvisual
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnfechar = new System.Windows.Forms.Button();
            this.txtvelocidadep = new System.Windows.Forms.TextBox();
            this.lblqtdex = new System.Windows.Forms.TextBox();
            this.txtvelocidadem = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmensagem1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblmensagem2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(590, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 289);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(631, 365);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(109, 34);
            this.btnfechar.TabIndex = 1;
            this.btnfechar.Text = "&Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtvelocidadep
            // 
            this.txtvelocidadep.Location = new System.Drawing.Point(109, 64);
            this.txtvelocidadep.Name = "txtvelocidadep";
            this.txtvelocidadep.Size = new System.Drawing.Size(146, 20);
            this.txtvelocidadep.TabIndex = 2;
            // 
            // lblqtdex
            // 
            this.lblqtdex.Location = new System.Drawing.Point(109, 337);
            this.lblqtdex.Name = "lblqtdex";
            this.lblqtdex.Size = new System.Drawing.Size(146, 20);
            this.lblqtdex.TabIndex = 3;
            this.lblqtdex.TextChanged += new System.EventHandler(this.lblqtdex_TextChanged);
            // 
            // txtvelocidadem
            // 
            this.txtvelocidadem.Location = new System.Drawing.Point(109, 134);
            this.txtvelocidadem.Name = "txtvelocidadem";
            this.txtvelocidadem.Size = new System.Drawing.Size(146, 20);
            this.txtvelocidadem.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Velociade Permitida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Velocidade Media:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "km/h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "km/h";
            // 
            // lblmensagem1
            // 
            this.lblmensagem1.AutoSize = true;
            this.lblmensagem1.Location = new System.Drawing.Point(12, 297);
            this.lblmensagem1.Name = "lblmensagem1";
            this.lblmensagem1.Size = new System.Drawing.Size(71, 13);
            this.lblmensagem1.TabIndex = 9;
            this.lblmensagem1.Text = "Mensagem 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Qtd. km/h Exedida";
            // 
            // lblmensagem2
            // 
            this.lblmensagem2.AutoSize = true;
            this.lblmensagem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensagem2.ForeColor = System.Drawing.Color.Red;
            this.lblmensagem2.Location = new System.Drawing.Point(12, 384);
            this.lblmensagem2.Name = "lblmensagem2";
            this.lblmensagem2.Size = new System.Drawing.Size(94, 15);
            this.lblmensagem2.TabIndex = 11;
            this.lblmensagem2.Text = "Mensagem 2:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(704, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // formvisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblmensagem2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblmensagem1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvelocidadem);
            this.Controls.Add(this.lblqtdex);
            this.Controls.Add(this.txtvelocidadep);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formvisual";
            this.Text = "visual";
            this.Load += new System.EventHandler(this.formvisual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.TextBox txtvelocidadep;
        private System.Windows.Forms.TextBox lblqtdex;
        private System.Windows.Forms.TextBox txtvelocidadem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblmensagem1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblmensagem2;
        private System.Windows.Forms.Button button2;
    }
}
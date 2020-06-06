namespace Restaurante
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxchop = new System.Windows.Forms.CheckBox();
            this.checkBoxpetisco = new System.Windows.Forms.CheckBox();
            this.checkBoxrefeicao = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskshop = new System.Windows.Forms.MaskedTextBox();
            this.maskpetisco = new System.Windows.Forms.MaskedTextBox();
            this.maskrefeicao = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxtotalpagar = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxchop
            // 
            this.checkBoxchop.AutoSize = true;
            this.checkBoxchop.Location = new System.Drawing.Point(13, 124);
            this.checkBoxchop.Name = "checkBoxchop";
            this.checkBoxchop.Size = new System.Drawing.Size(92, 17);
            this.checkBoxchop.TabIndex = 7;
            this.checkBoxchop.Text = "Chop R$ 4,50";
            this.checkBoxchop.UseVisualStyleBackColor = true;
            this.checkBoxchop.CheckedChanged += new System.EventHandler(this.checkBoxchop_CheckedChanged);
            // 
            // checkBoxpetisco
            // 
            this.checkBoxpetisco.AutoSize = true;
            this.checkBoxpetisco.Location = new System.Drawing.Point(13, 179);
            this.checkBoxpetisco.Name = "checkBoxpetisco";
            this.checkBoxpetisco.Size = new System.Drawing.Size(107, 17);
            this.checkBoxpetisco.TabIndex = 8;
            this.checkBoxpetisco.Text = "Pestisco R$ 7,90";
            this.checkBoxpetisco.UseVisualStyleBackColor = true;
            this.checkBoxpetisco.CheckedChanged += new System.EventHandler(this.checkBoxpetisco_CheckedChanged);
            // 
            // checkBoxrefeicao
            // 
            this.checkBoxrefeicao.AutoSize = true;
            this.checkBoxrefeicao.Location = new System.Drawing.Point(13, 232);
            this.checkBoxrefeicao.Name = "checkBoxrefeicao";
            this.checkBoxrefeicao.Size = new System.Drawing.Size(99, 17);
            this.checkBoxrefeicao.TabIndex = 9;
            this.checkBoxrefeicao.Text = "Refeição 15,90";
            this.checkBoxrefeicao.UseVisualStyleBackColor = true;
            this.checkBoxrefeicao.CheckedChanged += new System.EventHandler(this.checkBoxrefeicao_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nº Mesa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "UND.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Parcial";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(86, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "&Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(352, 294);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(100, 48);
            this.btnfechar.TabIndex = 15;
            this.btnfechar.Text = "&Fechar Conta";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Taxa de Serviço(10%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total a Pagar";
            // 
            // maskshop
            // 
            this.maskshop.Enabled = false;
            this.maskshop.Location = new System.Drawing.Point(137, 124);
            this.maskshop.Mask = "00";
            this.maskshop.Name = "maskshop";
            this.maskshop.Size = new System.Drawing.Size(21, 20);
            this.maskshop.TabIndex = 18;
            // 
            // maskpetisco
            // 
            this.maskpetisco.Enabled = false;
            this.maskpetisco.Location = new System.Drawing.Point(137, 176);
            this.maskpetisco.Mask = "00";
            this.maskpetisco.Name = "maskpetisco";
            this.maskpetisco.Size = new System.Drawing.Size(21, 20);
            this.maskpetisco.TabIndex = 19;
            // 
            // maskrefeicao
            // 
            this.maskrefeicao.Enabled = false;
            this.maskrefeicao.Location = new System.Drawing.Point(139, 232);
            this.maskrefeicao.Mask = "00";
            this.maskrefeicao.Name = "maskrefeicao";
            this.maskrefeicao.Size = new System.Drawing.Size(19, 20);
            this.maskrefeicao.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(353, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 26;
            // 
            // textBoxtotalpagar
            // 
            this.textBoxtotalpagar.Location = new System.Drawing.Point(356, 246);
            this.textBoxtotalpagar.Name = "textBoxtotalpagar";
            this.textBoxtotalpagar.ReadOnly = true;
            this.textBoxtotalpagar.Size = new System.Drawing.Size(100, 20);
            this.textBoxtotalpagar.TabIndex = 27;
            this.textBoxtotalpagar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(101, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 29);
            this.textBox3.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 363);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxtotalpagar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskrefeicao);
            this.Controls.Add(this.maskpetisco);
            this.Controls.Add(this.maskshop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxrefeicao);
            this.Controls.Add(this.checkBoxpetisco);
            this.Controls.Add(this.checkBoxchop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurante";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxchop;
        private System.Windows.Forms.CheckBox checkBoxpetisco;
        private System.Windows.Forms.CheckBox checkBoxrefeicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskshop;
        private System.Windows.Forms.MaskedTextBox maskpetisco;
        private System.Windows.Forms.MaskedTextBox maskrefeicao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxtotalpagar;
        private System.Windows.Forms.TextBox textBox3;
    }
}


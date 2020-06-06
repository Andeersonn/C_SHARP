namespace Restaurante
{
    partial class fechamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdcedito = new System.Windows.Forms.RadioButton();
            this.rddebito = new System.Windows.Forms.RadioButton();
            this.rddinheiro = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxtroco = new System.Windows.Forms.TextBox();
            this.textBoxrecebido = new System.Windows.Forms.TextBox();
            this.textBoxvlrpago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnencerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdcedito);
            this.groupBox1.Controls.Add(this.rddebito);
            this.groupBox1.Controls.Add(this.rddinheiro);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas de Pagamentos";
            // 
            // rdcedito
            // 
            this.rdcedito.AutoSize = true;
            this.rdcedito.Location = new System.Drawing.Point(227, 30);
            this.rdcedito.Name = "rdcedito";
            this.rdcedito.Size = new System.Drawing.Size(92, 17);
            this.rdcedito.TabIndex = 2;
            this.rdcedito.TabStop = true;
            this.rdcedito.Text = "Cartão Credito";
            this.rdcedito.UseVisualStyleBackColor = true;
            this.rdcedito.CheckedChanged += new System.EventHandler(this.rdcedito_CheckedChanged);
            // 
            // rddebito
            // 
            this.rddebito.AutoSize = true;
            this.rddebito.Location = new System.Drawing.Point(124, 30);
            this.rddebito.Name = "rddebito";
            this.rddebito.Size = new System.Drawing.Size(96, 17);
            this.rddebito.TabIndex = 1;
            this.rddebito.TabStop = true;
            this.rddebito.Text = "Caratão Debito";
            this.rddebito.UseVisualStyleBackColor = true;
            this.rddebito.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rddinheiro
            // 
            this.rddinheiro.AutoSize = true;
            this.rddinheiro.Location = new System.Drawing.Point(23, 30);
            this.rddinheiro.Name = "rddinheiro";
            this.rddinheiro.Size = new System.Drawing.Size(64, 17);
            this.rddinheiro.TabIndex = 0;
            this.rddinheiro.TabStop = true;
            this.rddinheiro.Text = "Dinheiro";
            this.rddinheiro.UseVisualStyleBackColor = true;
            this.rddinheiro.CheckedChanged += new System.EventHandler(this.rddinheiro_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cartão de Crédito";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(227, 37);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(109, 17);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "American Express";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(124, 37);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(78, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Mastercard";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 37);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Visa";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxtroco);
            this.groupBox3.Controls.Add(this.textBoxrecebido);
            this.groupBox3.Controls.Add(this.textBoxvlrpago);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(376, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 265);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados de Pagamento";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBoxtroco
            // 
            this.textBoxtroco.Location = new System.Drawing.Point(104, 198);
            this.textBoxtroco.Name = "textBoxtroco";
            this.textBoxtroco.ReadOnly = true;
            this.textBoxtroco.Size = new System.Drawing.Size(100, 20);
            this.textBoxtroco.TabIndex = 11;
            this.textBoxtroco.TextChanged += new System.EventHandler(this.texttroco_TextChanged);
            // 
            // textBoxrecebido
            // 
            this.textBoxrecebido.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxrecebido.Location = new System.Drawing.Point(110, 122);
            this.textBoxrecebido.Name = "textBoxrecebido";
            this.textBoxrecebido.ReadOnly = true;
            this.textBoxrecebido.Size = new System.Drawing.Size(100, 20);
            this.textBoxrecebido.TabIndex = 10;
            this.textBoxrecebido.TextChanged += new System.EventHandler(this.textvalor_TextChanged);
            // 
            // textBoxvlrpago
            // 
            this.textBoxvlrpago.Location = new System.Drawing.Point(104, 45);
            this.textBoxvlrpago.Name = "textBoxvlrpago";
            this.textBoxvlrpago.ReadOnly = true;
            this.textBoxvlrpago.Size = new System.Drawing.Size(100, 20);
            this.textBoxvlrpago.TabIndex = 9;
            this.textBoxvlrpago.TextChanged += new System.EventHandler(this.textBoxvlrpago_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Troco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Recebido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor a ser Pago:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnencerrar
            // 
            this.btnencerrar.Location = new System.Drawing.Point(376, 312);
            this.btnencerrar.Name = "btnencerrar";
            this.btnencerrar.Size = new System.Drawing.Size(210, 39);
            this.btnencerrar.TabIndex = 3;
            this.btnencerrar.Text = "&Encerrar";
            this.btnencerrar.UseVisualStyleBackColor = true;
            this.btnencerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 363);
            this.Controls.Add(this.btnencerrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "fechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fechamento";
            this.Load += new System.EventHandler(this.fechamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnencerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdcedito;
        private System.Windows.Forms.RadioButton rddebito;
        private System.Windows.Forms.RadioButton rddinheiro;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBoxvlrpago;
        private System.Windows.Forms.TextBox textBoxtroco;
        private System.Windows.Forms.TextBox textBoxrecebido;
    }
}
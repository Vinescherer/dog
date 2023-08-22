namespace DOGÃO
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRaio = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxBaseMaior = new System.Windows.Forms.TextBox();
            this.textBoxLado = new System.Windows.Forms.TextBox();
            this.textBoxApótema = new System.Windows.Forms.TextBox();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.textBoxBaseMenor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Escolha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRaio
            // 
            this.textBoxRaio.Location = new System.Drawing.Point(89, 175);
            this.textBoxRaio.Name = "textBoxRaio";
            this.textBoxRaio.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaio.TabIndex = 2;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(89, 126);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltura.TabIndex = 3;
            // 
            // textBoxBaseMaior
            // 
            this.textBoxBaseMaior.Location = new System.Drawing.Point(89, 201);
            this.textBoxBaseMaior.Name = "textBoxBaseMaior";
            this.textBoxBaseMaior.Size = new System.Drawing.Size(100, 20);
            this.textBoxBaseMaior.TabIndex = 4;
            // 
            // textBoxLado
            // 
            this.textBoxLado.Location = new System.Drawing.Point(89, 253);
            this.textBoxLado.Name = "textBoxLado";
            this.textBoxLado.Size = new System.Drawing.Size(100, 20);
            this.textBoxLado.TabIndex = 5;
            // 
            // textBoxApótema
            // 
            this.textBoxApótema.Location = new System.Drawing.Point(89, 279);
            this.textBoxApótema.Name = "textBoxApótema";
            this.textBoxApótema.Size = new System.Drawing.Size(100, 20);
            this.textBoxApótema.TabIndex = 6;
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(89, 152);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(100, 20);
            this.textBoxBase.TabIndex = 7;
            // 
            // textBoxBaseMenor
            // 
            this.textBoxBaseMenor.Location = new System.Drawing.Point(89, 227);
            this.textBoxBaseMenor.Name = "textBoxBaseMenor";
            this.textBoxBaseMenor.Size = new System.Drawing.Size(100, 20);
            this.textBoxBaseMenor.TabIndex = 8;
            this.textBoxBaseMenor.TextChanged += new System.EventHandler(this.textBoxBaseMenor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Raio";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Retângulo",
            "Círculo ",
            "Trapézio ",
            "Pentágono"});
            this.comboBox1.Location = new System.Drawing.Point(68, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Opção ";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Base maior";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "base menor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Apótema";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lado";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Resposta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBaseMenor);
            this.Controls.Add(this.textBoxBase);
            this.Controls.Add(this.textBoxApótema);
            this.Controls.Add(this.textBoxLado);
            this.Controls.Add(this.textBoxBaseMaior);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxRaio);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRaio;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxBaseMaior;
        private System.Windows.Forms.TextBox textBoxLado;
        private System.Windows.Forms.TextBox textBoxApótema;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.TextBox textBoxBaseMenor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}


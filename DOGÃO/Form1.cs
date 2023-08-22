using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOGÃO
{
    public partial class Form1 : Form
    {
        double altura, bas, raio, baseMaior, baseMenor, lado, apótema, resu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBaseMenor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBoxAltura.Enabled = true;
                textBoxBase.Enabled = true;

                textBoxRaio.Enabled = false;
                textBoxBaseMaior.Enabled = false;
                textBoxBaseMenor.Enabled = false;
                textBoxLado.Enabled = false;
                textBoxApótema.Enabled = false;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBoxRaio.Enabled = true;

                textBoxBase.Enabled = false;
                textBoxBase.Clear();
                textBoxAltura.Enabled = false;
                textBoxAltura.Clear();
                textBoxBaseMenor.Enabled = false;
                textBoxBaseMaior.Enabled = false;
                textBoxLado.Enabled = false;
                textBoxApótema.Enabled = false;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                textBoxAltura.Enabled = true;
                textBoxBaseMaior.Enabled = true;
                textBoxBaseMenor.Enabled = true;

                textBoxLado.Enabled = false;
                textBoxApótema.Enabled = false;
                textBoxBase.Enabled = false;
                textBoxRaio.Enabled = false;
                textBoxRaio.Clear();
            }

            if (comboBox1.SelectedIndex == 3)
                {
                textBoxAltura.Enabled = true;
                textBoxBase.Enabled = true;

                textBoxApótema.Enabled = false;
                textBoxBaseMaior.Enabled = false;
                textBoxBaseMaior.Clear();
                textBoxBaseMenor.Enabled = false;
                textBoxBaseMenor.Clear();
               textBoxLado.Enabled = false;
                textBoxRaio.Enabled = false;
                textBoxAltura.Clear();



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            

            if (comboBox1.SelectedIndex == 0)
            {
                bas = double.Parse(textBoxBase.Text);
                altura = double.Parse(textBoxAltura.Text);

                resu = bas * altura;

                MessageBox.Show(" A área do retângulo  é de " +resu);

            }
            if (comboBox1.SelectedIndex == 1)
            {
                raio = double.Parse(textBoxRaio.Text);

                resu = raio * raio * 3.14;

                MessageBox.Show(" A área do círculo  é de " + resu);

            }
            if (comboBox1.SelectedIndex == 2)
            {
                baseMaior = double.Parse(textBoxBaseMaior.Text);
                baseMenor = double.Parse(textBoxBaseMenor.Text);
                altura = double.Parse(textBoxAltura.Text);

                resu = baseMaior * baseMenor * altura /2;
                MessageBox.Show(" A área do trápezio  é de " + resu);

            }
            if (comboBox1.SelectedIndex == 3)
            {
                bas = double.Parse(textBoxBase.Text);
                altura = double.Parse(textBoxAltura.Text);

                resu = (1 / 2 * bas * altura) * 5;
                MessageBox.Show(" A área do pentágono  é de " + resu);


            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
#region botoes click
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.CORACAO;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackgroundImage = Properties.Resources.CORACAO;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.ELIPSE;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.ELIPSE;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.HEPTAGONO;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackgroundImage = Properties.Resources.HEPTAGONO;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.OCTAGONO;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackgroundImage = Properties.Resources.OCTAGONO;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackgroundImage = Properties.Resources.PARALELOGRAMO;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackgroundImage = Properties.Resources.PARALELOGRAMO;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.POLIGONO;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackgroundImage = Properties.Resources.POLIGONO;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.SETA;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackgroundImage = Properties.Resources.SETA;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackgroundImage = Properties.Resources.MAIS;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackgroundImage = Properties.Resources.MAIS;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackgroundImage = Properties.Resources.circulo;            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackgroundImage = Properties.Resources.circulo;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackgroundImage = Properties.Resources.Estrela;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackgroundImage = Properties.Resources.Estrela;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.BackgroundImage = Properties.Resources.Hexagono;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackgroundImage = Properties.Resources.Hexagono;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.BackgroundImage = Properties.Resources.Losango;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.BackgroundImage = Properties.Resources.Losango;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.BackgroundImage = Properties.Resources.Quadrado;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.BackgroundImage = Properties.Resources.Quadrado;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.BackgroundImage = Properties.Resources.Retângulo;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.BackgroundImage = Properties.Resources.Retângulo;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackgroundImage = Properties.Resources.Trapezio;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackgroundImage = Properties.Resources.Trapezio;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackgroundImage = Properties.Resources.Triângulo;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackgroundImage = Properties.Resources.Triângulo;
        }
#endregion

        private void button29_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair do programa?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
          
        }
    }
}

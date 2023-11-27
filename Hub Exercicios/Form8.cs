using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hub_Exercicios
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        { }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            int n1 = Convert.ToInt32(Interaction.InputBox("Insira 1º valor", "Input Box"));
            int n2 = Convert.ToInt32(Interaction.InputBox("Insira 2º valor", "Input Box"));

            int resultado = 0;
            if (textBox2.Text == "+")
                resultado = n1 + n2;
            else if (textBox2.Text == "-")
                resultado = n1 - n2;
            else if (textBox2.Text == "*")
                resultado = n1 * n2;
            else if (textBox2.Text == "/")
                resultado = n1 / n2;

            textBox1.Text = "Resultado: " + resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm_1 = new Form1();
            frm_1.Show();
            this.Close();
        }
    }
}

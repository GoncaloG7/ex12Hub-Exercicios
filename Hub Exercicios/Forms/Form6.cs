using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hub_Exercicios.Class;

namespace Hub_Exercicios
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        { }

        private void alterar_Click(object sender, EventArgs e)
        {
            string nome1 = textBox1.Text;
            string nome2 = textBox2.Text;
            textBox1.Text = nome2;
            textBox2.Text = nome1;
        }

        private void juntar_Click(object sender, EventArgs e)
        {
            string nome1 = textBox1.Text;
            string nome2 = textBox2.Text;
            textBox3.Text = nome1 + " " + nome2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    ClassClose.Backbtn(this);
                    break;
                case 1:
                    ClassClose.CloseAllForms();
                    break;
            }
        }
    }
}

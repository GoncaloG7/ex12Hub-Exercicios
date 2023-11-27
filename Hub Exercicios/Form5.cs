using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hub_Exercicios
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "Passou-me com o mouse por cima";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm_1 = new Form1();
            frm_1.Show();
            this.Close();
        }
    }
}

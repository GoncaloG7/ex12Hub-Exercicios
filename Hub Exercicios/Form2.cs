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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox1.Text = "Bem vindo ao C#!";
            else
                textBox1.Text = "Não Aceitou";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Form1 frm_1 = new Form1();
                    frm_1.Show();
                    this.Close();
                    break;
                case 1:
                    var fecharform = Application.OpenForms.Cast<Form>().ToList();
                    foreach (Form frm in fecharform)
                    {
                        frm.Close();
                    }
                    break;
            }
        }
    }
}

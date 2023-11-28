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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double comp = Convert.ToDouble(textBox1.Text);
            double larg = Convert.ToDouble(textBox2.Text);
            double alt = Convert.ToDouble(textBox3.Text);
            listBox1.Items.Insert(0, "       ___________   ");
            listBox1.Items.Insert(1, "    /__________ / |");
            listBox1.Items.Insert(2, alt + " |                 |   / ");
            listBox1.Items.Insert(3, "   |__________| /" + larg);
            listBox1.Items.Insert(4, "          " + comp);
            double area = comp * larg;
            listBox1.Items.Insert(5, "Área: " + area);
            double peri = (comp + larg) * 2;
            listBox1.Items.Insert(6, "Perímetro: " + peri);
            double vol = (alt * larg) * comp;
            listBox1.Items.Insert(7, "Volume: " + vol);
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
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

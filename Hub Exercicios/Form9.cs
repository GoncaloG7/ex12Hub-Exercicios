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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            textBox1.Text = " ";
            int n1 = Convert.ToInt32(Interaction.InputBox("Insira 1º valor", "Input Box"));
            int n2 = Convert.ToInt32(Interaction.InputBox("Insira 2º valor", "Input Box"));
            int resultado = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    resultado = n1 + n2;
                    break;
                case 1:
                    resultado = n1 - n2;
                    break;
                case 2:
                    resultado = n1 * n2;
                    break;
                case 3:
                    resultado = n1 / n2;
                    break;
            }
            textBox1.Text = "Resultado: " + resultado;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

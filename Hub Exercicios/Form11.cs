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

namespace Hub_Exercicios
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = (Interaction.InputBox("", "InputBox", "enter password"));
            if (password == "coisas012")
            {
                MessageBox.Show("Bem vindo");
            }
            else
            {
                MessageBox.Show("Password incorreta");
            }
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

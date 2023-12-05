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
using Microsoft.VisualBasic;

namespace Hub_Exercicios
{
    public partial class zForm11 : Form
    {
        public zForm11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = (Interaction.InputBox("", "InputBox", "enter password"));
            if (password == "coisas7")
                MessageBox.Show("Bem vindo");
            else
                MessageBox.Show("Password incorreta");
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

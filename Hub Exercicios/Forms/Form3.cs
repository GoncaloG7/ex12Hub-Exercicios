﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                textBox1.Text = "Bem Vindo ao C#";
            else if (radioButton2.Checked)
                textBox1.Text = "Tem que aceitar";
            else
                textBox1.Text = "Tem que escolher uma das opções";
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

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hub_Exercicios.Class;

namespace Hub_Exercicios
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Isto é uma caixa de texto";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = (Color.Red);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BackColor = default(Color);
            textBox1.ForeColor = default(Color);
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

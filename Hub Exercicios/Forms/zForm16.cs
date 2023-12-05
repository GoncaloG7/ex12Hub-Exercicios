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
using static Hub_Exercicios.Class.ClassClose;

namespace Hub_Exercicios
{
    public partial class zForm16 : Form
    {
        public zForm16()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void Form16_Load(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(textBox1.Text);
            ClassV_G.resultado = ClassV_G.resultado + valor;
            textBox1.Text = Convert.ToString(ClassV_G.resultado);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zForm16b frm_16b = new zForm16b();
            frm_16b.Show();
            this.Hide();
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

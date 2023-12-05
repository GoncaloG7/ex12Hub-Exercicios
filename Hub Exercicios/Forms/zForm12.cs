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
    public partial class zForm12 : Form
    {
        public zForm12()
        {
            InitializeComponent();
        }

        private void formatarToolStripMenuItem_Click(object sender, EventArgs e)
        { }

        private void corETipoDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cor = new ColorDialog();
            if (cor.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = cor.Color;
            }
            FontDialog letra = new FontDialog();
            if (letra.ShowDialog() == DialogResult.OK)
            {
                label1.Font = letra.Font;
            }
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

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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

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
    }
}

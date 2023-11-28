using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
namespace Hub_Exercicios
{
    public partial class Form13 : Form
    {
        private string enter;
        public string nome;
        public string nome2;
        public string Idade;

        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        { }

        private void guardar1_Click(object sender, EventArgs e)
        {
            nome = textBox1.Text;
            nome2 = textBox2.Text;
            Idade = textBox3.Text;
            MessageBox.Show("Guardado com sucesso" + "\nNome: " + nome + "\nSobrenome: " + nome2 + "\nIdade: " + Idade);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void limpar2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void repor3_Click(object sender, EventArgs e)
        {
            textBox1.Text = nome;
            textBox2.Text = nome2;
            textBox3.Text = Idade;
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
                    var fecharform = System.Windows.Forms.Application.OpenForms.Cast<Form>().ToList();
                    foreach (Form frm in fecharform)
                    {
                        frm.Close();
                    }
                    break;
            }
        }
    }
}

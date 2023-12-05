using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Hub_Exercicios.Class;

namespace Hub_Exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: //1
                    Form2 frm_2 = new Form2();
                    frm_2.Show();
                    this.Hide();
                    break;
                case 1: //2
                    Form3 frm_3 = new Form3();
                    frm_3.Show();
                    this.Hide();
                    break;
                case 2: //3
                    Form4 frm_4 = new Form4();
                    frm_4.Show();
                    this.Hide();
                    break;
                case 3: //4
                    Form5 frm_5 = new Form5();
                    frm_5.Show();
                    this.Hide();
                    break;
                case 4: //5
                    Form6 frm_6 = new Form6();
                    frm_6.Show();
                    this.Hide();
                    break;
                case 5: //5.1
                    zForm13 frm_13 = new zForm13();
                    frm_13.Show();
                    this.Hide();
                    break;
                case 6: //6
                    Form7 frm_7 = new Form7();
                    frm_7.Show();
                    this.Hide();
                    break;
                case 7: //7
                    Form8 frm_8 = new Form8();
                    frm_8.Show();
                    this.Hide();
                    break;
                case 8: //8
                    Form9 frm_9 = new Form9();
                    frm_9.Show();
                    this.Hide();
                    break;
                case 9: //9
                    zForm10 frm_10 = new zForm10();
                    frm_10.Show();
                    this.Hide();
                    break;
                case 10: //10
                    zForm11 frm_11 = new zForm11();
                    frm_11.Show();
                    this.Hide();
                    break;
                case 11: //11
                    zForm12 frm_12 = new zForm12();
                    frm_12.Show();
                    this.Hide();
                    break;
                case 12: //12
                    zForm14 frm_14 = new zForm14();
                    frm_14.Show();
                    this.Hide();
                    break;
                case 13: //13
                    zForm15 frm_15 = new zForm15();
                    frm_15.Show();
                    this.Hide();
                    break;
                case 14: //14
                    zForm16 frm_16 = new zForm16();
                    frm_16.Show();
                    this.Hide();
                    break;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            ClassClose.CloseAllForms();
        }
    }
}
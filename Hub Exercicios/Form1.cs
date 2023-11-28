using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
                case 0:
                    Form2 frm_2 = new Form2();
                    frm_2.Show();
                    this.Hide();
                    break;
                case 1:
                    Form3 frm_3 = new Form3();
                    frm_3.Show();
                    this.Hide();
                    break;
                case 2:
                    Form4 frm_4 = new Form4();
                    frm_4.Show();
                    this.Hide();
                    break;
                case 3:
                    Form5 frm_5 = new Form5();
                    frm_5.Show();
                    this.Hide();
                    break;
                case 4:
                    Form6 frm_6 = new Form6();
                    frm_6.Show();
                    this.Hide();
                    break;
                case 5:
                    Form13 frm_13 = new Form13();
                    frm_13.Show();
                    this.Hide();
                    break;
                case 6:
                    Form7 frm_7 = new Form7();
                    frm_7.Show();
                    this.Hide();
                    break;
                case 7:
                    Form8 frm_8 = new Form8();
                    frm_8.Show();
                    this.Hide();
                    break;
                case 8:
                    Form9 frm_9 = new Form9();
                    frm_9.Show();
                    this.Hide();
                    break;
                case 9:
                    Form10 frm_10 = new Form10();
                    frm_10.Show();
                    this.Hide();
                    break;
                case 10:
                    Form11 frm_11 = new Form11();
                    frm_11.Show();
                    this.Hide();
                    break;
                case 11:
                    Form12 frm_12 = new Form12();
                    frm_12.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Escolha uma opção");
                    break;
            }
        }

        /*Form1 frm_1 = new Form1();
          frm_1.Show();
          this.Close();*/

        public void button2_Click(object sender, EventArgs e)
        {
            /*Application.OpenForms: Isso pega todos os formulários que estão 
                                     atualmente abertos na aplicação.
              Cast<Form>(): Isso converte os itens na lista para o tipo Form 
                            (pois OpenForms retorna uma coleção de Form).
              ToList(): converte a coleção resultante em uma lista.
              foreach: é usado para executar o código dentro dele para cada 
                       formulário na lista de formulários abertos 
              frm.Close(): Isso fecha cada formulário na lista.*/

            var fecharform = Application.OpenForms.Cast<Form>().ToList();
            foreach (Form frm in fecharform)
            {
                frm.Close();
            }
        }
    }
}
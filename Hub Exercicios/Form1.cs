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

        private void button1_Click(object sender, EventArgs e)
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
                
                /*Form1 frm_1 = new Form1();
                frm_1.Show();
                this.Close();*/
            }
        }        
    }
}
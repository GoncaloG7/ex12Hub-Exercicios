namespace Hub_Exercicios
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            textBox3 = new TextBox();
            limpar = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 127);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 29;
            label4.Text = "Altura";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 23);
            textBox3.TabIndex = 28;
            // 
            // limpar
            // 
            limpar.Location = new Point(55, 242);
            limpar.Name = "limpar";
            limpar.Size = new Size(92, 23);
            limpar.TabIndex = 27;
            limpar.Text = "limpar tudo";
            limpar.UseVisualStyleBackColor = true;
            limpar.Click += limpar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(159, 165);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 124);
            listBox1.TabIndex = 26;
            // 
            // button1
            // 
            button1.Location = new Point(55, 180);
            button1.Name = "button1";
            button1.Size = new Size(92, 56);
            button1.TabIndex = 25;
            button1.Text = "cálculo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 98);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 22;
            label3.Text = "Largura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 69);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 21;
            label2.Text = "Comprimento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 37);
            label1.Name = "label1";
            label1.Size = new Size(230, 15);
            label1.TabIndex = 20;
            label1.Text = "área, perimetro e volume de um retângulo";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ButtonHighlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Back", "Close" });
            comboBox1.Location = new Point(378, 305);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(41, 23);
            comboBox1.TabIndex = 30;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 330);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(limpar);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Ex6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox3;
        private Button limpar;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
    }
}
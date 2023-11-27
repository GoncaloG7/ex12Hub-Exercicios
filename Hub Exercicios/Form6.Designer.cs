namespace Hub_Exercicios
{
    partial class Form6
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
            label2 = new Label();
            label1 = new Label();
            juntar = new Button();
            alterar = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 38);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 13;
            label2.Text = "insira o segundo nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 38);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 12;
            label1.Text = "insira o primeiro nome";
            // 
            // juntar
            // 
            juntar.Location = new Point(153, 177);
            juntar.Name = "juntar";
            juntar.Size = new Size(108, 55);
            juntar.TabIndex = 11;
            juntar.Text = "juntar";
            juntar.UseVisualStyleBackColor = true;
            juntar.Click += juntar_Click;
            // 
            // alterar
            // 
            alterar.Location = new Point(153, 94);
            alterar.Name = "alterar";
            alterar.Size = new Size(108, 55);
            alterar.TabIndex = 10;
            alterar.Text = "alterar";
            alterar.UseVisualStyleBackColor = true;
            alterar.Click += alterar_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(363, 282);
            button1.Name = "button1";
            button1.Size = new Size(48, 23);
            button1.TabIndex = 14;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 308);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(juntar);
            Controls.Add(alterar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form6";
            Text = "Ex5";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button juntar;
        private Button alterar;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}
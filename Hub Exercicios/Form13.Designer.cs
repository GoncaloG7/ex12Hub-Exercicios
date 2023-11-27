namespace Hub_Exercicios
{
    partial class Form13
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            repor3 = new Button();
            limpar2 = new Button();
            guardar1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 133);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 17;
            label3.Text = "Idade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 79);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 16;
            label2.Text = "Sobrenome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 29);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 15;
            label1.Text = "Nome";
            // 
            // repor3
            // 
            repor3.Location = new Point(263, 151);
            repor3.Name = "repor3";
            repor3.Size = new Size(75, 23);
            repor3.TabIndex = 14;
            repor3.Text = "repor";
            repor3.UseVisualStyleBackColor = true;
            repor3.Click += repor3_Click;
            // 
            // limpar2
            // 
            limpar2.Location = new Point(263, 97);
            limpar2.Name = "limpar2";
            limpar2.Size = new Size(75, 23);
            limpar2.TabIndex = 13;
            limpar2.Text = "limpar";
            limpar2.UseVisualStyleBackColor = true;
            limpar2.Click += limpar2_Click;
            // 
            // guardar1
            // 
            guardar1.Location = new Point(263, 47);
            guardar1.Name = "guardar1";
            guardar1.Size = new Size(75, 23);
            guardar1.TabIndex = 12;
            guardar1.Text = "guardar";
            guardar1.UseVisualStyleBackColor = true;
            guardar1.Click += guardar1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(43, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(338, 191);
            button1.Name = "button1";
            button1.Size = new Size(42, 25);
            button1.TabIndex = 18;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 217);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(repor3);
            Controls.Add(limpar2);
            Controls.Add(guardar1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form13";
            Text = "Ex5.1";
            Load += Form13_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button repor3;
        private Button limpar2;
        private Button guardar1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}
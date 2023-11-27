namespace Hub_Exercicios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ex1", "Ex2", "Ex3", "Ex4", "Ex5", "Ex5.1", "Ex6", "Ex7", "Ex8", "Ex9", "Ex10", "Ex11" });
            comboBox1.Location = new Point(41, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 23);
            comboBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(216, 53);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 0;
            button1.Text = "Abrir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 12;
            label1.Text = "Ex das aulas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(352, 138);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Hub";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
    }
}
namespace Lab9MVP
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 82);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 41);
            label1.TabIndex = 0;
            label1.Text = "Сторона 1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 76);
            textBox1.Margin = new Padding(6, 6, 6, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 47);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 160);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 41);
            label2.TabIndex = 2;
            label2.Text = "Сторона 2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(257, 154);
            textBox2.Margin = new Padding(6, 6, 6, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 47);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 234);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 41);
            label3.TabIndex = 4;
            label3.Text = "Висота";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(257, 228);
            textBox3.Margin = new Padding(6, 6, 6, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(272, 47);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 299);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 41);
            label4.TabIndex = 6;
            label4.Text = "Висота2";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(257, 293);
            textBox4.Margin = new Padding(6, 6, 6, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(272, 47);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(695, 248);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(402, 92);
            button1.TabIndex = 8;
            button1.Text = "Розрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 465);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 41);
            label5.TabIndex = 9;
            label5.Text = "Площа = ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 545);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 41);
            label6.TabIndex = 10;
            label6.Text = "Об'єм =";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 371);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(127, 41);
            label7.TabIndex = 11;
            label7.Text = "Висота3";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(257, 365);
            textBox5.Margin = new Padding(6);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(272, 47);
            textBox5.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1700, 922);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
    }
}

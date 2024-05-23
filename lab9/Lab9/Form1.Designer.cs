namespace Lab9
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 88);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 41);
            label1.TabIndex = 0;
            label1.Text = "Сторона 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 178);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 41);
            label2.TabIndex = 1;
            label2.Text = "Сторона 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 271);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 41);
            label3.TabIndex = 2;
            label3.Text = "Висота";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 365);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 41);
            label4.TabIndex = 3;
            label4.Text = "Висота2";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 82);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 47);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 172);
            textBox2.Margin = new Padding(6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 47);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(293, 264);
            textBox3.Margin = new Padding(6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 47);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(293, 359);
            textBox4.Margin = new Padding(6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(261, 47);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(667, 340);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(255, 90);
            button1.TabIndex = 9;
            button1.Text = "Обрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 556);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(156, 41);
            label5.TabIndex = 10;
            label5.Text = "Результат:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 447);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 41);
            label6.TabIndex = 11;
            label6.Text = "Висота3";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(293, 444);
            textBox5.Margin = new Padding(6);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(261, 47);
            textBox5.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1700, 922);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
    }
}

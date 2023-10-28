namespace Lesson_27_10
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Script MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(112, 233);
            button1.Name = "button1";
            button1.Size = new Size(130, 44);
            button1.TabIndex = 0;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите первое число";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 53);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 4;
            label2.Text = "Введите второе число";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 140);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 5;
            label3.Text = "Выберите операцию";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(112, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 308);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "Результат";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(233, 308);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(369, 350);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(385, 389);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}
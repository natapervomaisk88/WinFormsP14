namespace Lesson_27_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label5.Text = string.Empty;
            if (textBox1.Text != string.Empty
                && textBox2.Text != string.Empty
                && comboBox1.Text != string.Empty)
            {
                int n1 = Convert.ToInt32(textBox1.Text);
                int n2 = Convert.ToInt32(textBox2.Text);
                char operat = Convert.ToChar(comboBox1.Text);
                int result = 0;
                switch (operat)
                {
                    case '+':
                        result = n1 + n2;
                        break;
                    case '-':
                        result = n1 - n2;
                        break;
                    case '*':
                        result = n1 * n2;
                        break;
                    case '/':
                        result = n2 != 0 ? n1 / n2 : 0;
                        break;
                }
                label5.Text = result.ToString();
            }
            else
            {
                DialogResult answer = MessageBox.Show("Ошибка, что-то не заполнено!", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer.ToString() == "Yes")
                {
                    MessageBox.Show("Вы выбрали ОК");
                }
                else
                {
                    MessageBox.Show("Вы выбрали НЕ ОК");

                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color[] colors = new Color[5] { Color.IndianRed, Color.Blue, Color.Yellow, Color.Green, Color.Khaki };
            Random r = new Random();
            this.BackColor = colors[r.Next(0,4)];

        }
    }
}
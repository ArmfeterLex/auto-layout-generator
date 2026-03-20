using System;
using System.Drawing;
using System.Windows.Forms;

namespace proj13
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private int startX = 20;
        private int startY = 60;
        private int currentX;
        private int currentY;

        public Form1()
        {
            InitializeComponent();
            currentX = startX;
            currentY = startY;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control c;

            if (rnd.Next(2) == 0)
            {
                c = new Button();
                c.Text = "Кнопка";
                c.Size = new Size(100, 30);
            }
            else
            {
                c = new TextBox();
                c.Size = new Size(150, 30);
                (c as TextBox).Multiline = true; 
            }

            if (currentX + c.Width > this.ClientSize.Width - 20)
            {
                currentX = startX;
                currentY += 50;
            }

            c.Location = new Point(currentX, currentY);
            this.Controls.Add(c);
            currentX += c.Width + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.Height = tb.Height * 2;
                }
            }
        }
    }
}

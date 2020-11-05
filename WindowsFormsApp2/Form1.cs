using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int a = 40;
        int b = 40;
        double x, y;     
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            if (x / 2 == Convert.ToInt32(x) / 2)
            {
                MessageBox.Show("Введите нечетное число!");
            }
            else
            {
                create();
            }
        }

        public void create()
        {
            this.Width = 400;
            this.Height = 400;
            button1.Visible = false;
            textBox1.Visible = false;
            textBox1.ReadOnly = true;
            label1.Visible = false;
            int num = 0;
            y = Math.Pow(x, 2);
            y /= 2;
            for (int i = 1; i <= x; i++)
            {
                a = 40;
                for (int z = 1; z <= x; z++)
                {
                    TextBox tb = new TextBox();
                    tb.Name = "button" + num;
                    tb.Text = "";
                    tb.Multiline = true;
                    tb.Width = 40;
                    tb.Height = 40;
                    tb.Left = a;
                    tb.Top = b;
                    tb.ReadOnly = true;
                    this.Controls.Add(tb);
                    a += 40;
                    num++;
                    if (num == Convert.ToInt32(y) + 1)
                        tb.BackColor = Color.Red;
                }
                b += 40;
            }
        }
    }
}

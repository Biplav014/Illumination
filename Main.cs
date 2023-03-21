using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Illumination
{
    public partial class Main : Form
    {
        public void SetNumber(int number)
        {
            textBox6.Text = number.ToString();
        }
        public Main()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double area = Convert.ToDouble(textBox1.Text);
            double lumen = Convert.ToDouble(textBox2.Text);
            double uf = Convert.ToDouble(textBox3.Text);
            double mf = Convert.ToDouble(textBox4.Text);
            double illu = Convert.ToDouble(textBox6.Text);
            double nfix = (area * illu) / (lumen * mf * uf);
            int nfix2 = (int)Math.Round(nfix);
            textBox5.Text = nfix2.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 s1 = new Form1();
            s1.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.Text = "0.8";
            }
            else
            {
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox4.Text = "0.8";
            }
            else
            {
            }
        }
    }
}

using System.Windows.Forms.VisualStyles;

namespace Illumination
{
    public partial class Form1 : Form
    {
        public int myNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myNumber = 250;
            Main s2 = new Main();
            s2.SetNumber(myNumber);
            s2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myNumber = 100;
            Main s2 = new Main();
            s2.SetNumber(myNumber);
            s2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myNumber = 100;
            Main s2 = new Main();
            s2.SetNumber(myNumber);
            s2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myNumber = 200;
            Main s2 = new Main();
            s2.SetNumber(myNumber);
            s2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myNumber = 70;
            Main s2 = new Main();
            s2.SetNumber(myNumber);
            s2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myNumber = 700;
            Main s2 = new Main();
            s2.SetNumber(myNumber);
            s2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myNumber = 150;
            Main s2 = new Main();
            s2.SetNumber(myNumber);
            s2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myNumber = 3000;
            Main s2 = new Main();
            s2.SetNumber(myNumber);
            s2.Show();
            this.Hide();
        }
    }
}
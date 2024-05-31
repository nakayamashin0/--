namespace fukuv0531
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vy = -15;
            MessageBox.Show($"{vy}");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vy = 15;
            MessageBox.Show($"{vy}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 10;
        }
    }
}
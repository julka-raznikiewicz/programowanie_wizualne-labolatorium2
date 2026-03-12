namespace labolatorium2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var guzik_wybierz = new wybierz();
            guzik_wybierz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var guzik_transport = new transport();
            guzik_transport.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var guzik_zaplac = new zaplac();
            guzik_zaplac.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

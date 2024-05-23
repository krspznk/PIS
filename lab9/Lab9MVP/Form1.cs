using Lab9.Domain;

namespace Lab9MVP
{
    public partial class Form1 : Form, IPiramidaView
    {
        private PiramidaPresenter _presenter;

        public Form1()
        {
            InitializeComponent();

            _presenter = new PiramidaPresenter(this, new PiramidaModel());
        }

        public void SetSurfaceArea(double number)
        {
            label5.Text = $"Площа = {number}";
        }

        public void SetVolume(double number)
        {
            label6.Text = $"Об'єм = {number}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presenter.LoadPrism(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));
        }
    }
}

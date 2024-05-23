namespace Lab9
{
    public partial class Form1 : Form
    {
        private readonly PiramidaController _piramidaController;

        public Form1()
        {
            InitializeComponent();
            _piramidaController = new PiramidaController();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sideA = double.Parse(textBox1.Text);
                var sideB = double.Parse(textBox2.Text);
                var height = double.Parse(textBox3.Text);
                var height2 = double.Parse(textBox4.Text);
                var height3 = double.Parse(textBox5.Text);

                _piramidaController.SetPrismDimensions(sideA, sideB, height, height2, height3);
                label5.Text =
                    $"Результат: \nПлоща:{_piramidaController.CalculateSurfaceArea()} \nОб'єм:{_piramidaController.CalculateVolume()}";
            }
            catch (Exception exception)
            {
                label5.Text =
                    $"Помилка: {exception.Message}";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            //ventana.Show();
            ventana.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alumnos ventana = new Alumnos();
            ventana.ShowDialog();
        }
    }
}

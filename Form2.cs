using Operaciones;

namespace formulario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            try
            {
                double num1, num2;
                num1 = Convert.ToDouble(tb_num1.Text);
                num2 = Convert.ToDouble(tb_num2.Text);

                if (rb_suma.Checked)
                {
                    lb_resultado.Text = "" + calc.sumar(num1, num2);
                }
                else if (rb_resta.Checked)
                {
                    lb_resultado.Text = "" + calc.restar(num1, num2);
                }
                else if (rb_multi.Checked)
                {
                    lb_resultado.Text = "" + calc.multiplicar(num1, num2);
                }
                else if (rb_division.Checked)
                {
                    double res = calc.dividir(num1, num2);
                    if (res == 0)
                    {
                        lb_resultado.Text = "No se puede dividir por cero";
                    }
                    else
                        lb_resultado.Text = "" + res;
                }
                else
                {
                    lb_resultado.Text = "Seleccione una operación";
                }
            }
            catch
            {
                lb_resultado.Text = "Ingrese los números para operar";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}

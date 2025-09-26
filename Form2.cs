using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tb_resultado.Enabled = false;
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
            try { 
                double num1, num2;
                num1 = Convert.ToDouble(tb_num1.Text);
                num2 = Convert.ToDouble(tb_num2.Text);

                if (rb_suma.Checked) 
                {                 
                    sumar(num1, num2);
                }
                else if(rb_resta.Checked)
                {
                    restar(num1, num2);
                }
                else if(rb_multi.Checked)
                {
                    multiplicar(num1, num2);
                }
                else if(rb_division.Checked)
                {
                    dividir(num1, num2);
                }
                else
                {
                    tb_resultado.Text = "Seleccione una operación";
                }
            } catch
            {
                tb_resultado.Text = "Ingrese los números para operar";
            }


        }

        private void sumar(double num1, double num2)
        {
            double resultado;
            resultado = num1 + num2;
            tb_resultado.Text = "" + resultado;
        }

        private void restar(double num1, double num2)
        {
            double resultado;
            resultado = num1 - num2;
            tb_resultado.Text = "" + resultado;
        }

        private void multiplicar(double num1, double num2)
        {
            double resultado;
            resultado = num1 * num2;
            tb_resultado.Text = "" + resultado;
        }

        private void dividir(double num1, double num2)
        {
            double resultado;
            if (num2 != 0)
            {
                resultado = num1 / num2;
                tb_resultado.Text = "" + Math.Round(resultado, 2);
            }
            else
            {
                tb_resultado.Text = "Error: División por cero";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

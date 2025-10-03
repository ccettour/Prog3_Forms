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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
            inicializarComboPais();
            tb_edad.Enabled = false;

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            tb_nombre.Clear();
            tb_apellido.Clear();
            dtp_fechaNac.Value = DateTime.Now;
            cb_pais.SelectedIndex = -1;
            tb_edad.Clear();
        }

        private void inicializarComboPais()
        {
            cb_pais.Items.Add("Argentina");
            cb_pais.Items.Add("Brasil");
            cb_pais.Items.Add("Chile");
            cb_pais.Items.Add("Uruguay");
            cb_pais.Items.Add("Paraguay");
            cb_pais.Items.Add("Bolivia");
            cb_pais.Items.Add("Perú");
            cb_pais.Items.Add("Ecuador");
            cb_pais.Items.Add("Colombia");
            cb_pais.Items.Add("Venezuela");
        }

        private void dtp_fechaNac_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - dtp_fechaNac.Value.Year;
            if (fechaActual < dtp_fechaNac.Value.AddYears(edad))
            {
                edad--;
            }
            tb_edad.Text = edad.ToString();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            dtp_fechaNac_ValueChanged(sender, e);
        }
    }
}

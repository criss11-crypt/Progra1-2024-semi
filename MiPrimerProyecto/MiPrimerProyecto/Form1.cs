

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz
{
    public partial class conversores : Form
    {
        convertir objConversor = new convertir();
        public conversores()
        {
            InitializeComponent();
        }

        private void conversores_Load(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
            asignarEtiquetas();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int opcion = cboTipo.SelectedIndex,
                de = cboDe.SelectedIndex,
                a = cboA.SelectedIndex;
            double cantidad = Double.Parse(txtcantidad.Text);

            lblRespuesta.Text = "Respuesta: " + Math.Round(objConversor.convertirValores(opcion, de, a, cantidad), 2);
        }

        private void asignarEtiquetas()
        {
            cboDe.Items.Clear();
            cboA.Items.Clear();

            cboDe.Items.AddRange(objConversor.etiquetas[cboTipo.SelectedIndex]);
            cboA.Items.AddRange(objConversor.etiquetas[cboTipo.SelectedIndex]);
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            asignarEtiquetas();
        }
    }
    class convertir
    {
        public String[][] etiquetas = new string[][]{
            new string[]{"Dolar","Colon SV", "Euro", "Quetzal", "Lempita"},
            new string[]{"Hora","Milisegundo", "Segundos", "Minutos", "Dias", "Semana"},
            new string[]{"Metro","Cm", "Pulgadas", "Pies", "Varas", "Yardas", "Km"}
        };
        Double[][] valores = new Double[][] {
            new double[]{1, 8.75, 0.93, 7.9, 24.68},
            new double[]{1, 360000, 3600, 60, 0.0416667, 0.005952380952},
            new double[]{1,100, 39.3701, 3.28084, 1.1963, 1.09361, 0.001}
        };
        public Double convertirValores(int opcion, int de, int a, double cantidad)
        {
            return valores[opcion][a] / valores[opcion][de] * cantidad;
        }
    }
}

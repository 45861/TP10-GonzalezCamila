using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            int nuevoAncho = this.Width;
            int nuevoAlto = this.Height;

            if (rbDim1.Checked)
            {
                nuevoAncho = 800;
                nuevoAlto = 600;
            }
            else if (rbDim2.Checked)
            {
                nuevoAncho = 1024;
                nuevoAlto = 768;
            }
            else if (rbDim3.Checked)
            {
                nuevoAncho = 1280;
                nuevoAlto = 1024;
            }
            else
            {
                MessageBox.Show("Seleccione una opción para el tamaño del formulario.");
                return;
            }

            this.Width = nuevoAncho;
            this.Height = nuevoAlto;
            lblResultado.Text = $"Nuevo tamaño: Ancho = {nuevoAncho}, Alto = {nuevoAlto}";
        
        }
    }
}

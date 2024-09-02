using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_3
{
    public partial class Form1 : Form
    {
        //Confeccionar un programa que muestre 3 objetos de la clase CheckBox con etiquetas de tres idiomas.
        //Cuando se presiona un botón mostrar los CheckBox seleccionados hasta el momento.
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var seleccionados = string.Empty;

            if (chkOpcion1.Checked)
            {
                seleccionados += chkOpcion1.Text + "\n";
            }

            if (chkOpcion2.Checked)
            {
                seleccionados += chkOpcion2.Text + "\n";
            }

            if (chkOpcion3.Checked)
            {
                seleccionados += chkOpcion3.Text + "\n";
            }

            if (string.IsNullOrEmpty(seleccionados))
            {
                lblResultado.Text = "Ninguna opción seleccionada.";
            }
            else
            {
                lblResultado.Text = "Opciones seleccionadas:\n" + seleccionados.Trim();
            }
        }
    }
}

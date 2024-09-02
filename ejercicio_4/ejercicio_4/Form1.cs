using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_4
{
    public partial class Form1 : Form
    {
        //Disponer un control Label que muestre el siguiente mensaje: "Está de acuerdo con las normas del
        //servicio?", luego un CheckBox y finalmente un objeto de tipo Button desactivo (propiedad Enabled con
        //false). Cuando se tilde el CheckBox debemos activar el botón(para esto debemos responder al evento)
        public Form1()
        {
            InitializeComponent();
        }

        private void chkAceptar_CheckedChanged(object sender, EventArgs e)
        {
            btnContinuar.Enabled = chkAceptar.Checked;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

        }
    }
}

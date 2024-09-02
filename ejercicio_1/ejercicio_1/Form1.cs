using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //permitir el ingreso de dos numeros en controles de tipo textbox y mediante dos controles de
            // tipo RadioButton permitir seleccionar si queremos sumarlos o restarlos. Al presionar un boton mostrar 
            // el resultado de la operacion seleccionada. 
            try
            {
                double numero1 = double.Parse(txtNumero1.Text);
                double numero2 = double.Parse(txtNumero2.Text);
                double resultado = 0;
                
                if (rbSumar.Checked)
                {
                    resultado = numero1 + numero2;
                }
                else if (rbRestar.Checked)
                {
                    resultado = numero1 - numero2;
                }
                else
                {
                    lblResultado.Text = "Seleccione una operación.";
                    return;
                }
                
                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (FormatException)
            {
               
                lblResultado.Text = "Por favor, ingrese números válidos.";
            }
        }
    }
}

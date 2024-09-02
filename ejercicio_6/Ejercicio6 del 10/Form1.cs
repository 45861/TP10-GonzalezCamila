using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6_del_10
{
    public partial class Form1 : Form
    {
        //Elaborar una interfaz gráfica que muestre una calculadora (utilizar objetos de la clase Button y un objeto
        //de la clase Label donde se muestra el valor ingresado), tener en cuenta que solo se debe implementar la
        //interfaz y la carga de un valor de hasta 12 dígitos.
        private int numero;
        private string operacion; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1"; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }


        private void button12_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox1.Text);
            textBox1.Text = "";
            operacion = "suma"; 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int aux = int.Parse(textBox1.Text);
            switch (operacion)
            {
                case "suma":
                    textBox1.Text = (numero + aux).ToString();
                    break;
                case "resta":
                    textBox1.Text = (numero - aux).ToString();
                    break;
                case "multiplicacion":
                    textBox1.Text = (numero * aux).ToString();
                    break;
                case "division":
                    if (aux != 0)
                    {
                        textBox1.Text = (numero / (double)aux).ToString(); // Convertir a double para obtener decimales
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.");
                        textBox1.Text = "0";
                    }
                    break;
                default:
                    MessageBox.Show("Operación no válida.");
                    break;
            }
            numero = 0;
            operacion = "";


            /* xt = (numero + aux).ToString(); 
            }
            aux = 0; */
        }

        
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numero = 0; 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox1.Text);
            textBox1.Text = "";
            operacion = "resta";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox1.Text);
            textBox1.Text = "";
            operacion = "multiplicacion";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox1.Text);
            textBox1.Text = "";
            operacion = "division";
        }
    }
}

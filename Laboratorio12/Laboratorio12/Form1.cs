using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void buttonCalcular_Click1(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox y convertirlos a números
            double velocidad = double.Parse(textBoxVelocidad.Text);
            double tiempo = double.Parse(textBoxTiempo.Text);

            // Calcular la distancia
            double distancia = velocidad * tiempo;

            // Mostrar el resultado en el Label
            labelResultado.Text = "La distancia recorrida es: " + distancia + " metros";
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void buttonLimpiar_Click1(object sender, EventArgs e)
        {
            // Limpiar los TextBox y el Label
            textBoxVelocidad.Text = "";
            textBoxTiempo.Text = "";
            labelResultado.Text = "";
        }

        private void buttonSalir_Click_Click(object sender, EventArgs e)
        {
        }

        private void buttonSalir_Click1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
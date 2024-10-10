using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            // Obtener las notas ingresadas y convertirlas a números
            double nota1 = double.Parse(textBox1.Text);
            double nota2 = double.Parse(textBox2.Text);
            double nota3 = double.Parse(textBox3.Text);

            // Calcular el promedio
            double promedio = (nota1 + nota2 + nota3) / 3;

            // Mostrar el resultado en el label con 2 decimales
            labelPromedio.Text = "El promedio es: " + promedio.ToString("F2");
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox y el Label
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            labelPromedio.Text = "";
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

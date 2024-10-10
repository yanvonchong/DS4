using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_3
{
    public partial class Form1 : Form
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonCalcularSemiperimetro(object sender, EventArgs e)
        {
            // Obtener las longitudes de los lados y convertirlas a números
            double ladoA = double.Parse(textBoxLadoA.Text);
            double ladoB = double.Parse(textBoxLadoB.Text);
            double ladoC = double.Parse(textBoxLadoC.Text);

            // Calcular el semiperímetro
            double semiperimetro = (ladoA + ladoB + ladoC) / 2;

            // Mostrar el resultado en el label
            labelSemiperimetro.Text = "El semiperímetro es: " + semiperimetro.ToString();
        }
        private void ButtonArea_Click(object sender, EventArgs e)
        {
            double semiperimetro;
            if (double.TryParse(labelSemiperimetro.Text.Replace("El semiperímetro es: ", ""), out semiperimetro))
            {
                // Obtener las longitudes de los lados y convertirlas a números
                double ladoA = double.Parse(textBoxLadoA.Text);
                double ladoB = double.Parse(textBoxLadoB.Text);
                double ladoC = double.Parse(textBoxLadoC.Text);

                // Calcular el área utilizando la fórmula de Herón
                double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

                // Mostrar el resultado en el label
                labelArea.Text = "El área es: " + area.ToString();
            }
            else
            {
                // Manejar el error de formato
                MessageBox.Show("El formato del semiperímetro no es válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox y los Label
            textBoxLadoA.Text = "";
            textBoxLadoB.Text = "";
            textBoxLadoC.Text = "";
            labelSemiperimetro.Text = "";
            labelArea.Text = "";
        }
        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

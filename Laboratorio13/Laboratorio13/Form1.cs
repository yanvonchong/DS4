using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        private readonly string StringConnectionString = @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        // M�todo para conectar y desconectar del servidor
        private void button1_Click(object sender, EventArgs e)
        {
            using (var SqlConex = new SqlConnection(StringConnectionString))
            {
                SqlConex.Open();
                MessageBox.Show("Conexi�n abierta");
                SqlConex.Close();
                MessageBox.Show("Conexi�n cerrada");
            }
        }

        // M�todo para desplegar los productos
        private void BtnDesplegar_Click(object sender, EventArgs e)
        {
            using (var SqlConex = new SqlConnection(StringConnectionString))
            {
                SqlConex.Open();
                const string SqlExecute = "SELECT ProductName FROM dbo.Products;";
                SqlCommand cmd = new SqlCommand(SqlExecute, SqlConex);
                SqlDataReader reader = cmd.ExecuteReader();

                listBox1.Items.Clear();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["ProductName"].ToString());
                }

                reader.Close();
                SqlConex.Close();
            }
        }
    }
}

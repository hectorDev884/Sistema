using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.IdentityModel.Tokens;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema
{
    public partial class Menu : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            GetData();
            txtIdMenu.Text = GetNewId().ToString();


        }

        private void EnableTexts(bool status)
        {
            txtConcepto.Enabled = status;
            txtDescripcion.Enabled = status;
            txtPrecio.Enabled = status;
        }
        private void GetData()
        {
            string query = "SELECT * FROM MenuPlatillos";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgvMenu.DataSource = dt;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cmdNuevo.Enabled = false;
            cmdGrabar.Enabled = true;
            cmdModificar.Enabled = false;
            cmdBuscar.Enabled = true;
            txtConcepto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtIdMenu.Text = GetNewId().ToString();
            EnableTexts(true);
        }
        private bool ValidValues(string concepto, string descripcion, string precio)
        {
            if (string.IsNullOrEmpty(concepto) ||
                string.IsNullOrEmpty(descripcion) ||
                string.IsNullOrEmpty(precio))
            {
                MessageBox.Show("No se permiten campos nulos");
                return true;
            }

            if (!Regex.IsMatch(concepto.Trim(), @"^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$"))
            {
                MessageBox.Show("El concepto debe contener solo letras");
                return true;
            }

            if (!Regex.IsMatch(precio, @"^-?\d+(\.\d+)?$"))
            {
                MessageBox.Show("El precio debe ser un numero flotante");
                return true;
            }

            return false;

        }
        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdBuscar.Enabled = true;
            if (ValidValues(txtConcepto.Text, txtDescripcion.Text, txtPrecio.Text))
            {
                return;
            }
            sqlCommand.CommandText = "INSERT INTO MenuPlatillos VALUES(@concepto, @descripcion, @precio);";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@concepto", txtConcepto.Text);
            sqlCommand.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
            sqlCommand.Parameters.AddWithValue("@precio", Convert.ToDouble(txtPrecio.Text));

            sqlCommand.ExecuteNonQuery();
            txtIdMenu.Text = GetNewId().ToString();
            GetData();
            EnableTexts(false);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            Close();
        }

        private int GetNewId()
        {
            sqlCommand.CommandText = "SELECT TOP 1 MenuPlatillos.IdPlatillo FROM MenuPlatillos ORDER BY IdPlatillo DESC";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            int id = 0;
            if (reader.Read())
            {
                id = Convert.ToInt32(reader.GetValue(0));
            }

            reader.Close();
            return id + 1;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string auxId = Microsoft.VisualBasic.Interaction.InputBox("ID: ", "Buscar Platillo");

            if (string.IsNullOrEmpty(auxId))
            {
                MessageBox.Show("El id no debe ser nulo");
                return;
            }

            if (!auxId.All(char.IsDigit) || auxId.Length > 9)
            {
                MessageBox.Show("El id debe ser entero, positivo y no mayor a 9 digitos");
                return;
            }
            int id = Convert.ToInt32(auxId);


            sqlCommand.CommandText = "SELECT * FROM MenuPlatillos WHERE IdPlatillo = @Id";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                txtIdMenu.Text = reader.GetValue(0).ToString();
                txtConcepto.Text = reader.GetValue(1).ToString();
                txtDescripcion.Text = reader.GetValue(2).ToString();
                txtPrecio.Text = reader.GetValue(3).ToString();
                cmdBuscar.Enabled = false;
                cmdModificar.Enabled = true;
                cmdGrabar.Enabled = false;
                cmdNuevo.Enabled = true;
                EnableTexts(true);
            }
            else
            {
                MessageBox.Show($"El id: {id} no existe en la tabla MenuPlatillos");
            }
            reader.Close();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (ValidValues(txtConcepto.Text, txtDescripcion.Text, txtPrecio.Text))
            {
                return;
            }

            sqlCommand.CommandText = "UPDATE MenuPlatillos SET Concepto=@Concepto, Descripcion=@Descripcion," +
                                      "Precio=@Precio WHERE IdPlatillo=@Id";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@Concepto", txtConcepto.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
            sqlCommand.Parameters.AddWithValue("@Precio", Convert.ToDouble(txtPrecio.Text));
            sqlCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(txtIdMenu.Text));

            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdBuscar.Enabled = true;
            cmdModificar.Enabled = false;
            EnableTexts(false);
            sqlCommand.ExecuteNonQuery();
            GetData();

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdBuscar.Enabled = true;
            cmdModificar.Enabled = false;
            txtConcepto.Clear();
            txtDescripcion.Clear();
            txtIdMenu.Text = GetNewId().ToString();
            txtPrecio.Clear();
        }
    }
}

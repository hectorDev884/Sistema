using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Repartidores : Form
    {
        public Repartidores()
        {
            InitializeComponent();
        }

        private void Repartidores_Load(object sender, EventArgs e)
        {
            GetData();
            txtIdRepartidor.Text = GetNewId().ToString();
        }
        private void EnableTexts(bool status)
        {
            txtNombre.Enabled = status;
            txtTelefono.Enabled = status;
            txtVehiculo.Enabled = status;
        }

        private void GetData()
        {
            string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("", sqlConnection);
            string query = "SELECT * FROM Repartidores;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgvRepartidores.DataSource = dt;
            sqlConnection.Close();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cmdNuevo.Enabled = false;
            cmdGrabar.Enabled = true;
            cmdModificar.Enabled = false;
            txtNombre.Clear();
            txtVehiculo.Clear();
            txtTelefono.Clear();
            txtIdRepartidor.Clear();
            txtIdRepartidor.Enabled = false;
            txtIdRepartidor.Text = GetNewId().ToString();
            EnableTexts(true);
        }

        private bool ValidValues(string nombre, string vehiculo, string telefono)
        {
            if (string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(vehiculo) ||
                string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("No se permiten campos nulos");
                return true;
            }

            if (!Regex.IsMatch(nombre.Trim(), @"^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$"))
            {
                MessageBox.Show("El nombre no puede contener digitos");
                return true;
            }

            telefono = telefono.Replace(" ", "");
            if (telefono.Length != 10 || !telefono.All(char.IsDigit))
            {
                MessageBox.Show("El numero de telefono debe ser de 10 digitos numericos");
                return true;
            }

            return false;

        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {

            if (ValidValues(txtNombre.Text, txtVehiculo.Text, txtTelefono.Text))
            {
                return;
            }
            string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("", sqlConnection);
            sqlCommand.CommandText = "INSERT INTO Repartidores VALUES(@nombre, @telefono, @vehiculo);";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@vehiculo", txtVehiculo.Text);
            sqlCommand.Parameters.AddWithValue("@telefono", txtTelefono.Text.Replace(" ", ""));

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            GetData();
            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdModificar.Enabled = false;
            EnableTexts(false);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int GetNewId()
        {
            string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("", sqlConnection);
            sqlCommand.CommandText = "SELECT TOP 1 IdRepartidor FROM Repartidores ORDER BY IdRepartidor DESC";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            int id = 0;
            if (reader.Read())
            {
                id = Convert.ToInt32(reader.GetValue(0));
            }

            reader.Close();
            sqlConnection.Close();
            return id + 1;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("", sqlConnection);

            string auxId = Microsoft.VisualBasic.Interaction.InputBox("ID: ", "Buscar Repartidor");

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


            sqlCommand.CommandText = "SELECT * FROM Repartidores WHERE IdRepartidor = @id";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                txtIdRepartidor.Text = reader.GetValue(0).ToString();
                txtNombre.Text = reader.GetValue(1).ToString();
                txtTelefono.Text = reader.GetValue(2).ToString();
                txtVehiculo.Text = reader.GetValue(3).ToString();
                cmdBuscar.Enabled = false;
                cmdModificar.Enabled = true;
                cmdGrabar.Enabled = false;
                EnableTexts(true);
            }
            else
            {
                MessageBox.Show($"El id: {id} no existe en la tabla Repartidores");
            }
            reader.Close();
            sqlConnection.Close();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (ValidValues(txtNombre.Text, txtVehiculo.Text, txtTelefono.Text))
            {
                return;
            }
            string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("", sqlConnection);
            sqlCommand.CommandText = "UPDATE Repartidores SET Nombre=@Nombre, Telefono=@Telefono," +
                                      "Vehiculo=@Vehiculo WHERE IdRepartidor=@Id";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Replace(" ", ""));
            sqlCommand.Parameters.AddWithValue("@Vehiculo", txtVehiculo.Text);
            sqlCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(txtIdRepartidor.Text));

            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdBuscar.Enabled = true;
            cmdModificar.Enabled = false;
            EnableTexts(false);


            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            GetData();

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdBuscar.Enabled = true;
            cmdModificar.Enabled = false;
            txtNombre.Clear();
            txtVehiculo.Clear();
            txtTelefono.Clear();
            txtIdRepartidor.Clear();
            txtIdRepartidor.Enabled = false;
            txtIdRepartidor.Text = GetNewId().ToString();
            EnableTexts(false);
        }
    }
}

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

namespace Sistema
{
    public partial class Repartidores : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        public Repartidores()
        {
            InitializeComponent();
        }

        private void Repartidores_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            txtIdRepartidor.Text = GetNewId().ToString();
            GetData();
        }

        private void GetData()
        {
            string query = "SELECT * FROM Repartidores;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgvRepartidores.DataSource = dt;
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
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            sqlCommand.CommandText = "INSERT INTO Repartidores VALUES(@nombre, @telefono, @vehiculo);";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", txtNombre.Text);
            sqlCommand.Parameters.AddWithValue("@vehiculo", txtVehiculo.Text);
            sqlCommand.Parameters.AddWithValue("@telefono", txtTelefono.Text);

            sqlCommand.ExecuteNonQuery();
            GetData();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            Close();
        }

        private int GetNewId()
        {
            sqlCommand.CommandText = "SELECT TOP 1 IdRepartidor FROM Repartidores ORDER BY IdRepartidor DESC";
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
            int id = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("ID: ", "Buscar Repartidor"));
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
            }
            else
            {
                MessageBox.Show($"El id: {id} no existe en la tabla Repartidores");
            }
            reader.Close();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            sqlCommand.CommandText = "UPDATE Repartidores SET Nombre=@Nombre, Telefono=@Telefono," +
                                      "Vehiculo=@Vehiculo WHERE IdRepartidor=@Id";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            sqlCommand.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            sqlCommand.Parameters.AddWithValue("@Vehiculo", txtVehiculo.Text);
            sqlCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(txtIdRepartidor.Text));

            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdBuscar.Enabled = true;
            cmdModificar.Enabled = false;


            sqlCommand.ExecuteNonQuery();
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
        }
    }
}

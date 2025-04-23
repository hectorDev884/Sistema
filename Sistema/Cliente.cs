using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Sistema
{
    public partial class Cliente : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();


        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            txtIdCliente.Text = GetNewId().ToString();
            GetData();
        }
        private void EnableTexts(bool status)
        {
            txtNombre.Enabled = status;
            txtTelefono.Enabled = status;
            txtDireccion.Enabled = status;
        }
        private void GetData()
        {
            string query = "SELECT * FROM Clientes;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgvClientes.DataSource = dt;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            sqlCommand.CommandText = "INSERT INTO Clientes VALUES(@nombreCliente, @direccionCliente, @telefonoCliente)";
            string nombreCliente = txtNombre.Text;
            string direccionCliente = txtDireccion.Text;
            string telefonoCliente = txtTelefono.Text;
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombreCliente", nombreCliente);
            sqlCommand.Parameters.AddWithValue("@direccionCliente", direccionCliente);
            sqlCommand.Parameters.AddWithValue("telefonoCliente", telefonoCliente);

            EnableTexts(false);
            sqlCommand.ExecuteNonQuery();
            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdModificar.Enabled = false;
            GetData();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtIdCliente.Clear();
            txtIdCliente.Text = GetNewId().ToString();
            cmdNuevo.Enabled = false;
            cmdGrabar.Enabled = true;
            cmdCancelar.Enabled = true;
            cmdModificar.Enabled = false;
            EnableTexts(true);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            Close();
        }

        private int GetNewId()
        {
            sqlCommand.CommandText = "SELECT TOP 1 IdCliente FROM Clientes ORDER BY IdCliente DESC";
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
            int id = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("ID: ", "Buscar Cliente"));
            sqlCommand.CommandText = "SELECT * FROM Clientes WHERE IdCliente = @Id";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                txtIdCliente.Text = reader.GetValue(0).ToString();
                txtNombre.Text = reader.GetValue(1).ToString();
                txtDireccion.Text = reader.GetValue(2).ToString();
                txtTelefono.Text = reader.GetValue(3).ToString();
                cmdBuscar.Enabled = false;
                cmdModificar.Enabled = true;
                cmdGrabar.Enabled = false;
                cmdNuevo.Enabled = true;
                EnableTexts(true);
            }
            else
            {
                MessageBox.Show($"El id: {id} no existe en la tabla Clientes");
            }
            reader.Close();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            sqlCommand.CommandText = "UPDATE Clientes SET NombreCliente=@Nombre, DireccionCliente=@Direccion," +
                                      "TelefonoCliente=@Telefono WHERE IdCliente=@Id";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            sqlCommand.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            sqlCommand.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            sqlCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(txtIdCliente.Text));

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
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtIdCliente.Clear();
            txtIdCliente.Text = GetNewId().ToString();
            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdCancelar.Enabled = true;
            cmdModificar.Enabled = false;
            EnableTexts(false);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

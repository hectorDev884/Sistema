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
    public partial class Ordenes : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DateTime now = DateTime.Now;
        double importe = 0;
        double total = 0;
        List<string> idPlatillos = new List<string>();
        List<string> cantidades = new List<string>();
        List<string> precios = new List<string>();
        public Ordenes()
        {
            InitializeComponent();
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = connectionString;
            connection.Open();
            command.Connection = connection;
            txtFecha.Text = DateTime.Now.ToString();
            FillComboBox();
            txtNumPedido.Text = GetNewId().ToString();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            connection.Close();
            Close();
        }

        private void FillGrid()
        {
            double IVA = importe * 0.16;
            dgvOrden.Rows.Add(
                cbxCliente.Text,
                cbxRepartidor.Text,
                cbxPlatillo.Text,
                txtPrecioMenu.Text,
                txtCantidad.Text,
                importe,
                IVA
                );

        }

        private void FillComboBox()
        {
            command.CommandText = "SELECT NombreCliente FROM Clientes";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbxCliente.Items.Add(reader.GetString(0));
            }

            command.CommandText = "SELECT Nombre FROM Repartidores";
            reader.Close();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbxRepartidor.Items.Add(reader.GetString(0));
            }

            command.CommandText = "SELECT Concepto FROM MenuPlatillos";
            reader.Close();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbxPlatillo.Items.Add(reader.GetString(0));
            }

            reader.Close();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            command.CommandText = "SELECT * FROM Clientes WHERE NombreCliente=@Nombre";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Nombre", cbxCliente.Text);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            txtIdCliente.Text = reader.GetValue(0).ToString();
            txtDireccionCliente.Text = reader.GetString(2);
            txtTelefonoCliente.Text = reader.GetString(3);
            reader.Close();
        }

        private void cbxRepartidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            command.CommandText = "SELECT * FROM Repartidores WHERE Nombre=@Nombre";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Nombre", cbxRepartidor.Text);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            txtIdRep.Text = reader.GetValue(0).ToString();
            txtTelefonoRep.Text = reader.GetString(2);
            txtVehiculoRep.Text = reader.GetString(3);
            reader.Close();
        }

        private void cbxPlatillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            command.CommandText = "SELECT * FROM MenuPlatillos WHERE Concepto=@Concepto";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Concepto", cbxPlatillo.Text);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            txtIdPlatillo.Text = reader.GetValue(0).ToString();
            txtDescripcionMenu.Text = reader.GetString(2);
            txtPrecioMenu.Text = reader.GetValue(3).ToString();
            reader.Close();
        }

        private int GetNewId()
        {
            int id = 0;
            string query = "SELECT TOP 1 IdOrden FROM Ordenes ORDER BY IdOrden DESC";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) id = reader.GetInt32(0);

            reader.Close();
            return id + 1;
        }

        private void SetStatus(bool nuevo, bool grabar, bool OK)
        {
            cmdNuevo.Enabled = nuevo;
            cmdGrabar.Enabled = grabar;
            cmdOK.Enabled = OK;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            SetStatus(false, false, true);
            cbxCliente.Enabled = true;
            cbxRepartidor.Enabled = true;
            cbxPlatillo.Enabled = true;
            dgvOrden.Rows.Clear();
            txtTotal.Text = "0";
            idPlatillos.Clear();
            precios.Clear();
            cantidades.Clear();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            SetStatus(true, false, false);
            command.CommandText = "INSERT INTO Ordenes VALUES (@IdCliente, @IdRepartidor, @Fecha, 'R', @Total)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(txtIdCliente.Text));
            command.Parameters.AddWithValue("@IdRepartidor", Convert.ToInt32(txtIdRep.Text));
            command.Parameters.AddWithValue("@Fecha", txtFecha.Text);
            command.Parameters.AddWithValue("@Total", total);
            command.ExecuteNonQuery();

            for (int i = 0; i < idPlatillos.Count; i++)
            {
                command.CommandText = $"INSERT INTO DetalleOrden VALUES" +
                    $"({Convert.ToInt32(txtNumPedido.Text)}" +
                    $", {Convert.ToInt32(idPlatillos[i])}" +
                    $", {Convert.ToInt32(cantidades[i])}" +
                    $", {Convert.ToDouble(precios[i])})";
                command.ExecuteNonQuery();
            }

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            SetStatus(true, false, false);
            cbxCliente.Enabled = false;
            cbxRepartidor.Enabled = false;
            cbxPlatillo.Enabled = false;
            dgvOrden.Rows.Clear();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            cbxCliente.Enabled = false;
            cbxRepartidor.Enabled = false;
            cmdGrabar.Enabled = true;
            idPlatillos.Add(txtIdPlatillo.Text);
            precios.Add(txtPrecioMenu.Text);
            cantidades.Add(txtCantidad.Text);

            importe = Convert.ToDouble(txtPrecioMenu.Text) * Convert.ToInt32(txtCantidad.Text);
            FillGrid();
            total += importe * 1.16;
            txtTotal.Text = total.ToString();
            cbxPlatillo.SelectedIndex = 0;

        }

        private void dgvOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

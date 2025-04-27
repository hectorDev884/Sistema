using Microsoft.Data.SqlClient;
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
    public partial class Ordenes : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DateTime now = DateTime.Now;
        double importe = 0;
        double total = 0;
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
            if (!CheckDetalleOrden())
            {
                dgvOrden.Rows.Add(
                                txtIdPlatillo.Text,
                                cbxPlatillo.Text,
                                txtPrecioMenu.Text,
                                txtCantidad.Text,
                                importe
                                );
            }
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
            txtSubTotal.Text = "0";
        }

        private bool CheckDetalleOrden()
        {
            int existentId = Convert.ToInt32(txtIdPlatillo.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            for (int i = 0; i < dgvOrden.Rows.Count - 1; i++)
            {
                int campoIdMenu = Convert.ToInt32(dgvOrden.Rows[i].Cells[0].Value);

                if (campoIdMenu == existentId)
                {

                    cantidad += Convert.ToInt32(dgvOrden.Rows[i].Cells[3].Value);
                    double precio = Convert.ToDouble(dgvOrden.Rows[i].Cells[2].Value);
                    dgvOrden.Rows[i].Cells[4].Value = cantidad * precio;
                    dgvOrden.Rows[i].Cells[3].Value = cantidad;
                    MessageBox.Show("Detalle ya existe, sumando cantidad.");
                    //dgvOrden.Rows[i].Cells[3].Value += cantidad; cannot convert object to int
                    return true;
                }

            }

            return false;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            if (dgvOrden.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar al menos un platillo");
                return;
            }
            if (cbxCliente.SelectedIndex == -1 || cbxRepartidor.SelectedIndex == -1)
            {
                MessageBox.Show("Se deben seleccionar cliente y repartidor");
                return;
            }
            SetStatus(true, false, false);
            command.CommandText = "INSERT INTO Ordenes VALUES (@IdCliente, @IdRepartidor, @Fecha, 'R', @Total)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(txtIdCliente.Text));
            command.Parameters.AddWithValue("@IdRepartidor", Convert.ToInt32(txtIdRep.Text));
            command.Parameters.AddWithValue("@Fecha", txtFecha.Text);
            command.Parameters.AddWithValue("@Total", total);
            command.ExecuteNonQuery();

            for (int i = 0; i < dgvOrden.Rows.Count - 1; i++)
            {
                int campoId = Convert.ToInt32(txtNumPedido.Text);
                int campoIdMenu = Convert.ToInt32(dgvOrden.Rows[i].Cells[0].Value);
                int cantidad = Convert.ToInt32(dgvOrden.Rows[i].Cells[3].Value);
                double precio = Convert.ToDouble(dgvOrden.Rows[i].Cells[2].Value);

                command.CommandText = $"INSERT INTO DetalleOrden VALUES" +
                    $"({campoId}" +
                    $", {campoIdMenu}" +
                    $", {cantidad}" +
                    $", {precio})";
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
            if (txtCantidad.Text.Length == 0 || txtCantidad.Text.Length > 5)
            {
                MessageBox.Show("La cantidad no debe ser nula y debe ser menor a 6 digitos");
                return;
            }
            if (!Regex.IsMatch(txtCantidad.Text, @"^[1-9]\d*$"))
            {
                MessageBox.Show("El numero debe ser entero positivo");
                return;
            }
            cbxCliente.Enabled = false;
            cbxRepartidor.Enabled = false;
            cmdGrabar.Enabled = true;

            importe = Convert.ToDouble(txtPrecioMenu.Text) * Convert.ToInt32(txtCantidad.Text);
            FillGrid();
            total += importe;
            txtSubTotal.Text = total.ToString();
            txtTotal.Text = (Convert.ToDouble(txtSubTotal.Text) * 1.16).ToString();
            cbxPlatillo.SelectedIndex = 0;

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string auxId = Microsoft.VisualBasic.Interaction.InputBox("ID: ", "Buscar Orden");

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

            command.CommandText = "SELECT IdOrden FROM Ordenes WHERE IdOrden = @Id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read()) ShowQuery(reader.GetValue(0).ToString());

            else MessageBox.Show($"No se encontro el ID: {id}");

            reader.Close();
        }

        private void ShowQuery(string id)
        {
            if (Application.OpenForms["DetalleOrden"] == null)
            {
                DetalleOrden dt = new DetalleOrden();
                dt.Show();
                dt.SetIdOrden(id);
                //dt.GetOrdenData();
                //dt.GetDetalleOrden();

            }
            else
            {
                Application.OpenForms["DetalleOrden"].Focus();
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

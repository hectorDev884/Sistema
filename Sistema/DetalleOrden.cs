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
    public partial class DetalleOrden : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public DetalleOrden()
        {
            InitializeComponent();
        }

        private void DetalleOrden_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = connectionString;
            connection.Open();
            command.Connection = connection;
            ShowData();
        }

        private async void ShowData()
        {
            await Task.Delay(1);
            GetOrdenData();
            GetDetalleOrden();
        }
        private void GetOrdenData()
        {
            string r = $"SELECT O.Fecha, O.Estado, o.IdCliente, c.NombreCliente, c.DireccionCliente," +
                $" c.TelefonoCliente, r.IdRepartidor, r.Nombre, r.Telefono, r.Vehiculo, o.Total," +
                $" o.Total * 1.16 as Subtotal FROM Ordenes O " +
                $"INNER JOIN Clientes C on O.IdCliente = C.IdCliente " +
                $"INNER JOIN Repartidores R on O.IdRepartidor = r.IdRepartidor " +
                $"WHERE o.IdOrden = {Convert.ToInt32(txtIdOrden.Text)}";
            command.CommandText = r;
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            txtFecha.Text = reader.GetValue(0).ToString();
            txtEstado.Text = $"{reader.GetValue(1).ToString()}";
            txtIdCliente.Text = reader.GetInt32(2).ToString();
            txtCliente.Text = reader.GetValue(3).ToString();
            txtDireccionCliente.Text = reader.GetValue(4).ToString();
            txtTelefonoCliente.Text = reader.GetValue(5).ToString();
            txtIdRep.Text = reader.GetInt32(6).ToString();
            txtRepartidor.Text = reader.GetValue(7).ToString();
            txtTelefonoRep.Text = reader.GetValue(8).ToString();
            txtVehiculoRep.Text = reader.GetValue(9).ToString();
            txtSubTotal.Text = reader.GetValue(10).ToString();
            txtTotal.Text = reader.GetValue(11).ToString();
            //string query = $"SELECT * FROM Ordenes WHERE IdOrden = {Convert.ToInt32(txtIdOrden.Text)}";
            reader.Close();

        }

        private void GetDetalleOrden()
        {
            string r = "SELECT Dt.IdOrden, M.IdPlatillo, M.Concepto, " +
                "Dt.Cantidad, Dt.Precio, (Dt.Cantidad * Dt.Precio) as Importe " +
                "FROM DetalleOrden Dt INNER JOIN MenuPlatillos M " +
                "ON M.IdPlatillo = Dt.IdPlatillo " +
                $"WHERE Dt.IdOrden = {Convert.ToInt32(txtIdOrden.Text)}";
            SqlDataAdapter adapter = new SqlDataAdapter(r, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvDetalleOrden.DataSource = dt;
        }

        public void SetIdOrden(string id)
        {
            txtIdOrden.Text = id;
            nOrden.Text = $"Orden #{id}";
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            connection.Close();
            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (txtEstado.Text.Equals("C")) MessageBox.Show("La orden ya esta cancelada");
            else if (txtEstado.Text.Equals("P")) MessageBox.Show("La orden ya esta pagada");
            else
            {
                string query = $"UPDATE Ordenes SET Estado='C' " +
                                $"WHERE IdOrden = {Convert.ToInt32(txtIdOrden.Text)} " +
                                $"AND (Estado = 'R' OR Estado = 'S')";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtEstado.Text = "C";
            }
        }

        private void cmdSurtir_Click(object sender, EventArgs e)
        {
            if (txtEstado.Text.Equals("S")) MessageBox.Show("La orden ya esta surtida");
            else if (txtEstado.Text.Equals("C")) MessageBox.Show("La orden esta cancelada");
            else if (txtEstado.Text.Equals("P")) MessageBox.Show("La orden ya esta pagada");
            else
            {
                string query = $"UPDATE Ordenes SET Estado='S' " +
                                $"WHERE IdOrden = {Convert.ToInt32(txtIdOrden.Text)} " +
                                $"AND (Estado = 'R' AND NOT Estado = 'C')";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtEstado.Text = "S";
            }
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            if (txtEstado.Text.Equals("P")) MessageBox.Show("La orden ya esta pagada");
            else if (txtEstado.Text.Equals("C")) MessageBox.Show("La orden esta cancelada");
            else if (txtEstado.Text.Equals("R")) MessageBox.Show("La orden debe estar surtida");
            else
            {
                string query = $"UPDATE Ordenes SET Estado='P' " +
                                $"WHERE IdOrden = {Convert.ToInt32(txtIdOrden.Text)} " +
                                $"AND (Estado = 'S' AND NOT Estado = 'C')";
                command.CommandText = query;
                command.ExecuteNonQuery();
                txtEstado.Text = "P";
            }
        }
    }
}

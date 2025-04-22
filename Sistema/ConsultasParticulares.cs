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
    public partial class ConsultasParticulares : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        string query;
        string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public ConsultasParticulares()
        {
            InitializeComponent();
        }

        private void ConsultasParticulares_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = connectionString;
            connection.Open();
            command.Connection = connection;
            query = "SELECT O.IdOrden, C.NombreCliente, R.Nombre as NombreRepartidor, O.Fecha, O.Estado, O.Total, COUNT(DISTINCT Dt.IdPlatillo) as VariedadPlatillos FROM Ordenes O INNER JOIN Clientes C on O.IdCliente = C.IdCliente INNER JOIN Repartidores R ON O.IdRepartidor = R.IdRepartidor INNER JOIN DetalleOrden Dt ON O.IdOrden = Dt.IdOrden GROUP BY O.IdOrden, C.NombreCliente, R.Nombre, O.Fecha, O.Estado, O.Total";
            FillDataGrid(query);
        }

        private void FillDataGrid(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvConsultas.DataSource = dt;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            string desde = dtpDesde.Value.ToString("yyyy/MM/dd");
            string hasta = dtpHasta.Value.ToString("yyyy/MM/dd");

            if (radioGeneral.Checked)
            {
                var strings = query.Split("GROUP");
                string r = strings[0].ToString() + $" WHERE O.Fecha BETWEEN '{desde}' AND '{hasta}' GROUP " + strings[1].ToString();
                FillDataGrid(r);
                return;
            }

            else
            {

            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            query = ConsultaIndividual(txtConsultas.Text);
            MessageBox.Show(query);
            FillDataGrid(query);
        }

        private string ConsultaIndividual(string filtro)
        {
            if (filtro.Equals("Consulta de Clientes"))
            {
                return $"SELECT C.IdCliente, C.NombreCliente, C.DireccionCliente, C.TelefonoCliente, COUNT(O.IdCliente) AS Ordenes FROM Clientes C LEFT JOIN Ordenes O ON O.IdCliente = C.IdCliente WHERE C.NombreCliente = '{cboConsulta.Text}' GROUP BY C.IdCliente, C.NombreCliente, C.DireccionCliente, C.TelefonoCliente";
            }
            else if (filtro.Equals("Consulta de Repartidores"))
            {
                return $"SELECT R.IdRepartidor, R.Nombre AS NombreRepartidor, R.Telefono, R.Vehiculo, COUNT(O.IdOrden) AS TotalOrdenes FROM Repartidores R LEFT JOIN Ordenes O ON O.IdRepartidor = R.IdRepartidor WHERE R.Nombre = '{cboConsulta.Text}' GROUP BY R.IdRepartidor, R.Nombre, R.Telefono, R.Vehiculo;";
            }

            return $"SELECT M.IdPlatillo, M.Concepto, M.Precio, COUNT(Dt.IdPlatillo) AS VecesPedido FROM MenuPlatillos M LEFT JOIN DetalleOrden Dt ON M.IdPlatillo = Dt.IdPlatillo WHERE M.Concepto = '{cboConsulta.Text}' GROUP BY M.IdPlatillo, M.Concepto, M.Precio";
        }

        private void FillComboBox(string query)
        {
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            cboConsulta.Items.Clear();
            while (reader.Read())
            {
                cboConsulta.Items.Add(reader.GetValue(0));
            }
            cboConsulta.SelectedIndex = 0;
            reader.Close();
        }

        private void checkConIndividual_CheckedChanged(object sender, EventArgs e)
        {
            if (checkConIndividual.Checked)
            {
                cboConsulta.Enabled = true;
                cmdAceptar.Enabled = true;
                cboConsulta.SelectedIndex = 0;
            }
            else
            {
                cboConsulta.Enabled = false;
                cmdAceptar.Enabled = false;
            }
        }

        private void checkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkFecha.Checked)
            {
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
                cmdOk.Enabled = false;
            }
            else
            {
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
                cmdOk.Enabled = true;
            }
        }

        private void radioGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGeneral.Checked)
            {
                query = "SELECT O.IdOrden, C.NombreCliente, R.Nombre as NombreRepartidor, O.Fecha, O.Estado, O.Total, COUNT(DISTINCT Dt.IdPlatillo) as VariedadPlatillos FROM Ordenes O INNER JOIN Clientes C on O.IdCliente = C.IdCliente INNER JOIN Repartidores R ON O.IdRepartidor = R.IdRepartidor INNER JOIN DetalleOrden Dt ON O.IdOrden = Dt.IdOrden GROUP BY O.IdOrden, C.NombreCliente, R.Nombre, O.Fecha, O.Estado, O.Total";
                FillDataGrid(query);
                checkConIndividual.Enabled = false;
                checkConIndividual.Checked = false;
                txtConsultas.Text = "Consulta General";
            }
            else if (radioCliente.Checked)
            {
                query = "SELECT C.IdCliente, C.NombreCliente, C.DireccionCliente, C.TelefonoCliente, COUNT(O.IdCliente) AS Ordenes FROM Clientes C LEFT JOIN Ordenes O ON O.IdCliente = C.IdCliente GROUP BY C.IdCliente, C.NombreCliente, C.DireccionCliente, C.TelefonoCliente";
                FillDataGrid(query);
                checkConIndividual.Enabled = true;
                FillComboBox("SELECT NombreCliente FROM Clientes");
                txtConsultas.Text = "Consulta de Clientes";
            }
            else if (radioRepartidor.Checked)
            {
                query = "SELECT      R.IdRepartidor,      R.Nombre AS NombreRepartidor,      R.Telefono,      R.Vehiculo,      COUNT(O.IdOrden) AS TotalOrdenes FROM Repartidores R LEFT JOIN Ordenes O ON O.IdRepartidor = R.IdRepartidor GROUP BY R.IdRepartidor, R.Nombre, R.Telefono, R.Vehiculo;";
                FillDataGrid(query);
                checkConIndividual.Enabled = true;
                FillComboBox("SELECT Nombre FROM Repartidores");
                txtConsultas.Text = "Consulta de Repartidores";
            }
            else
            {
                query = "SELECT M.IdPlatillo, M.Concepto, M.Precio, COUNT(Dt.IdPlatillo) AS VecesPedido FROM MenuPlatillos M LEFT JOIN DetalleOrden Dt ON M.IdPlatillo = Dt.IdPlatillo GROUP BY M.IdPlatillo, M.Concepto, M.Precio";
                FillDataGrid(query);
                checkConIndividual.Enabled = true;
                FillComboBox("SELECT Concepto FROM MenuPlatillos");
                txtConsultas.Text = "Consulta de Menú";
            }
        }

        private void radioCliente_CheckedChanged(object sender, EventArgs e)
        {
            radioGeneral_CheckedChanged(sender, e);
        }

        private void radioRepartidor_CheckedChanged(object sender, EventArgs e)
        {
            radioGeneral_CheckedChanged(sender, e);
        }
    }
}

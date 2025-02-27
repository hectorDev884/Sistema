namespace Sistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Menu"] == null)
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                Application.OpenForms["Menu"].Focus();
            }
        }

        private void cmdRepartidores_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Repartidores"] == null)
            {
                Repartidores rep = new Repartidores();
                rep.Show();
            }
            else
            {
                Application.OpenForms["Repartidores"].Focus();
            }
        }

        private void cmdClientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Cliente"] == null)
            {
                Cliente rep = new Cliente();
                rep.Show();
            }
            else
            {
                Application.OpenForms["Cliente"].Focus();
            }
        }

        private void cmdRegPedido_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Ordenes"] == null)
            {
                Ordenes rep = new Ordenes();
                rep.Show();
            }
            else
            {
                Application.OpenForms["Ordenes"].Focus();
            }
        }
    }
}

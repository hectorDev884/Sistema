namespace Sistema
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvClientes = new DataGridView();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            txtIdCliente = new TextBox();
            cmdGrabar = new Button();
            cmdModificar = new Button();
            cmdSalir = new Button();
            cmdNuevo = new Button();
            label5 = new Label();
            cmdCancelar = new Button();
            cmdBuscar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(34, 34, 34);
            label1.Location = new Point(69, 101);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 0;
            label1.Text = "IdCliente:";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(34, 34, 34);
            label2.Location = new Point(55, 187);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(34, 34, 34);
            label3.Location = new Point(42, 284);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 2;
            label3.Text = "Dirección:";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(34, 34, 34);
            label4.Location = new Point(59, 400);
            label4.Name = "label4";
            label4.Size = new Size(111, 31);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";

            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(532, 101);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(510, 538);
            dgvClientes.TabIndex = 4;

            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(181, 290);
            txtDireccion.MaxLength = 200;
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(317, 59);
            txtDireccion.TabIndex = 5;

            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(181, 400);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(286, 27);
            txtTelefono.TabIndex = 6;

            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 191);
            txtNombre.MaxLength = 200;
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 71);
            txtNombre.TabIndex = 7;

            // 
            // txtIdCliente
            // 
            txtIdCliente.Enabled = false;
            txtIdCliente.Location = new Point(181, 107);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(185, 27);
            txtIdCliente.TabIndex = 8;

            // 
            // cmdGrabar
            // 
            cmdGrabar.Enabled = false;
            cmdGrabar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmdGrabar.BackColor = Color.FromArgb(67, 159, 117);
            cmdGrabar.ForeColor = Color.White;
            cmdGrabar.FlatStyle = FlatStyle.Flat;
            cmdGrabar.FlatAppearance.BorderSize = 0;
            cmdGrabar.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 167, 122);
            cmdGrabar.Location = new Point(199, 523);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(131, 55);
            cmdGrabar.TabIndex = 16;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = false;
            cmdGrabar.Click += cmdGrabar_Click;

            // 
            // cmdModificar
            // 
            cmdModificar.Enabled = false;
            cmdModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmdModificar.BackColor = Color.FromArgb(67, 159, 117);
            cmdModificar.ForeColor = Color.White;
            cmdModificar.FlatStyle = FlatStyle.Flat;
            cmdModificar.FlatAppearance.BorderSize = 0;
            cmdModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 167, 122);
            cmdModificar.Location = new Point(336, 523);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(131, 55);
            cmdModificar.TabIndex = 15;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = false;
            cmdModificar.Click += cmdModificar_Click;

            // 
            // cmdSalir
            // 
            cmdSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmdSalir.BackColor = Color.FromArgb(98, 129, 155);
            cmdSalir.ForeColor = Color.White;
            cmdSalir.FlatStyle = FlatStyle.Flat;
            cmdSalir.FlatAppearance.BorderSize = 0;
            cmdSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 109, 137);
            cmdSalir.Location = new Point(59, 585);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(131, 55);
            cmdSalir.TabIndex = 14;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = false;
            cmdSalir.Click += cmdSalir_Click;

            // 
            // cmdNuevo
            // 
            cmdNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmdNuevo.BackColor = Color.FromArgb(98, 129, 155);
            cmdNuevo.ForeColor = Color.White;
            cmdNuevo.FlatStyle = FlatStyle.Flat;
            cmdNuevo.FlatAppearance.BorderSize = 0;
            cmdNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 109, 137);
            cmdNuevo.Location = new Point(57, 523);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(131, 55);
            cmdNuevo.TabIndex = 13;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = false;
            cmdNuevo.Click += cmdNuevo_Click;

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(34, 34, 34);
            label5.Location = new Point(453, 27);
            label5.Name = "label5";
            label5.Size = new Size(166, 50);
            label5.TabIndex = 17;
            label5.Text = "Clientes";

            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmdCancelar.BackColor = Color.FromArgb(98, 129, 155);
            cmdCancelar.ForeColor = Color.White;
            cmdCancelar.FlatStyle = FlatStyle.Flat;
            cmdCancelar.FlatAppearance.BorderSize = 0;
            cmdCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 109, 137);
            cmdCancelar.Location = new Point(199, 584);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(131, 55);
            cmdCancelar.TabIndex = 18;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = false;
            cmdCancelar.Click += cmdCancelar_Click;

            // 
            // cmdBuscar
            // 
            cmdBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmdBuscar.BackColor = Color.FromArgb(98, 129, 155);
            cmdBuscar.ForeColor = Color.White;
            cmdBuscar.FlatStyle = FlatStyle.Flat;
            cmdBuscar.FlatAppearance.BorderSize = 0;
            cmdBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 109, 137);
            cmdBuscar.Location = new Point(336, 584);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(131, 55);
            cmdBuscar.TabIndex = 19;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = false;
            cmdBuscar.Click += cmdBuscar_Click;

            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1064, 652);
            Controls.Add(cmdBuscar);
            Controls.Add(cmdCancelar);
            Controls.Add(label5);
            Controls.Add(cmdGrabar);
            Controls.Add(cmdModificar);
            Controls.Add(cmdSalir);
            Controls.Add(cmdNuevo);
            Controls.Add(txtIdCliente);
            Controls.Add(txtNombre);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(dgvClientes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cliente";
            Text = "Clientes";
            Load += Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvClientes;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private TextBox txtIdCliente;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button cmdGrabar;
        private Button cmdModificar;
        private Button cmdSalir;
        private Button cmdNuevo;
        private Label label5;
        private Button cmdCancelar;
        private Button cmdBuscar;
    }
}
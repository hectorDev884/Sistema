namespace Sistema
{
    partial class Ordenes
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
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            txtTelefonoCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            txtIdCliente = new TextBox();
            cbxCliente = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            txtCantidad = new TextBox();
            label19 = new Label();
            txtPrecioMenu = new TextBox();
            label6 = new Label();
            txtDescripcionMenu = new TextBox();
            txtIdPlatillo = new TextBox();
            label18 = new Label();
            label15 = new Label();
            label17 = new Label();
            cbxPlatillo = new ComboBox();
            label16 = new Label();
            panel3 = new Panel();
            txtVehiculoRep = new TextBox();
            label4 = new Label();
            txtTelefonoRep = new TextBox();
            txtIdRep = new TextBox();
            label14 = new Label();
            cbxRepartidor = new ComboBox();
            label13 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtNumPedido = new TextBox();
            txtFecha = new TextBox();
            dgvOrden = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Repartidor = new DataGridViewTextBoxColumn();
            Platillo = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            IVA = new DataGridViewTextBoxColumn();
            cmdNuevo = new Button();
            cmdGrabar = new Button();
            cmdCancelar = new Button();
            cmdSalir = new Button();
            cmdOK = new Button();
            txtTotal = new TextBox();
            label20 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrden).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 19.8000011F, FontStyle.Bold);
            label5.Location = new Point(51, 9);
            label5.Name = "label5";
            label5.Size = new Size(291, 40);
            label5.TabIndex = 17;
            label5.Text = "Registrar Pedido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(418, 31);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 18;
            label1.Text = "Numero de pedido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(540, 64);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 19;
            label2.Text = "Fecha:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(txtTelefonoCliente);
            panel1.Controls.Add(txtDireccionCliente);
            panel1.Controls.Add(txtIdCliente);
            panel1.Controls.Add(cbxCliente);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(49, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 130);
            panel1.TabIndex = 20;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Enabled = false;
            txtTelefonoCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtTelefonoCliente.Location = new Point(913, 54);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(236, 27);
            txtTelefonoCliente.TabIndex = 8;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Enabled = false;
            txtDireccionCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtDireccionCliente.Location = new Point(612, 54);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(187, 27);
            txtDireccionCliente.TabIndex = 7;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Enabled = false;
            txtIdCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtIdCliente.Location = new Point(339, 54);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(169, 27);
            txtIdCliente.TabIndex = 6;
            // 
            // cbxCliente
            // 
            cbxCliente.Enabled = false;
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(111, 54);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(182, 28);
            cbxCliente.TabIndex = 5;
            cbxCliente.SelectedIndexChanged += cbxCliente_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(527, 59);
            label10.Name = "label10";
            label10.Size = new Size(85, 23);
            label10.TabIndex = 4;
            label10.Text = "Direccion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(826, 58);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 3;
            label9.Text = "Telefono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(304, 59);
            label8.Name = "label8";
            label8.Size = new Size(29, 23);
            label8.TabIndex = 2;
            label8.Text = "Id:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(35, 59);
            label7.Name = "label7";
            label7.Size = new Size(67, 23);
            label7.TabIndex = 1;
            label7.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 10);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 0;
            label3.Text = "Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(txtPrecioMenu);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtDescripcionMenu);
            panel2.Controls.Add(txtIdPlatillo);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(cbxPlatillo);
            panel2.Controls.Add(label16);
            panel2.Location = new Point(49, 424);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 151);
            panel2.TabIndex = 21;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(913, 103);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(236, 27);
            txtCantidad.TabIndex = 26;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(826, 107);
            label19.Name = "label19";
            label19.Size = new Size(79, 23);
            label19.TabIndex = 25;
            label19.Text = "Cantidad";
            // 
            // txtPrecioMenu
            // 
            txtPrecioMenu.Enabled = false;
            txtPrecioMenu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtPrecioMenu.Location = new Point(913, 54);
            txtPrecioMenu.Name = "txtPrecioMenu";
            txtPrecioMenu.Size = new Size(236, 27);
            txtPrecioMenu.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 10);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 2;
            label6.Text = "Menú";
            // 
            // txtDescripcionMenu
            // 
            txtDescripcionMenu.Enabled = false;
            txtDescripcionMenu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtDescripcionMenu.Location = new Point(635, 58);
            txtDescripcionMenu.Multiline = true;
            txtDescripcionMenu.Name = "txtDescripcionMenu";
            txtDescripcionMenu.Size = new Size(185, 72);
            txtDescripcionMenu.TabIndex = 23;
            // 
            // txtIdPlatillo
            // 
            txtIdPlatillo.Enabled = false;
            txtIdPlatillo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtIdPlatillo.Location = new Point(339, 54);
            txtIdPlatillo.Name = "txtIdPlatillo";
            txtIdPlatillo.Size = new Size(169, 27);
            txtIdPlatillo.TabIndex = 22;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(826, 58);
            label18.Name = "label18";
            label18.Size = new Size(61, 23);
            label18.TabIndex = 19;
            label18.Text = "Precio:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(40, 59);
            label15.Name = "label15";
            label15.Size = new Size(65, 23);
            label15.TabIndex = 17;
            label15.Text = "Platillo:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(527, 59);
            label17.Name = "label17";
            label17.Size = new Size(102, 23);
            label17.TabIndex = 20;
            label17.Text = "Descripcion:";
            // 
            // cbxPlatillo
            // 
            cbxPlatillo.Enabled = false;
            cbxPlatillo.FormattingEnabled = true;
            cbxPlatillo.Location = new Point(111, 54);
            cbxPlatillo.Name = "cbxPlatillo";
            cbxPlatillo.Size = new Size(182, 28);
            cbxPlatillo.TabIndex = 21;
            cbxPlatillo.SelectedIndexChanged += cbxPlatillo_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(304, 59);
            label16.Name = "label16";
            label16.Size = new Size(29, 23);
            label16.TabIndex = 18;
            label16.Text = "Id:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(txtVehiculoRep);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtTelefonoRep);
            panel3.Controls.Add(txtIdRep);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(cbxRepartidor);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(49, 288);
            panel3.Name = "panel3";
            panel3.Size = new Size(1180, 130);
            panel3.TabIndex = 22;
            // 
            // txtVehiculoRep
            // 
            txtVehiculoRep.Enabled = false;
            txtVehiculoRep.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtVehiculoRep.Location = new Point(913, 58);
            txtVehiculoRep.Name = "txtVehiculoRep";
            txtVehiculoRep.Size = new Size(236, 27);
            txtVehiculoRep.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 12);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 1;
            label4.Text = "Repartidor";
            // 
            // txtTelefonoRep
            // 
            txtTelefonoRep.Enabled = false;
            txtTelefonoRep.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtTelefonoRep.Location = new Point(612, 58);
            txtTelefonoRep.Name = "txtTelefonoRep";
            txtTelefonoRep.Size = new Size(187, 27);
            txtTelefonoRep.TabIndex = 15;
            // 
            // txtIdRep
            // 
            txtIdRep.Enabled = false;
            txtIdRep.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtIdRep.Location = new Point(339, 58);
            txtIdRep.Name = "txtIdRep";
            txtIdRep.Size = new Size(169, 27);
            txtIdRep.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(9, 58);
            label14.Name = "label14";
            label14.Size = new Size(96, 23);
            label14.TabIndex = 9;
            label14.Text = "Repartidor:";
            // 
            // cbxRepartidor
            // 
            cbxRepartidor.Enabled = false;
            cbxRepartidor.FormattingEnabled = true;
            cbxRepartidor.Location = new Point(111, 58);
            cbxRepartidor.Name = "cbxRepartidor";
            cbxRepartidor.Size = new Size(182, 28);
            cbxRepartidor.TabIndex = 13;
            cbxRepartidor.SelectedIndexChanged += cbxRepartidor_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(304, 63);
            label13.Name = "label13";
            label13.Size = new Size(29, 23);
            label13.TabIndex = 10;
            label13.Text = "Id:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(527, 63);
            label11.Name = "label11";
            label11.Size = new Size(79, 23);
            label11.TabIndex = 12;
            label11.Text = "Telefono:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(832, 63);
            label12.Name = "label12";
            label12.Size = new Size(79, 23);
            label12.TabIndex = 11;
            label12.Text = "Vehiculo:";
            // 
            // txtNumPedido
            // 
            txtNumPedido.Enabled = false;
            txtNumPedido.Location = new Point(615, 35);
            txtNumPedido.Name = "txtNumPedido";
            txtNumPedido.Size = new Size(233, 27);
            txtNumPedido.TabIndex = 9;
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(615, 68);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(233, 27);
            txtFecha.TabIndex = 23;
            // 
            // dgvOrden
            // 
            dgvOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrden.Columns.AddRange(new DataGridViewColumn[] { Cliente, Repartidor, Platillo, Precio, Cantidad, Importe, IVA });
            dgvOrden.Location = new Point(157, 595);
            dgvOrden.Name = "dgvOrden";
            dgvOrden.ReadOnly = true;
            dgvOrden.RowHeadersWidth = 51;
            dgvOrden.Size = new Size(950, 161);
            dgvOrden.TabIndex = 24;
            dgvOrden.CellContentClick += dgvOrden_CellContentClick;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // Repartidor
            // 
            Repartidor.HeaderText = "Repartidor";
            Repartidor.MinimumWidth = 6;
            Repartidor.Name = "Repartidor";
            Repartidor.ReadOnly = true;
            // 
            // Platillo
            // 
            Platillo.HeaderText = "Platillo";
            Platillo.MinimumWidth = 6;
            Platillo.Name = "Platillo";
            Platillo.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Importe
            // 
            Importe.HeaderText = "Importe";
            Importe.MinimumWidth = 6;
            Importe.Name = "Importe";
            Importe.ReadOnly = true;
            // 
            // IVA
            // 
            IVA.HeaderText = "IVA";
            IVA.MinimumWidth = 6;
            IVA.Name = "IVA";
            IVA.ReadOnly = true;
            // 
            // cmdNuevo
            // 
            cmdNuevo.BackColor = SystemColors.ActiveCaption;
            cmdNuevo.Cursor = Cursors.Hand;
            cmdNuevo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdNuevo.Location = new Point(389, 789);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(105, 59);
            cmdNuevo.TabIndex = 25;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = false;
            cmdNuevo.Click += cmdNuevo_Click;
            // 
            // cmdGrabar
            // 
            cmdGrabar.BackColor = Color.LightGreen;
            cmdGrabar.Cursor = Cursors.Hand;
            cmdGrabar.Enabled = false;
            cmdGrabar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdGrabar.Location = new Point(540, 789);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(105, 59);
            cmdGrabar.TabIndex = 26;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = false;
            cmdGrabar.Click += cmdGrabar_Click;
            // 
            // cmdCancelar
            // 
            cmdCancelar.BackColor = SystemColors.ActiveCaption;
            cmdCancelar.Cursor = Cursors.Hand;
            cmdCancelar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCancelar.Location = new Point(692, 789);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(105, 59);
            cmdCancelar.TabIndex = 27;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = false;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.BackColor = Color.IndianRed;
            cmdSalir.Cursor = Cursors.Hand;
            cmdSalir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdSalir.Location = new Point(839, 789);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(105, 59);
            cmdSalir.TabIndex = 28;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = false;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdOK
            // 
            cmdOK.BackColor = Color.LightGreen;
            cmdOK.Cursor = Cursors.Hand;
            cmdOK.Enabled = false;
            cmdOK.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdOK.Location = new Point(1158, 637);
            cmdOK.Name = "cmdOK";
            cmdOK.Size = new Size(105, 59);
            cmdOK.TabIndex = 29;
            cmdOK.Text = "OK";
            cmdOK.UseVisualStyleBackColor = false;
            cmdOK.Click += cmdOK_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtTotal.Location = new Point(1060, 780);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(169, 27);
            txtTotal.TabIndex = 10;
            txtTotal.Text = "0";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(1004, 784);
            label20.Name = "label20";
            label20.Size = new Size(50, 23);
            label20.TabIndex = 9;
            label20.Text = "Total:";
            // 
            // Ordenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1268, 860);
            Controls.Add(txtTotal);
            Controls.Add(label20);
            Controls.Add(cmdOK);
            Controls.Add(cmdSalir);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdGrabar);
            Controls.Add(cmdNuevo);
            Controls.Add(dgvOrden);
            Controls.Add(txtFecha);
            Controls.Add(txtNumPedido);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "Ordenes";
            Text = "Registrar Pedido";
            Load += Ordenes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrden).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox cbxCliente;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label4;
        private TextBox txtTelefonoCliente;
        private TextBox txtDireccionCliente;
        private TextBox txtIdCliente;
        private TextBox txtPrecioMenu;
        private TextBox txtDescripcionMenu;
        private TextBox txtIdPlatillo;
        private Label label18;
        private Label label15;
        private Label label17;
        private ComboBox cbxPlatillo;
        private Label label16;
        private TextBox txtVehiculoRep;
        private TextBox txtTelefonoRep;
        private TextBox txtIdRep;
        private Label label14;
        private ComboBox cbxRepartidor;
        private Label label13;
        private Label label11;
        private Label label12;
        private TextBox txtNumPedido;
        private TextBox txtFecha;
        private TextBox txtCantidad;
        private Label label19;
        private DataGridView dgvOrden;
        private Button cmdNuevo;
        private Button cmdGrabar;
        private Button cmdCancelar;
        private Button cmdSalir;
        private Button cmdOK;
        private TextBox txtTotal;
        private Label label20;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Repartidor;
        private DataGridViewTextBoxColumn Platillo;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Importe;
        private DataGridViewTextBoxColumn IVA;
    }
}
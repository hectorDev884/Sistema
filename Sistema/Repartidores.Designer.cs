namespace Sistema
{
    partial class Repartidores
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
            dgvRepartidores = new DataGridView();
            txtVehiculo = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            txtIdRepartidor = new TextBox();
            cmdCancelar = new Button();
            cmdBuscar = new Button();
            cmdGrabar = new Button();
            cmdModificar = new Button();
            cmdSalir = new Button();
            cmdNuevo = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRepartidores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 101);
            label1.Name = "label1";
            label1.Size = new Size(154, 31);
            label1.TabIndex = 0;
            label1.Text = "IdRepartidor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 180);
            label2.Name = "label2";
            label2.Size = new Size(107, 31);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 245);
            label3.Name = "label3";
            label3.Size = new Size(109, 31);
            label3.TabIndex = 2;
            label3.Text = "Vehículo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 332);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            // 
            // dgvRepartidores
            // 
            dgvRepartidores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRepartidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepartidores.Location = new Point(527, 107);
            dgvRepartidores.Name = "dgvRepartidores";
            dgvRepartidores.ReadOnly = true;
            dgvRepartidores.RowHeadersWidth = 51;
            dgvRepartidores.Size = new Size(529, 422);
            dgvRepartidores.TabIndex = 4;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Enabled = false;
            txtVehiculo.Location = new Point(141, 251);
            txtVehiculo.MaxLength = 200;
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(218, 27);
            txtVehiculo.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(143, 338);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(286, 27);
            txtTelefono.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(138, 184);
            txtNombre.MaxLength = 200;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtIdRepartidor
            // 
            txtIdRepartidor.Enabled = false;
            txtIdRepartidor.Location = new Point(194, 107);
            txtIdRepartidor.Name = "txtIdRepartidor";
            txtIdRepartidor.Size = new Size(185, 27);
            txtIdRepartidor.TabIndex = 8;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCancelar.Location = new Point(218, 486);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(131, 55);
            cmdCancelar.TabIndex = 9;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdBuscar.Location = new Point(372, 486);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(131, 55);
            cmdBuscar.TabIndex = 12;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // cmdGrabar
            // 
            cmdGrabar.Cursor = Cursors.Hand;
            cmdGrabar.Enabled = false;
            cmdGrabar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdGrabar.Location = new Point(218, 412);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(131, 55);
            cmdGrabar.TabIndex = 16;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = true;
            cmdGrabar.Click += cmdGrabar_Click;
            // 
            // cmdModificar
            // 
            cmdModificar.Enabled = false;
            cmdModificar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdModificar.Location = new Point(372, 412);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(131, 55);
            cmdModificar.TabIndex = 15;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            cmdModificar.Click += cmdModificar_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Cursor = Cursors.Hand;
            cmdSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdSalir.Location = new Point(52, 486);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(131, 55);
            cmdSalir.TabIndex = 14;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdNuevo
            // 
            cmdNuevo.Cursor = Cursors.Hand;
            cmdNuevo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdNuevo.Location = new Point(52, 412);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(131, 55);
            cmdNuevo.TabIndex = 13;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = true;
            cmdNuevo.Click += cmdNuevo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 19.8000011F, FontStyle.Bold);
            label5.Location = new Point(402, 20);
            label5.Name = "label5";
            label5.Size = new Size(229, 40);
            label5.TabIndex = 17;
            label5.Text = "Repartidores";
            // 
            // Repartidores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1068, 566);
            Controls.Add(label5);
            Controls.Add(cmdGrabar);
            Controls.Add(cmdModificar);
            Controls.Add(cmdSalir);
            Controls.Add(cmdNuevo);
            Controls.Add(cmdBuscar);
            Controls.Add(cmdCancelar);
            Controls.Add(txtIdRepartidor);
            Controls.Add(txtNombre);
            Controls.Add(txtTelefono);
            Controls.Add(txtVehiculo);
            Controls.Add(dgvRepartidores);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Repartidores";
            Text = "Repartidores";
            Load += Repartidores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRepartidores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvRepartidores;
        private TextBox txtVehiculo;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private TextBox txtIdRepartidor;
        private Button button1;
        private Button cmdCancelar;
        private Button button3;
        private Button cmdBuscar;
        private Button cmdGrabar;
        private Button cmdModificar;
        private Button cmdSalir;
        private Button cmdNuevo;
        private Label label5;
    }
}
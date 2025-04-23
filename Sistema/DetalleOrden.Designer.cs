namespace Sistema
{
    partial class DetalleOrden
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
            txtIdOrden = new TextBox();
            cmdSalir = new Button();
            nOrden = new Label();
            label3 = new Label();
            dgvDetalleOrden = new DataGridView();
            txtFecha = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txtRepartidor = new TextBox();
            txtVehiculoRep = new TextBox();
            label4 = new Label();
            txtTelefonoRep = new TextBox();
            txtIdRep = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            txtCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            txtIdCliente = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtSubTotal = new TextBox();
            txtTotal = new TextBox();
            label6 = new Label();
            label15 = new Label();
            txtEstado = new TextBox();
            label16 = new Label();
            cmdCancelar = new Button();
            cmdSurtir = new Button();
            cmdPagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleOrden).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 92);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 0;
            label1.Text = "IdOrden:";
            // 
            // txtIdOrden
            // 
            txtIdOrden.Enabled = false;
            txtIdOrden.Location = new Point(241, 96);
            txtIdOrden.Name = "txtIdOrden";
            txtIdOrden.Size = new Size(185, 27);
            txtIdOrden.TabIndex = 8;
            // 
            // cmdSalir
            // 
            cmdSalir.BackColor = Color.Firebrick;
            cmdSalir.Cursor = Cursors.Hand;
            cmdSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdSalir.ForeColor = Color.White;
            cmdSalir.Location = new Point(1024, 77);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(131, 55);
            cmdSalir.TabIndex = 14;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = false;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // nOrden
            // 
            nOrden.AutoSize = true;
            nOrden.Font = new Font("Arial", 22F, FontStyle.Bold);
            nOrden.Location = new Point(415, 9);
            nOrden.Name = "nOrden";
            nOrden.Size = new Size(160, 44);
            nOrden.TabIndex = 17;
            nOrden.Text = "Orden #";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 22F, FontStyle.Bold);
            label3.Location = new Point(41, 415);
            label3.Name = "label3";
            label3.Size = new Size(309, 44);
            label3.TabIndex = 19;
            label3.Text = "Detalle de orden";
            // 
            // dgvDetalleOrden
            // 
            dgvDetalleOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleOrden.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvDetalleOrden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleOrden.Location = new Point(41, 472);
            dgvDetalleOrden.Name = "dgvDetalleOrden";
            dgvDetalleOrden.ReadOnly = true;
            dgvDetalleOrden.RowHeadersWidth = 51;
            dgvDetalleOrden.Size = new Size(1180, 252);
            dgvDetalleOrden.TabIndex = 20;
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(535, 96);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(185, 27);
            txtFecha.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(445, 92);
            label2.Name = "label2";
            label2.Size = new Size(80, 31);
            label2.TabIndex = 21;
            label2.Text = "Fecha:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(txtRepartidor);
            panel3.Controls.Add(txtVehiculoRep);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtTelefonoRep);
            panel3.Controls.Add(txtIdRep);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(41, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(1180, 130);
            panel3.TabIndex = 24;
            // 
            // txtRepartidor
            // 
            txtRepartidor.Enabled = false;
            txtRepartidor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtRepartidor.Location = new Point(337, 59);
            txtRepartidor.Name = "txtRepartidor";
            txtRepartidor.Size = new Size(169, 27);
            txtRepartidor.TabIndex = 10;
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
            txtIdRep.Location = new Point(60, 58);
            txtIdRep.Name = "txtIdRep";
            txtIdRep.Size = new Size(169, 27);
            txtIdRep.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(235, 58);
            label14.Name = "label14";
            label14.Size = new Size(96, 23);
            label14.TabIndex = 9;
            label14.Text = "Repartidor:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(25, 63);
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
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(txtCliente);
            panel1.Controls.Add(txtTelefonoCliente);
            panel1.Controls.Add(txtDireccionCliente);
            panel1.Controls.Add(txtIdCliente);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(41, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 130);
            panel1.TabIndex = 23;
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtCliente.Location = new Point(336, 54);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(169, 27);
            txtCliente.TabIndex = 9;
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
            txtIdCliente.Location = new Point(88, 54);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(169, 27);
            txtIdCliente.TabIndex = 6;
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
            label8.Location = new Point(53, 59);
            label8.Name = "label8";
            label8.Size = new Size(29, 23);
            label8.TabIndex = 2;
            label8.Text = "Id:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(263, 55);
            label7.Name = "label7";
            label7.Size = new Size(67, 23);
            label7.TabIndex = 1;
            label7.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 10);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 0;
            label5.Text = "Cliente";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Enabled = false;
            txtSubTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtSubTotal.Location = new Point(777, 423);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(169, 27);
            txtSubTotal.TabIndex = 17;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(1052, 423);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(169, 27);
            txtTotal.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(669, 423);
            label6.Name = "label6";
            label6.Size = new Size(108, 31);
            label6.TabIndex = 26;
            label6.Text = "Subtotal:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(966, 423);
            label15.Name = "label15";
            label15.Size = new Size(71, 31);
            label15.TabIndex = 27;
            label15.Text = "Total:";
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(912, 94);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(47, 27);
            txtEstado.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(816, 90);
            label16.Name = "label16";
            label16.Size = new Size(90, 31);
            label16.TabIndex = 28;
            label16.Text = "Estado:";
            // 
            // cmdCancelar
            // 
            cmdCancelar.BackColor = Color.FromArgb(67, 159, 117);
            cmdCancelar.Cursor = Cursors.Hand;
            cmdCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCancelar.ForeColor = Color.White;
            cmdCancelar.Location = new Point(377, 759);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(131, 55);
            cmdCancelar.TabIndex = 30;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = false;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // cmdSurtir
            // 
            cmdSurtir.BackColor = Color.FromArgb(98, 129, 155);
            cmdSurtir.Cursor = Cursors.Hand;
            cmdSurtir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdSurtir.ForeColor = Color.White;
            cmdSurtir.Location = new Point(546, 759);
            cmdSurtir.Name = "cmdSurtir";
            cmdSurtir.Size = new Size(131, 55);
            cmdSurtir.TabIndex = 31;
            cmdSurtir.Text = "Surtir";
            cmdSurtir.UseVisualStyleBackColor = false;
            cmdSurtir.Click += cmdSurtir_Click;
            // 
            // cmdPagar
            // 
            cmdPagar.BackColor = Color.FromArgb(67, 159, 117);
            cmdPagar.Cursor = Cursors.Hand;
            cmdPagar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdPagar.ForeColor = Color.White;
            cmdPagar.Location = new Point(709, 759);
            cmdPagar.Name = "cmdPagar";
            cmdPagar.Size = new Size(131, 55);
            cmdPagar.TabIndex = 32;
            cmdPagar.Text = "Pagar";
            cmdPagar.UseVisualStyleBackColor = false;
            cmdPagar.Click += cmdPagar_Click;
            // 
            // DetalleOrden
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1256, 850);
            Controls.Add(cmdPagar);
            Controls.Add(cmdSurtir);
            Controls.Add(cmdCancelar);
            Controls.Add(txtEstado);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label6);
            Controls.Add(txtTotal);
            Controls.Add(txtSubTotal);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(txtFecha);
            Controls.Add(label2);
            Controls.Add(dgvDetalleOrden);
            Controls.Add(label3);
            Controls.Add(nOrden);
            Controls.Add(cmdSalir);
            Controls.Add(txtIdOrden);
            Controls.Add(label1);
            Name = "DetalleOrden";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Orden";
            Load += DetalleOrden_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleOrden).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdOrden;
        private Button cmdSalir;
        private Label nOrden;
        private Label label3;
        private DataGridView dgvDetalleOrden;
        private TextBox txtFecha;
        private Label label2;
        private Panel panel3;
        private TextBox txtRepartidor;
        private TextBox txtVehiculoRep;
        private Label label4;
        private TextBox txtTelefonoRep;
        private TextBox txtIdRep;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label12;
        private Panel panel1;
        private TextBox txtCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtDireccionCliente;
        private TextBox txtIdCliente;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextBox txtSubTotal;
        private TextBox txtTotal;
        private Label label6;
        private Label label15;
        private TextBox txtEstado;
        private Label label16;
        private Button cmdCancelar;
        private Button cmdSurtir;
        private Button cmdPagar;
    }
}
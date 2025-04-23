namespace Sistema
{
    partial class Menu
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
            //form 2
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvMenu = new DataGridView();
            txtDescripcion = new TextBox();
            txtConcepto = new TextBox();
            txtIdMenu = new TextBox();
            cmdCancelar = new Button();
            cmdGrabar = new Button();
            cmdModificar = new Button();
            cmdSalir = new Button();
            cmdNuevo = new Button();
            label5 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            cmdBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(34, 34, 34);
            label1.Location = new Point(69, 101);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 0;
            label1.Text = "IdMenu: ";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(34, 34, 34);
            label2.Location = new Point(55, 161);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 1;
            label2.Text = "Concepto:";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(34, 34, 34);
            label3.Location = new Point(54, 239);
            label3.Name = "label3";
            label3.Size = new Size(149, 31);
            label3.TabIndex = 2;
            label3.Text = "Descripción: ";

            // 
            // dgvMenu
            // 
            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Location = new Point(552, 107);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowHeadersWidth = 51;
            dgvMenu.Size = new Size(628, 470);
            dgvMenu.TabIndex = 4;

            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(218, 254);
            txtDescripcion.MaxLength = 200;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(274, 113);
            txtDescripcion.TabIndex = 5;

            // 
            // txtConcepto
            // 
            txtConcepto.Location = new Point(218, 167);
            txtConcepto.MaxLength = 200;
            txtConcepto.Multiline = true;
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(221, 71);
            txtConcepto.TabIndex = 7;

            // 
            // txtIdMenu
            // 
            txtIdMenu.Enabled = false;
            txtIdMenu.Location = new Point(218, 107);
            txtIdMenu.Name = "txtIdMenu";
            txtIdMenu.Size = new Size(185, 27);
            txtIdMenu.TabIndex = 8;

            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmdCancelar.BackColor = Color.FromArgb(98, 129, 155);
            cmdCancelar.ForeColor = Color.White;
            cmdCancelar.FlatStyle = FlatStyle.Flat;
            cmdCancelar.FlatAppearance.BorderSize = 0;
            cmdCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 109, 137);
            cmdCancelar.Location = new Point(238, 556);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(131, 55);
            cmdCancelar.TabIndex = 9;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = false;
            cmdCancelar.Click += cmdCancelar_Click;

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
            cmdGrabar.Location = new Point(238, 481);
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
            cmdModificar.Location = new Point(404, 481);
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
            cmdSalir.Location = new Point(72, 556);
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
            cmdNuevo.Location = new Point(72, 481);
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
            label5.Location = new Point(440, 25);
            label5.Name = "label5";
            label5.Size = new Size(317, 50);
            label5.TabIndex = 17;
            label5.Text = "Menú de Platillos";

            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(218, 398);
            txtPrecio.MaxLength = 200;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(221, 27);
            txtPrecio.TabIndex = 19;

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(34, 34, 34);
            label4.Location = new Point(69, 392);
            label4.Name = "label4";
            label4.Size = new Size(85, 31);
            label4.TabIndex = 18;
            label4.Text = "Precio:";

            // 
            // cmdBuscar
            // 
            cmdBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmdBuscar.BackColor = Color.FromArgb(98, 129, 155);
            cmdBuscar.ForeColor = Color.White;
            cmdBuscar.FlatStyle = FlatStyle.Flat;
            cmdBuscar.FlatAppearance.BorderSize = 0;
            cmdBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 109, 137);
            cmdBuscar.Location = new Point(404, 556);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(131, 55);
            cmdBuscar.TabIndex = 20;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = false;
            cmdBuscar.Click += cmdBuscar_Click;

            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1221, 634);
            Controls.Add(cmdBuscar);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(cmdGrabar);
            Controls.Add(cmdModificar);
            Controls.Add(cmdSalir);
            Controls.Add(cmdNuevo);
            Controls.Add(cmdCancelar);
            Controls.Add(txtIdMenu);
            Controls.Add(txtConcepto);
            Controls.Add(txtDescripcion);
            Controls.Add(dgvMenu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvMenu;
        private TextBox txtDescripcion;
        private TextBox txtConcepto;
        private TextBox txtIdMenu;
        private Button cmdCancelar;
        private Button cmdGrabar;
        private Button cmdModificar;
        private Button cmdSalir;
        private Button cmdNuevo;
        private Label label5;
        private TextBox txtPrecio;
        private Label label4;
        private Button cmdBuscar;
    }
}
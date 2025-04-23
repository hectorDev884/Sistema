namespace Sistema
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            cmdClientes = new Button();
            cmdMenu = new Button();
            cmdRepartidores = new Button();
            label1 = new Label();
            cmdRegPedido = new Button();
            cmdConsultas = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(34, 34, 34);
            label5.Location = new Point(232, 30);
            label5.Name = "label5";
            label5.Size = new Size(345, 50);
            label5.TabIndex = 35;
            label5.Text = "Menu de Opciones";
            // 
            // cmdClientes
            // 
            cmdClientes.BackColor = Color.FromArgb(98, 129, 155);
            cmdClientes.Cursor = Cursors.Hand;
            cmdClientes.FlatAppearance.BorderSize = 0;
            cmdClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 109, 137);
            cmdClientes.FlatStyle = FlatStyle.Flat;
            cmdClientes.Font = new Font("Segoe UI", 16F);
            cmdClientes.ForeColor = Color.White;
            cmdClientes.Location = new Point(176, 229);
            cmdClientes.Name = "cmdClientes";
            cmdClientes.Size = new Size(214, 137);
            cmdClientes.TabIndex = 36;
            cmdClientes.Text = "Clientes";
            cmdClientes.UseVisualStyleBackColor = false;
            cmdClientes.Click += cmdClientes_Click;
            // 
            // cmdMenu
            // 
            cmdMenu.BackColor = Color.FromArgb(98, 129, 155);
            cmdMenu.Cursor = Cursors.Hand;
            cmdMenu.FlatAppearance.BorderSize = 0;
            cmdMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 109, 137);
            cmdMenu.FlatStyle = FlatStyle.Flat;
            cmdMenu.Font = new Font("Segoe UI", 16F);
            cmdMenu.ForeColor = Color.White;
            cmdMenu.Location = new Point(667, 229);
            cmdMenu.Name = "cmdMenu";
            cmdMenu.Size = new Size(214, 137);
            cmdMenu.TabIndex = 38;
            cmdMenu.Text = "Menú";
            cmdMenu.UseVisualStyleBackColor = false;
            cmdMenu.Click += cmdMenu_Click;
            // 
            // cmdRepartidores
            // 
            cmdRepartidores.BackColor = Color.FromArgb(98, 129, 155);
            cmdRepartidores.Cursor = Cursors.Hand;
            cmdRepartidores.FlatAppearance.BorderSize = 0;
            cmdRepartidores.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 109, 137);
            cmdRepartidores.FlatStyle = FlatStyle.Flat;
            cmdRepartidores.Font = new Font("Segoe UI", 16F);
            cmdRepartidores.ForeColor = Color.White;
            cmdRepartidores.Location = new Point(415, 229);
            cmdRepartidores.Name = "cmdRepartidores";
            cmdRepartidores.Size = new Size(214, 137);
            cmdRepartidores.TabIndex = 37;
            cmdRepartidores.Text = "Repartidores";
            cmdRepartidores.UseVisualStyleBackColor = false;
            cmdRepartidores.Click += cmdRepartidores_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(34, 34, 34);
            label1.Location = new Point(429, 80);
            label1.Name = "label1";
            label1.Size = new Size(158, 41);
            label1.TabIndex = 39;
            label1.Text = "Catálogos";
            // 
            // cmdRegPedido
            // 
            cmdRegPedido.BackColor = Color.FromArgb(67, 159, 117);
            cmdRegPedido.Cursor = Cursors.Hand;
            cmdRegPedido.FlatAppearance.BorderSize = 0;
            cmdRegPedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 167, 122);
            cmdRegPedido.FlatStyle = FlatStyle.Flat;
            cmdRegPedido.Font = new Font("Segoe UI", 16F);
            cmdRegPedido.ForeColor = Color.White;
            cmdRegPedido.Location = new Point(291, 393);
            cmdRegPedido.Name = "cmdRegPedido";
            cmdRegPedido.Size = new Size(214, 137);
            cmdRegPedido.TabIndex = 40;
            cmdRegPedido.Text = "Registrar Pedido";
            cmdRegPedido.UseVisualStyleBackColor = false;
            cmdRegPedido.Click += cmdRegPedido_Click;
            // 
            // cmdConsultas
            // 
            cmdConsultas.BackColor = Color.FromArgb(67, 159, 117);
            cmdConsultas.Cursor = Cursors.Hand;
            cmdConsultas.FlatAppearance.BorderSize = 0;
            cmdConsultas.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 167, 122);
            cmdConsultas.FlatStyle = FlatStyle.Flat;
            cmdConsultas.Font = new Font("Segoe UI", 16F);
            cmdConsultas.ForeColor = Color.White;
            cmdConsultas.Location = new Point(557, 393);
            cmdConsultas.Name = "cmdConsultas";
            cmdConsultas.Size = new Size(214, 137);
            cmdConsultas.TabIndex = 41;
            cmdConsultas.Text = "Consultas";
            cmdConsultas.UseVisualStyleBackColor = false;
            cmdConsultas.Click += cmdConsultas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(996, 590);
            Controls.Add(cmdConsultas);
            Controls.Add(cmdRegPedido);
            Controls.Add(label1);
            Controls.Add(cmdMenu);
            Controls.Add(cmdRepartidores);
            Controls.Add(cmdClientes);
            Controls.Add(label5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button cmdClientes;
        private Button cmdMenu;
        private Button cmdRepartidores;
        private Label label1;
        private Button cmdRegPedido;
        private Button cmdConsultas;
    }
}

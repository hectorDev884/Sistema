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
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(232, -66);
            label5.Name = "label5";
            label5.Size = new Size(290, 40);
            label5.TabIndex = 35;
            label5.Text = "Menu de platillos";
            // 
            // cmdClientes
            // 
            cmdClientes.BackColor = SystemColors.Control;
            cmdClientes.Cursor = Cursors.Hand;
            cmdClientes.Font = new Font("Consolas", 16.2F);
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
            cmdMenu.BackColor = SystemColors.Control;
            cmdMenu.Cursor = Cursors.Hand;
            cmdMenu.Font = new Font("Consolas", 16.2F);
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
            cmdRepartidores.BackColor = SystemColors.Control;
            cmdRepartidores.Cursor = Cursors.Hand;
            cmdRepartidores.Font = new Font("Consolas", 16.2F);
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
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 68);
            label1.Name = "label1";
            label1.Size = new Size(154, 41);
            label1.TabIndex = 39;
            label1.Text = "Catálogos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(996, 590);
            Controls.Add(label1);
            Controls.Add(cmdMenu);
            Controls.Add(cmdRepartidores);
            Controls.Add(cmdClientes);
            Controls.Add(label5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button cmdClientes;
        private Button cmdMenu;
        private Button cmdRepartidores;
        private Label label1;
    }
}

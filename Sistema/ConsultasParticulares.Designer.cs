namespace Sistema
{
    partial class ConsultasParticulares
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
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioCliente = new RadioButton();
            radioRepartidor = new RadioButton();
            radioMenu = new RadioButton();
            radioGeneral = new RadioButton();
            dgvConsultas = new DataGridView();
            cmdAceptar = new Button();
            checkConIndividual = new CheckBox();
            groupBox2 = new GroupBox();
            cboConsulta = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            checkFecha = new CheckBox();
            txtConsultas = new Label();
            cmdOk = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(774, 154);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 0;
            label1.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Enabled = false;
            dtpDesde.Location = new Point(848, 154);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(250, 27);
            dtpDesde.TabIndex = 2;
            // 
            // dtpHasta
            // 
            dtpHasta.Enabled = false;
            dtpHasta.Location = new Point(848, 227);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(250, 27);
            dtpHasta.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(774, 227);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 3;
            label2.Text = "Hasta:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(radioCliente);
            groupBox1.Controls.Add(radioRepartidor);
            groupBox1.Controls.Add(radioMenu);
            groupBox1.Controls.Add(radioGeneral);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(48, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 306);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Por:";
            // 
            // radioCliente
            // 
            radioCliente.AutoSize = true;
            radioCliente.Location = new Point(37, 99);
            radioCliente.Name = "radioCliente";
            radioCliente.Size = new Size(96, 32);
            radioCliente.TabIndex = 3;
            radioCliente.Text = "Cliente";
            radioCliente.UseVisualStyleBackColor = true;
            radioCliente.CheckedChanged += radioCliente_CheckedChanged;
            // 
            // radioRepartidor
            // 
            radioRepartidor.AutoSize = true;
            radioRepartidor.Location = new Point(37, 157);
            radioRepartidor.Name = "radioRepartidor";
            radioRepartidor.Size = new Size(128, 32);
            radioRepartidor.TabIndex = 2;
            radioRepartidor.Text = "Repartidor";
            radioRepartidor.UseVisualStyleBackColor = true;
            radioRepartidor.CheckedChanged += radioRepartidor_CheckedChanged;
            // 
            // radioMenu
            // 
            radioMenu.AutoSize = true;
            radioMenu.Location = new Point(37, 214);
            radioMenu.Name = "radioMenu";
            radioMenu.Size = new Size(86, 32);
            radioMenu.TabIndex = 1;
            radioMenu.Text = "Menu";
            radioMenu.UseVisualStyleBackColor = true;
            // 
            // radioGeneral
            // 
            radioGeneral.AutoSize = true;
            radioGeneral.Checked = true;
            radioGeneral.Location = new Point(37, 52);
            radioGeneral.Name = "radioGeneral";
            radioGeneral.Size = new Size(103, 32);
            radioGeneral.TabIndex = 0;
            radioGeneral.TabStop = true;
            radioGeneral.Text = "General";
            radioGeneral.UseVisualStyleBackColor = true;
            radioGeneral.CheckedChanged += radioGeneral_CheckedChanged;
            // 
            // dgvConsultas
            // 
            dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Location = new Point(46, 472);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.RowHeadersWidth = 51;
            dgvConsultas.Size = new Size(1052, 190);
            dgvConsultas.TabIndex = 8;
            // 
            // cmdAceptar
            // 
            cmdAceptar.BackColor = Color.LimeGreen;
            cmdAceptar.Cursor = Cursors.Hand;
            cmdAceptar.Enabled = false;
            cmdAceptar.Location = new Point(217, 246);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(112, 54);
            cmdAceptar.TabIndex = 4;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = false;
            cmdAceptar.Click += cmdAceptar_Click;
            // 
            // checkConIndividual
            // 
            checkConIndividual.AutoSize = true;
            checkConIndividual.Enabled = false;
            checkConIndividual.Location = new Point(36, 53);
            checkConIndividual.Name = "checkConIndividual";
            checkConIndividual.Size = new Size(208, 32);
            checkConIndividual.TabIndex = 5;
            checkConIndividual.Text = "Consulta Individual";
            checkConIndividual.UseVisualStyleBackColor = true;
            checkConIndividual.CheckedChanged += checkConIndividual_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(cboConsulta);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(checkConIndividual);
            groupBox2.Controls.Add(cmdAceptar);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(400, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(346, 306);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Individual";
            // 
            // cboConsulta
            // 
            cboConsulta.Enabled = false;
            cboConsulta.FormattingEnabled = true;
            cboConsulta.Location = new Point(36, 153);
            cboConsulta.Name = "cboConsulta";
            cboConsulta.Size = new Size(293, 36);
            cboConsulta.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(36, 103);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 9;
            label3.Text = "Seleccione:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(497, 19);
            label4.Name = "label4";
            label4.Size = new Size(192, 40);
            label4.TabIndex = 9;
            label4.Text = "Consultas";
            // 
            // checkFecha
            // 
            checkFecha.AutoSize = true;
            checkFecha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkFecha.Location = new Point(774, 104);
            checkFecha.Name = "checkFecha";
            checkFecha.Size = new Size(250, 32);
            checkFecha.TabIndex = 11;
            checkFecha.Text = "Seleccionar por periodo";
            checkFecha.UseVisualStyleBackColor = true;
            checkFecha.CheckedChanged += checkFecha_CheckedChanged;
            // 
            // txtConsultas
            // 
            txtConsultas.AutoSize = true;
            txtConsultas.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConsultas.Location = new Point(48, 417);
            txtConsultas.Name = "txtConsultas";
            txtConsultas.Size = new Size(265, 32);
            txtConsultas.TabIndex = 12;
            txtConsultas.Text = "Consulta General";
            // 
            // cmdOk
            // 
            cmdOk.BackColor = Color.LimeGreen;
            cmdOk.Cursor = Cursors.Hand;
            cmdOk.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdOk.Location = new Point(1037, 296);
            cmdOk.Name = "cmdOk";
            cmdOk.Size = new Size(61, 54);
            cmdOk.TabIndex = 4;
            cmdOk.Text = "Ok";
            cmdOk.UseVisualStyleBackColor = false;
            cmdOk.Click += cmdOk_Click;
            // 
            // ConsultasParticulares
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1141, 692);
            Controls.Add(cmdOk);
            Controls.Add(txtConsultas);
            Controls.Add(checkFecha);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(dgvConsultas);
            Controls.Add(groupBox1);
            Controls.Add(dtpHasta);
            Controls.Add(label2);
            Controls.Add(dtpDesde);
            Controls.Add(label1);
            Name = "ConsultasParticulares";
            Text = "ConsultasParticulares";
            Load += ConsultasParticulares_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioCliente;
        private RadioButton radioRepartidor;
        private RadioButton radioMenu;
        private RadioButton radioGeneral;
        private DataGridView dgvConsultas;
        private Button cmdAceptar;
        private CheckBox checkConIndividual;
        private GroupBox groupBox2;
        private ComboBox cboConsulta;
        private Label label3;
        private Label label4;
        private CheckBox checkFecha;
        private Label txtConsultas;
        private Button cmdOk;
    }
}
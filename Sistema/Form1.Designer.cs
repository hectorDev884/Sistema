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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            cmdOrdenes = new Button();
            button4 = new Button();
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
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Consolas", 16.2F);
            button1.Location = new Point(163, 124);
            button1.Name = "button1";
            button1.Size = new Size(214, 137);
            button1.TabIndex = 36;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Consolas", 16.2F);
            button2.Location = new Point(402, 124);
            button2.Name = "button2";
            button2.Size = new Size(214, 137);
            button2.TabIndex = 37;
            button2.Text = "Repartidores";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Consolas", 16.2F);
            button3.Location = new Point(654, 124);
            button3.Name = "button3";
            button3.Size = new Size(214, 137);
            button3.TabIndex = 38;
            button3.Text = "Menu";
            button3.UseVisualStyleBackColor = false;
            // 
            // cmdOrdenes
            // 
            cmdOrdenes.BackColor = SystemColors.Control;
            cmdOrdenes.Font = new Font("Consolas", 16.2F);
            cmdOrdenes.Location = new Point(275, 316);
            cmdOrdenes.Name = "cmdOrdenes";
            cmdOrdenes.Size = new Size(214, 137);
            cmdOrdenes.TabIndex = 39;
            cmdOrdenes.Text = "Ordenes";
            cmdOrdenes.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Font = new Font("Consolas", 16.2F);
            button4.Location = new Point(526, 316);
            button4.Name = "button4";
            button4.Size = new Size(214, 137);
            button4.TabIndex = 40;
            button4.Text = "Detalle de Orden";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(996, 590);
            Controls.Add(button4);
            Controls.Add(cmdOrdenes);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button cmdOrdenes;
        private Button button4;
    }
}

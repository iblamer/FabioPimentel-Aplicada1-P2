namespace FabioPimentel_Apliacada1_P2
{
    partial class RegistroClientes
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
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.LimiteCreditotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefonosgroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumeromaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.TelefonoscomboBox = new System.Windows.Forms.ComboBox();
            this.TelefonosdataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.TelefonosgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(15, 24);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(148, 20);
            this.IdtextBox.TabIndex = 0;
            // 
            // LimiteCreditotextBox
            // 
            this.LimiteCreditotextBox.Location = new System.Drawing.Point(15, 159);
            this.LimiteCreditotextBox.Name = "LimiteCreditotextBox";
            this.LimiteCreditotextBox.Size = new System.Drawing.Size(100, 20);
            this.LimiteCreditotextBox.TabIndex = 1;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(15, 67);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(245, 20);
            this.NombretextBox.TabIndex = 3;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(15, 112);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(245, 20);
            this.FechadateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LimiteCredito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre";
            // 
            // TelefonosgroupBox
            // 
            this.TelefonosgroupBox.Controls.Add(this.label6);
            this.TelefonosgroupBox.Controls.Add(this.label5);
            this.TelefonosgroupBox.Controls.Add(this.NumeromaskedTextBox);
            this.TelefonosgroupBox.Controls.Add(this.AgregarButton);
            this.TelefonosgroupBox.Controls.Add(this.TelefonoscomboBox);
            this.TelefonosgroupBox.Controls.Add(this.TelefonosdataGridView);
            this.TelefonosgroupBox.Location = new System.Drawing.Point(12, 194);
            this.TelefonosgroupBox.Name = "TelefonosgroupBox";
            this.TelefonosgroupBox.Size = new System.Drawing.Size(446, 287);
            this.TelefonosgroupBox.TabIndex = 9;
            this.TelefonosgroupBox.TabStop = false;
            this.TelefonosgroupBox.Text = "Telefonos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Numero";
            // 
            // NumeromaskedTextBox
            // 
            this.NumeromaskedTextBox.Location = new System.Drawing.Point(91, 46);
            this.NumeromaskedTextBox.Mask = "(999) 000-0000";
            this.NumeromaskedTextBox.Name = "NumeromaskedTextBox";
            this.NumeromaskedTextBox.Size = new System.Drawing.Size(196, 20);
            this.NumeromaskedTextBox.TabIndex = 12;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(293, 42);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(121, 27);
            this.AgregarButton.TabIndex = 11;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // TelefonoscomboBox
            // 
            this.TelefonoscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TelefonoscomboBox.FormattingEnabled = true;
            this.TelefonoscomboBox.Location = new System.Drawing.Point(91, 19);
            this.TelefonoscomboBox.Name = "TelefonoscomboBox";
            this.TelefonoscomboBox.Size = new System.Drawing.Size(196, 21);
            this.TelefonoscomboBox.TabIndex = 1;
            // 
            // TelefonosdataGridView
            // 
            this.TelefonosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelefonosdataGridView.Location = new System.Drawing.Point(22, 72);
            this.TelefonosdataGridView.Name = "TelefonosdataGridView";
            this.TelefonosdataGridView.Size = new System.Drawing.Size(392, 209);
            this.TelefonosdataGridView.TabIndex = 0;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(169, 22);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(91, 23);
            this.BuscarButton.TabIndex = 10;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(262, 487);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(91, 23);
            this.ModificarButton.TabIndex = 12;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(142, 487);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(91, 23);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(24, 487);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(91, 23);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 522);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.TelefonosgroupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.LimiteCreditotextBox);
            this.Controls.Add(this.IdtextBox);
            this.Name = "RegistroClientes";
            this.Text = "RegistroClientes";
            this.Load += new System.EventHandler(this.RegistroClientes_Load);
            this.TelefonosgroupBox.ResumeLayout(false);
            this.TelefonosgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.TextBox LimiteCreditotextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox TelefonosgroupBox;
        private System.Windows.Forms.DataGridView TelefonosdataGridView;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.ComboBox TelefonoscomboBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox NumeromaskedTextBox;
    }
}
namespace Registro_con_Detalles.UI.REGISTROS
{
    partial class Registro_Persona
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label personaIdLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.personaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.GeneralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            nombresLabel = new System.Windows.Forms.Label();
            personaIdLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(42, 86);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 1;
            nombresLabel.Text = "Nombres:";
            // 
            // personaIdLabel
            // 
            personaIdLabel.AutoSize = true;
            personaIdLabel.Location = new System.Drawing.Point(42, 31);
            personaIdLabel.Name = "personaIdLabel";
            personaIdLabel.Size = new System.Drawing.Size(61, 13);
            personaIdLabel.TabIndex = 3;
            personaIdLabel.Text = "Persona Id:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(42, 181);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 5;
            cedulaLabel.Text = "Cedula:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(42, 137);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 7;
            fechaLabel.Text = "Fecha:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(42, 225);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 9;
            direccionLabel.Text = "Direccion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(42, 284);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 11;
            telefonoLabel.Text = "Telefono:";
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(104, 83);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresTextBox.TabIndex = 2;
            // 
            // personaIdNumericUpDown
            // 
            this.personaIdNumericUpDown.Location = new System.Drawing.Point(104, 31);
            this.personaIdNumericUpDown.Name = "personaIdNumericUpDown";
            this.personaIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.personaIdNumericUpDown.TabIndex = 4;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.Location = new System.Drawing.Point(104, 178);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaTextBox.TabIndex = 6;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(104, 133);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaDateTimePicker.TabIndex = 8;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(104, 222);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 10;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(104, 281);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 12;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(264, 31);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 13;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(104, 353);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 14;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(215, 352);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 15;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(339, 352);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 16;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // GeneralerrorProvider
            // 
            this.GeneralerrorProvider.ContainerControl = this;
            // 
            // Registro_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 416);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(personaIdLabel);
            this.Controls.Add(this.personaIdNumericUpDown);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Name = "Registro_Persona";
            this.Text = "Registro Persona";
            this.Load += new System.EventHandler(this.Registro_Persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.NumericUpDown personaIdNumericUpDown;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider GeneralerrorProvider;
    }
}
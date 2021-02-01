
namespace Tarea_3_RegistroDeUsuario
{
    partial class RegistroUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarioForm));
            this.NombreLabel = new System.Windows.Forms.Label();
            this.AliasLabel = new System.Windows.Forms.Label();
            this.UsuarioIdLabel = new System.Windows.Forms.Label();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.ComfirmaClaveLabel = new System.Windows.Forms.Label();
            this.IdRolLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FechaIngresoLabel = new System.Windows.Forms.Label();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.AliasTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmaClaveTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.FechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.UsuarioIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RolIdoComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(11, 86);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(51, 15);
            this.NombreLabel.TabIndex = 0;
            this.NombreLabel.Text = "Nombre";
            // 
            // AliasLabel
            // 
            this.AliasLabel.AutoSize = true;
            this.AliasLabel.Location = new System.Drawing.Point(11, 51);
            this.AliasLabel.Name = "AliasLabel";
            this.AliasLabel.Size = new System.Drawing.Size(32, 15);
            this.AliasLabel.TabIndex = 1;
            this.AliasLabel.Text = "Alias";
            // 
            // UsuarioIdLabel
            // 
            this.UsuarioIdLabel.AutoSize = true;
            this.UsuarioIdLabel.Location = new System.Drawing.Point(12, 16);
            this.UsuarioIdLabel.Name = "UsuarioIdLabel";
            this.UsuarioIdLabel.Size = new System.Drawing.Size(18, 15);
            this.UsuarioIdLabel.TabIndex = 2;
            this.UsuarioIdLabel.Text = "ID";
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Location = new System.Drawing.Point(11, 118);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(36, 15);
            this.ClaveLabel.TabIndex = 3;
            this.ClaveLabel.Text = "Clave";
            // 
            // ComfirmaClaveLabel
            // 
            this.ComfirmaClaveLabel.AutoSize = true;
            this.ComfirmaClaveLabel.Location = new System.Drawing.Point(216, 118);
            this.ComfirmaClaveLabel.Name = "ComfirmaClaveLabel";
            this.ComfirmaClaveLabel.Size = new System.Drawing.Size(93, 15);
            this.ComfirmaClaveLabel.TabIndex = 4;
            this.ComfirmaClaveLabel.Text = "Confirmar Clave";
            // 
            // IdRolLabel
            // 
            this.IdRolLabel.AutoSize = true;
            this.IdRolLabel.Location = new System.Drawing.Point(523, 56);
            this.IdRolLabel.Name = "IdRolLabel";
            this.IdRolLabel.Size = new System.Drawing.Size(83, 15);
            this.IdRolLabel.TabIndex = 5;
            this.IdRolLabel.Text = "Codigo De Rol";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(406, 86);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 15);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "E-mail";
            // 
            // FechaIngresoLabel
            // 
            this.FechaIngresoLabel.AutoSize = true;
            this.FechaIngresoLabel.Location = new System.Drawing.Point(480, 118);
            this.FechaIngresoLabel.Name = "FechaIngresoLabel";
            this.FechaIngresoLabel.Size = new System.Drawing.Size(97, 15);
            this.FechaIngresoLabel.TabIndex = 7;
            this.FechaIngresoLabel.Text = "Fecha De Ingreso";
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Location = new System.Drawing.Point(607, 23);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.ActivoCheckBox.TabIndex = 8;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // AliasTextBox
            // 
            this.AliasTextBox.Location = new System.Drawing.Point(68, 48);
            this.AliasTextBox.Multiline = true;
            this.AliasTextBox.Name = "AliasTextBox";
            this.AliasTextBox.Size = new System.Drawing.Size(149, 23);
            this.AliasTextBox.TabIndex = 10;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(68, 83);
            this.NombreTextBox.Multiline = true;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(260, 23);
            this.NombreTextBox.TabIndex = 11;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Location = new System.Drawing.Point(68, 115);
            this.ClaveTextBox.Multiline = true;
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.PasswordChar = '*';
            this.ClaveTextBox.Size = new System.Drawing.Size(142, 23);
            this.ClaveTextBox.TabIndex = 12;
            // 
            // ConfirmaClaveTextBox
            // 
            this.ConfirmaClaveTextBox.Location = new System.Drawing.Point(315, 115);
            this.ConfirmaClaveTextBox.Multiline = true;
            this.ConfirmaClaveTextBox.Name = "ConfirmaClaveTextBox";
            this.ConfirmaClaveTextBox.PasswordChar = '*';
            this.ConfirmaClaveTextBox.Size = new System.Drawing.Size(135, 23);
            this.ConfirmaClaveTextBox.TabIndex = 13;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(453, 83);
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(214, 23);
            this.EmailTextBox.TabIndex = 14;
            // 
            // FechaIngresoDateTimePicker
            // 
            this.FechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaIngresoDateTimePicker.Location = new System.Drawing.Point(583, 115);
            this.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker";
            this.FechaIngresoDateTimePicker.Size = new System.Drawing.Size(84, 23);
            this.FechaIngresoDateTimePicker.TabIndex = 16;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(246, 163);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(68, 44);
            this.NuevoButton.TabIndex = 17;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(128, 8);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(35, 30);
            this.BuscarButton.TabIndex = 18;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(332, 163);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(68, 44);
            this.GuardarButton.TabIndex = 19;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(419, 163);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(68, 44);
            this.EliminarButton.TabIndex = 21;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // UsuarioIdNumericUpDown
            // 
            this.UsuarioIdNumericUpDown.Location = new System.Drawing.Point(68, 12);
            this.UsuarioIdNumericUpDown.Name = "UsuarioIdNumericUpDown";
            this.UsuarioIdNumericUpDown.Size = new System.Drawing.Size(54, 23);
            this.UsuarioIdNumericUpDown.TabIndex = 22;
            // 
            // RolIdoComboBox
            // 
            this.RolIdoComboBox.FormattingEnabled = true;
            this.RolIdoComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.RolIdoComboBox.Location = new System.Drawing.Point(612, 54);
            this.RolIdoComboBox.Name = "RolIdoComboBox";
            this.RolIdoComboBox.Size = new System.Drawing.Size(55, 23);
            this.RolIdoComboBox.TabIndex = 24;
            // 
            // RegistroUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 219);
            this.Controls.Add(this.RolIdoComboBox);
            this.Controls.Add(this.UsuarioIdNumericUpDown);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.FechaIngresoDateTimePicker);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.ConfirmaClaveTextBox);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.AliasTextBox);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.FechaIngresoLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.IdRolLabel);
            this.Controls.Add(this.ComfirmaClaveLabel);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.UsuarioIdLabel);
            this.Controls.Add(this.AliasLabel);
            this.Controls.Add(this.NombreLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistroUsuarioForm";
            this.Text = "Registro De Usuario";
            this.Load += new System.EventHandler(this.RegistroUsuarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label AliasLabel;
        private System.Windows.Forms.Label UsuarioIdLabel;
        private System.Windows.Forms.Label ClaveLabel;
        private System.Windows.Forms.Label ComfirmaClaveLabel;
        private System.Windows.Forms.Label IdRolLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label FechaIngresoLabel;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.TextBox AliasTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.TextBox ConfirmaClaveTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.DateTimePicker FechaIngresoDateTimePicker;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.NumericUpDown UsuarioIdNumericUpDown;
        private System.Windows.Forms.ComboBox RolIdoComboBox;
    }
}


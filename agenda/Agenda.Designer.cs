namespace agenda
{
    partial class Agenda
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.lblNombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.movil = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.mktel = new System.Windows.Forms.MaskedTextBox();
            this.mkmovil = new System.Windows.Forms.MaskedTextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtfnacimiento = new System.Windows.Forms.Label();
            this.dtpfechana = new System.Windows.Forms.DateTimePicker();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombre.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblNombre.Location = new System.Drawing.Point(94, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.apellido.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.ForeColor = System.Drawing.Color.DarkKhaki;
            this.apellido.Location = new System.Drawing.Point(93, 92);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(82, 22);
            this.apellido.TabIndex = 1;
            this.apellido.Text = "Apellido:";
            // 
            // movil
            // 
            this.movil.AutoSize = true;
            this.movil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.movil.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movil.ForeColor = System.Drawing.Color.DarkKhaki;
            this.movil.Location = new System.Drawing.Point(93, 192);
            this.movil.Name = "movil";
            this.movil.Size = new System.Drawing.Size(57, 22);
            this.movil.TabIndex = 2;
            this.movil.Text = "Movil";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.telefono.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.ForeColor = System.Drawing.Color.DarkKhaki;
            this.telefono.Location = new System.Drawing.Point(93, 157);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(77, 22);
            this.telefono.TabIndex = 3;
            this.telefono.Text = "Telefono";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.correo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.ForeColor = System.Drawing.Color.DarkKhaki;
            this.correo.Location = new System.Drawing.Point(93, 123);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(67, 22);
            this.correo.TabIndex = 4;
            this.correo.Text = "Correo:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(180, 59);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(180, 126);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(100, 20);
            this.txtcorreo.TabIndex = 7;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(181, 91);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 8;
            // 
            // mktel
            // 
            this.mktel.Location = new System.Drawing.Point(179, 160);
            this.mktel.Name = "mktel";
            this.mktel.Size = new System.Drawing.Size(100, 20);
            this.mktel.TabIndex = 9;
            // 
            // mkmovil
            // 
            this.mkmovil.Location = new System.Drawing.Point(179, 194);
            this.mkmovil.Name = "mkmovil";
            this.mkmovil.Size = new System.Drawing.Size(100, 20);
            this.mkmovil.TabIndex = 10;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Direccion.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Direccion.Location = new System.Drawing.Point(93, 228);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(86, 22);
            this.Direccion.TabIndex = 11;
            this.Direccion.Text = "Direccion";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(181, 231);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 20);
            this.txtdireccion.TabIndex = 12;
            // 
            // dtpfecha
            // 
            this.dtpfecha.CalendarFont = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.CalendarForeColor = System.Drawing.Color.DarkKhaki;
            this.dtpfecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpfecha.Font = new System.Drawing.Font("Bodoni Bk BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Location = new System.Drawing.Point(51, 16);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpfecha.Size = new System.Drawing.Size(291, 25);
            this.dtpfecha.TabIndex = 13;
            // 
            // txtfnacimiento
            // 
            this.txtfnacimiento.AutoSize = true;
            this.txtfnacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtfnacimiento.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfnacimiento.ForeColor = System.Drawing.Color.DarkKhaki;
            this.txtfnacimiento.Location = new System.Drawing.Point(102, 362);
            this.txtfnacimiento.Name = "txtfnacimiento";
            this.txtfnacimiento.Size = new System.Drawing.Size(157, 20);
            this.txtfnacimiento.TabIndex = 14;
            this.txtfnacimiento.Text = "Fecha de nacimiento:";
            // 
            // dtpfechana
            // 
            this.dtpfechana.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechana.Location = new System.Drawing.Point(133, 391);
            this.dtpfechana.Name = "dtpfechana";
            this.dtpfechana.Size = new System.Drawing.Size(102, 20);
            this.dtpfechana.TabIndex = 15;
            this.dtpfechana.ValueChanged += new System.EventHandler(this.dtpfechana_ValueChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnguardar.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnguardar.Location = new System.Drawing.Point(267, 444);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(268, 473);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 17;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-34, -52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 517);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dtpfechana);
            this.Controls.Add(this.txtfnacimiento);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.mkmovil);
            this.Controls.Add(this.mktel);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.movil);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label movil;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.MaskedTextBox mktel;
        private System.Windows.Forms.MaskedTextBox mkmovil;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label txtfnacimiento;
        private System.Windows.Forms.DateTimePicker dtpfechana;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


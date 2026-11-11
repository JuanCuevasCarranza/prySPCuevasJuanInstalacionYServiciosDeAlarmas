namespace pryInstalacionYServiciosDeAlarmas
{
    partial class frmInstalacionYServiciosDeSensores
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
            tcMenu = new TabControl();
            tpInstalaciones = new TabPage();
            gbxCaracteristicasRequeridas = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            cbNo1 = new CheckBox();
            cbSi1 = new CheckBox();
            lblTableroGeneral = new Label();
            lblEspaciosParaSensores = new Label();
            gbxDireccionDeInstalacion = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblTipoDeAlarma = new Label();
            lblDireccionDeInstalacion = new Label();
            gbxDatosDeCliente = new GroupBox();
            txtDNICliente = new TextBox();
            lblDNICliente = new Label();
            tpServicios = new TabPage();
            tcMenu.SuspendLayout();
            tpInstalaciones.SuspendLayout();
            gbxCaracteristicasRequeridas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            gbxDireccionDeInstalacion.SuspendLayout();
            gbxDatosDeCliente.SuspendLayout();
            SuspendLayout();
            // 
            // tcMenu
            // 
            tcMenu.Controls.Add(tpInstalaciones);
            tcMenu.Controls.Add(tpServicios);
            tcMenu.Location = new Point(12, 37);
            tcMenu.Name = "tcMenu";
            tcMenu.SelectedIndex = 0;
            tcMenu.Size = new Size(776, 401);
            tcMenu.TabIndex = 0;
            // 
            // tpInstalaciones
            // 
            tpInstalaciones.BackColor = Color.Transparent;
            tpInstalaciones.Controls.Add(gbxCaracteristicasRequeridas);
            tpInstalaciones.Controls.Add(gbxDireccionDeInstalacion);
            tpInstalaciones.Controls.Add(gbxDatosDeCliente);
            tpInstalaciones.Location = new Point(4, 24);
            tpInstalaciones.Name = "tpInstalaciones";
            tpInstalaciones.Padding = new Padding(3);
            tpInstalaciones.Size = new Size(768, 373);
            tpInstalaciones.TabIndex = 0;
            tpInstalaciones.Text = "Instalaciones";
            // 
            // gbxCaracteristicasRequeridas
            // 
            gbxCaracteristicasRequeridas.Controls.Add(numericUpDown1);
            gbxCaracteristicasRequeridas.Controls.Add(cbNo1);
            gbxCaracteristicasRequeridas.Controls.Add(cbSi1);
            gbxCaracteristicasRequeridas.Controls.Add(lblTableroGeneral);
            gbxCaracteristicasRequeridas.Controls.Add(lblEspaciosParaSensores);
            gbxCaracteristicasRequeridas.Location = new Point(6, 203);
            gbxCaracteristicasRequeridas.Name = "gbxCaracteristicasRequeridas";
            gbxCaracteristicasRequeridas.Size = new Size(756, 158);
            gbxCaracteristicasRequeridas.TabIndex = 3;
            gbxCaracteristicasRequeridas.TabStop = false;
            gbxCaracteristicasRequeridas.Text = "CaracteristicasRequeridas";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(154, 30);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // cbNo1
            // 
            cbNo1.AutoSize = true;
            cbNo1.Location = new Point(232, 64);
            cbNo1.Name = "cbNo1";
            cbNo1.Size = new Size(42, 19);
            cbNo1.TabIndex = 4;
            cbNo1.Text = "No";
            cbNo1.UseVisualStyleBackColor = true;
            // 
            // cbSi1
            // 
            cbSi1.AutoSize = true;
            cbSi1.Location = new Point(191, 63);
            cbSi1.Name = "cbSi1";
            cbSi1.Size = new Size(35, 19);
            cbSi1.TabIndex = 3;
            cbSi1.Text = "Sí";
            cbSi1.UseVisualStyleBackColor = true;
            // 
            // lblTableroGeneral
            // 
            lblTableroGeneral.AutoSize = true;
            lblTableroGeneral.Location = new Point(18, 64);
            lblTableroGeneral.Name = "lblTableroGeneral";
            lblTableroGeneral.Size = new Size(167, 15);
            lblTableroGeneral.TabIndex = 2;
            lblTableroGeneral.Text = "¿Va a tener un tablero general?";
            // 
            // lblEspaciosParaSensores
            // 
            lblEspaciosParaSensores.AutoSize = true;
            lblEspaciosParaSensores.Location = new Point(18, 32);
            lblEspaciosParaSensores.Name = "lblEspaciosParaSensores";
            lblEspaciosParaSensores.Size = new Size(134, 15);
            lblEspaciosParaSensores.TabIndex = 0;
            lblEspaciosParaSensores.Text = "Espacios Para sensores *";
            // 
            // gbxDireccionDeInstalacion
            // 
            gbxDireccionDeInstalacion.Controls.Add(textBox2);
            gbxDireccionDeInstalacion.Controls.Add(textBox1);
            gbxDireccionDeInstalacion.Controls.Add(lblTipoDeAlarma);
            gbxDireccionDeInstalacion.Controls.Add(lblDireccionDeInstalacion);
            gbxDireccionDeInstalacion.Location = new Point(6, 97);
            gbxDireccionDeInstalacion.Name = "gbxDireccionDeInstalacion";
            gbxDireccionDeInstalacion.Size = new Size(756, 100);
            gbxDireccionDeInstalacion.TabIndex = 2;
            gbxDireccionDeInstalacion.TabStop = false;
            gbxDireccionDeInstalacion.Text = "Direccion de Instalacion";
            gbxDireccionDeInstalacion.Enter += gbxDireccionDeInstalacion_Enter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 3;
            // 
            // lblTipoDeAlarma
            // 
            lblTipoDeAlarma.AutoSize = true;
            lblTipoDeAlarma.Location = new Point(18, 65);
            lblTipoDeAlarma.Name = "lblTipoDeAlarma";
            lblTipoDeAlarma.Size = new Size(96, 15);
            lblTipoDeAlarma.TabIndex = 2;
            lblTipoDeAlarma.Text = "Tipo de Alarma *";
            // 
            // lblDireccionDeInstalacion
            // 
            lblDireccionDeInstalacion.AutoSize = true;
            lblDireccionDeInstalacion.Location = new Point(18, 34);
            lblDireccionDeInstalacion.Name = "lblDireccionDeInstalacion";
            lblDireccionDeInstalacion.Size = new Size(141, 15);
            lblDireccionDeInstalacion.TabIndex = 0;
            lblDireccionDeInstalacion.Text = "Direccion de Instalacion *";
            // 
            // gbxDatosDeCliente
            // 
            gbxDatosDeCliente.Controls.Add(txtDNICliente);
            gbxDatosDeCliente.Controls.Add(lblDNICliente);
            gbxDatosDeCliente.Location = new Point(6, 6);
            gbxDatosDeCliente.Name = "gbxDatosDeCliente";
            gbxDatosDeCliente.Size = new Size(756, 85);
            gbxDatosDeCliente.TabIndex = 0;
            gbxDatosDeCliente.TabStop = false;
            gbxDatosDeCliente.Text = "Datos del Cliente";
            // 
            // txtDNICliente
            // 
            txtDNICliente.Location = new Point(99, 39);
            txtDNICliente.MaxLength = 8;
            txtDNICliente.Name = "txtDNICliente";
            txtDNICliente.Size = new Size(154, 23);
            txtDNICliente.TabIndex = 1;
            // 
            // lblDNICliente
            // 
            lblDNICliente.AutoSize = true;
            lblDNICliente.Location = new Point(18, 42);
            lblDNICliente.Name = "lblDNICliente";
            lblDNICliente.Size = new Size(75, 15);
            lblDNICliente.TabIndex = 0;
            lblDNICliente.Text = "DNI Cliente *";
            // 
            // tpServicios
            // 
            tpServicios.Location = new Point(4, 24);
            tpServicios.Name = "tpServicios";
            tpServicios.Padding = new Padding(3);
            tpServicios.Size = new Size(768, 373);
            tpServicios.TabIndex = 1;
            tpServicios.Text = "Servicios";
            tpServicios.UseVisualStyleBackColor = true;
            // 
            // frmInstalacionYServiciosDeSensores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcMenu);
            Name = "frmInstalacionYServiciosDeSensores";
            Text = "Instalacion y Servicios De Alarmas";
            Load += frmInstalacionYServiciosDeSensores_Load;
            tcMenu.ResumeLayout(false);
            tpInstalaciones.ResumeLayout(false);
            gbxCaracteristicasRequeridas.ResumeLayout(false);
            gbxCaracteristicasRequeridas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            gbxDireccionDeInstalacion.ResumeLayout(false);
            gbxDireccionDeInstalacion.PerformLayout();
            gbxDatosDeCliente.ResumeLayout(false);
            gbxDatosDeCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMenu;
        private TabPage tpInstalaciones;
        private TabPage tpServicios;
        private GroupBox gbxDatosDeCliente;
        private Label lblDNICliente;
        private TextBox txtDNICliente;
        private GroupBox gbxCaracteristicasRequeridas;
        private GroupBox gbxDireccionDeInstalacion;
        private Label lblTipoDeAlarma;
        private Label lblDireccionDeInstalacion;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblEspaciosParaSensores;
        private CheckBox cbNo1;
        private CheckBox cbSi1;
        private Label lblTableroGeneral;
        private NumericUpDown numericUpDown1;
    }
}
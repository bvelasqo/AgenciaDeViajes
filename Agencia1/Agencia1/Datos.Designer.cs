namespace Agencia1
{
    partial class Datos
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
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.btnDMS = new System.Windows.Forms.Button();
            this.btnMejorCliente = new System.Windows.Forms.Button();
            this.btnPromVentas = new System.Windows.Forms.Button();
            this.btnCiudadDeMasIngresos = new System.Windows.Forms.Button();
            this.btnCedulaMejoresClientes = new System.Windows.Forms.Button();
            this.btnReservasACiudad = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnViajeroFrecuente = new System.Windows.Forms.Button();
            this.cbxCiudades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultados
            // 
            this.txtResultados.BackColor = System.Drawing.Color.Thistle;
            this.txtResultados.Location = new System.Drawing.Point(28, 104);
            this.txtResultados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.Size = new System.Drawing.Size(212, 360);
            this.txtResultados.TabIndex = 0;
            // 
            // btnDMS
            // 
            this.btnDMS.BackColor = System.Drawing.Color.Orchid;
            this.btnDMS.Location = new System.Drawing.Point(266, 104);
            this.btnDMS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDMS.Name = "btnDMS";
            this.btnDMS.Size = new System.Drawing.Size(112, 55);
            this.btnDMS.TabIndex = 1;
            this.btnDMS.Text = "Destino más solicitado";
            this.btnDMS.UseVisualStyleBackColor = false;
            this.btnDMS.Click += new System.EventHandler(this.btnDMS_Click);
            // 
            // btnMejorCliente
            // 
            this.btnMejorCliente.BackColor = System.Drawing.Color.Orchid;
            this.btnMejorCliente.Location = new System.Drawing.Point(417, 104);
            this.btnMejorCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMejorCliente.Name = "btnMejorCliente";
            this.btnMejorCliente.Size = new System.Drawing.Size(112, 55);
            this.btnMejorCliente.TabIndex = 2;
            this.btnMejorCliente.Text = "Mejor Cliente";
            this.btnMejorCliente.UseVisualStyleBackColor = false;
            this.btnMejorCliente.Click += new System.EventHandler(this.btnMejorCliente_Click);
            // 
            // btnPromVentas
            // 
            this.btnPromVentas.BackColor = System.Drawing.Color.Orchid;
            this.btnPromVentas.Location = new System.Drawing.Point(266, 209);
            this.btnPromVentas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPromVentas.Name = "btnPromVentas";
            this.btnPromVentas.Size = new System.Drawing.Size(112, 55);
            this.btnPromVentas.TabIndex = 3;
            this.btnPromVentas.Text = "Promedio ventas";
            this.btnPromVentas.UseVisualStyleBackColor = false;
            this.btnPromVentas.Click += new System.EventHandler(this.btnPromVentas_Click);
            // 
            // btnCiudadDeMasIngresos
            // 
            this.btnCiudadDeMasIngresos.BackColor = System.Drawing.Color.Orchid;
            this.btnCiudadDeMasIngresos.Location = new System.Drawing.Point(417, 209);
            this.btnCiudadDeMasIngresos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCiudadDeMasIngresos.Name = "btnCiudadDeMasIngresos";
            this.btnCiudadDeMasIngresos.Size = new System.Drawing.Size(112, 55);
            this.btnCiudadDeMasIngresos.TabIndex = 4;
            this.btnCiudadDeMasIngresos.Text = "Ciudad de más ingresos";
            this.btnCiudadDeMasIngresos.UseVisualStyleBackColor = false;
            this.btnCiudadDeMasIngresos.Click += new System.EventHandler(this.btnCiudadDeMasIngresos_Click);
            // 
            // btnCedulaMejoresClientes
            // 
            this.btnCedulaMejoresClientes.BackColor = System.Drawing.Color.Orchid;
            this.btnCedulaMejoresClientes.Location = new System.Drawing.Point(266, 305);
            this.btnCedulaMejoresClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCedulaMejoresClientes.Name = "btnCedulaMejoresClientes";
            this.btnCedulaMejoresClientes.Size = new System.Drawing.Size(112, 55);
            this.btnCedulaMejoresClientes.TabIndex = 5;
            this.btnCedulaMejoresClientes.Text = "Cedula mejores clientes";
            this.btnCedulaMejoresClientes.UseVisualStyleBackColor = false;
            this.btnCedulaMejoresClientes.Click += new System.EventHandler(this.btnCedulaMejoresClientes_Click);
            // 
            // btnReservasACiudad
            // 
            this.btnReservasACiudad.BackColor = System.Drawing.Color.Orchid;
            this.btnReservasACiudad.Location = new System.Drawing.Point(417, 305);
            this.btnReservasACiudad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReservasACiudad.Name = "btnReservasACiudad";
            this.btnReservasACiudad.Size = new System.Drawing.Size(112, 54);
            this.btnReservasACiudad.TabIndex = 6;
            this.btnReservasACiudad.Text = "Reservas a una ciudad";
            this.btnReservasACiudad.UseVisualStyleBackColor = false;
            this.btnReservasACiudad.Click += new System.EventHandler(this.btnReservasACiudad_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Orchid;
            this.btnConsultar.Location = new System.Drawing.Point(412, 422);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 27);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Visible = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnViajeroFrecuente
            // 
            this.btnViajeroFrecuente.BackColor = System.Drawing.Color.Orchid;
            this.btnViajeroFrecuente.Location = new System.Drawing.Point(266, 395);
            this.btnViajeroFrecuente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViajeroFrecuente.Name = "btnViajeroFrecuente";
            this.btnViajeroFrecuente.Size = new System.Drawing.Size(112, 54);
            this.btnViajeroFrecuente.TabIndex = 9;
            this.btnViajeroFrecuente.Text = "Viajero más frecuente";
            this.btnViajeroFrecuente.UseVisualStyleBackColor = false;
            this.btnViajeroFrecuente.Click += new System.EventHandler(this.btnViajeroFrecuente_Click);
            // 
            // cbxCiudades
            // 
            this.cbxCiudades.BackColor = System.Drawing.Color.Pink;
            this.cbxCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCiudades.FormattingEnabled = true;
            this.cbxCiudades.Items.AddRange(new object[] {
            " ",
            "Bogota",
            "Cali",
            "Medellin"});
            this.cbxCiudades.Location = new System.Drawing.Point(412, 395);
            this.cbxCiudades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCiudades.Name = "cbxCiudades";
            this.cbxCiudades.Size = new System.Drawing.Size(117, 23);
            this.cbxCiudades.TabIndex = 10;
            this.cbxCiudades.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(256, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "DATOS";
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Agencia1.Properties.Resources.por_que_los_aviones_apagan_las_luces_durante_el_despegue_y_el_aterrizaje;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCiudades);
            this.Controls.Add(this.btnViajeroFrecuente);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnReservasACiudad);
            this.Controls.Add(this.btnCedulaMejoresClientes);
            this.Controls.Add(this.btnCiudadDeMasIngresos);
            this.Controls.Add(this.btnPromVentas);
            this.Controls.Add(this.btnMejorCliente);
            this.Controls.Add(this.btnDMS);
            this.Controls.Add(this.txtResultados);
            this.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Button btnDMS;
        private System.Windows.Forms.Button btnMejorCliente;
        private System.Windows.Forms.Button btnPromVentas;
        private System.Windows.Forms.Button btnCiudadDeMasIngresos;
        private System.Windows.Forms.Button btnCedulaMejoresClientes;
        private System.Windows.Forms.Button btnReservasACiudad;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnViajeroFrecuente;
        private System.Windows.Forms.ComboBox cbxCiudades;
        private System.Windows.Forms.Label label1;
    }
}
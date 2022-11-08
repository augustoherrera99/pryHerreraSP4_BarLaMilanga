namespace pryHerreraSP4_BarLaMilanga
{
    partial class frmBarLaMilanga
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarLaMilanga));
            this.dgvGrillaVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidarDatos = new System.Windows.Forms.Button();
            this.btnMozoDelDia = new System.Windows.Forms.Button();
            this.btnTotales = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcConsultas = new System.Windows.Forms.GroupBox();
            this.btnLimpiarConsulta = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.lblVentas = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnLimpiarGrilla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaVentas)).BeginInit();
            this.mrcConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrillaVentas
            // 
            this.dgvGrillaVentas.AllowUserToAddRows = false;
            this.dgvGrillaVentas.AllowUserToDeleteRows = false;
            this.dgvGrillaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvGrillaVentas.Location = new System.Drawing.Point(13, 29);
            this.dgvGrillaVentas.Name = "dgvGrillaVentas";
            this.dgvGrillaVentas.RowHeadersVisible = false;
            this.dgvGrillaVentas.Size = new System.Drawing.Size(563, 133);
            this.dgvGrillaVentas.TabIndex = 0;
            this.dgvGrillaVentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvGrillaVentas_KeyPress);
            this.dgvGrillaVentas.Validating += new System.ComponentModel.CancelEventHandler(this.dgvGrillaVentas_Validating);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mozos";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Comidas";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bebidas sin alcohol";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bebidas con alcohol";
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Postres";
            this.Column5.Name = "Column5";
            // 
            // btnValidarDatos
            // 
            this.btnValidarDatos.Location = new System.Drawing.Point(599, 61);
            this.btnValidarDatos.Name = "btnValidarDatos";
            this.btnValidarDatos.Size = new System.Drawing.Size(78, 36);
            this.btnValidarDatos.TabIndex = 1;
            this.btnValidarDatos.Text = "Validar datos";
            this.btnValidarDatos.UseVisualStyleBackColor = true;
            this.btnValidarDatos.Click += new System.EventHandler(this.btnValidarDatos_Click);
            // 
            // btnMozoDelDia
            // 
            this.btnMozoDelDia.Location = new System.Drawing.Point(23, 55);
            this.btnMozoDelDia.Name = "btnMozoDelDia";
            this.btnMozoDelDia.Size = new System.Drawing.Size(75, 40);
            this.btnMozoDelDia.TabIndex = 2;
            this.btnMozoDelDia.Text = "Mozo del Día";
            this.btnMozoDelDia.UseVisualStyleBackColor = true;
            this.btnMozoDelDia.Click += new System.EventHandler(this.btnMozoDelDia_Click);
            // 
            // btnTotales
            // 
            this.btnTotales.Location = new System.Drawing.Point(23, 111);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(75, 34);
            this.btnTotales.TabIndex = 3;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(599, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 32);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mrcConsultas
            // 
            this.mrcConsultas.Controls.Add(this.btnLimpiarConsulta);
            this.mrcConsultas.Controls.Add(this.lblResultado);
            this.mrcConsultas.Controls.Add(this.lstResultado);
            this.mrcConsultas.Controls.Add(this.btnMozoDelDia);
            this.mrcConsultas.Controls.Add(this.btnTotales);
            this.mrcConsultas.Enabled = false;
            this.mrcConsultas.Location = new System.Drawing.Point(13, 180);
            this.mrcConsultas.Name = "mrcConsultas";
            this.mrcConsultas.Size = new System.Drawing.Size(564, 202);
            this.mrcConsultas.TabIndex = 5;
            this.mrcConsultas.TabStop = false;
            this.mrcConsultas.Text = "Consultas";
            // 
            // btnLimpiarConsulta
            // 
            this.btnLimpiarConsulta.Location = new System.Drawing.Point(471, 152);
            this.btnLimpiarConsulta.Name = "btnLimpiarConsulta";
            this.btnLimpiarConsulta.Size = new System.Drawing.Size(75, 34);
            this.btnLimpiarConsulta.TabIndex = 6;
            this.btnLimpiarConsulta.Text = "Limpiar";
            this.btnLimpiarConsulta.UseVisualStyleBackColor = true;
            this.btnLimpiarConsulta.Click += new System.EventHandler(this.btnLimpiarConsulta_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(121, 30);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(124, 46);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(328, 108);
            this.lstResultado.TabIndex = 4;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(10, 13);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(80, 13);
            this.lblVentas.TabIndex = 6;
            this.lblVentas.Text = "Grilla de ventas";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(599, 112);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(78, 36);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Llenar grilla";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnLimpiarGrilla
            // 
            this.btnLimpiarGrilla.Location = new System.Drawing.Point(599, 303);
            this.btnLimpiarGrilla.Name = "btnLimpiarGrilla";
            this.btnLimpiarGrilla.Size = new System.Drawing.Size(78, 32);
            this.btnLimpiarGrilla.TabIndex = 8;
            this.btnLimpiarGrilla.Text = "Borrar datos";
            this.btnLimpiarGrilla.UseVisualStyleBackColor = true;
            this.btnLimpiarGrilla.Click += new System.EventHandler(this.btnLimpiarGrilla_Click);
            // 
            // frmBarLaMilanga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 394);
            this.Controls.Add(this.btnLimpiarGrilla);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.mrcConsultas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnValidarDatos);
            this.Controls.Add(this.dgvGrillaVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBarLaMilanga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar La Milanga";
            this.Load += new System.EventHandler(this.frmBarLaMilanga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaVentas)).EndInit();
            this.mrcConsultas.ResumeLayout(false);
            this.mrcConsultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrillaVentas;
        private System.Windows.Forms.Button btnValidarDatos;
        private System.Windows.Forms.Button btnMozoDelDia;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox mrcConsultas;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnLimpiarConsulta;
        private System.Windows.Forms.Button btnLimpiarGrilla;
    }
}


namespace WindowsAppInstrumentos
{
    partial class Form1
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
            this.btnMostrarInstrumentos = new System.Windows.Forms.Button();
            this.btnMovimientoPiezas = new System.Windows.Forms.Button();
            this.btnMostrarPersonas = new System.Windows.Forms.Button();
            this.btnMostrarAnimales = new System.Windows.Forms.Button();
            this.btnTransportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarInstrumentos
            // 
            this.btnMostrarInstrumentos.Location = new System.Drawing.Point(65, 37);
            this.btnMostrarInstrumentos.Name = "btnMostrarInstrumentos";
            this.btnMostrarInstrumentos.Size = new System.Drawing.Size(185, 77);
            this.btnMostrarInstrumentos.TabIndex = 0;
            this.btnMostrarInstrumentos.Text = "Mostrar Instrumentos";
            this.btnMostrarInstrumentos.UseVisualStyleBackColor = true;
            this.btnMostrarInstrumentos.Click += new System.EventHandler(this.btnMostrarInstrumentos_Click);
            // 
            // btnMovimientoPiezas
            // 
            this.btnMovimientoPiezas.Location = new System.Drawing.Point(276, 37);
            this.btnMovimientoPiezas.Name = "btnMovimientoPiezas";
            this.btnMovimientoPiezas.Size = new System.Drawing.Size(185, 77);
            this.btnMovimientoPiezas.TabIndex = 1;
            this.btnMovimientoPiezas.Text = "Ajedrez Piezas";
            this.btnMovimientoPiezas.UseVisualStyleBackColor = true;
            this.btnMovimientoPiezas.Click += new System.EventHandler(this.btnMovimientoPiezas_Click);
            // 
            // btnMostrarPersonas
            // 
            this.btnMostrarPersonas.Location = new System.Drawing.Point(500, 37);
            this.btnMostrarPersonas.Name = "btnMostrarPersonas";
            this.btnMostrarPersonas.Size = new System.Drawing.Size(185, 77);
            this.btnMostrarPersonas.TabIndex = 2;
            this.btnMostrarPersonas.Text = "Medico / Paciente";
            this.btnMostrarPersonas.UseVisualStyleBackColor = true;
            this.btnMostrarPersonas.Click += new System.EventHandler(this.btnMostrarPersonas_Click);
            // 
            // btnMostrarAnimales
            // 
            this.btnMostrarAnimales.Location = new System.Drawing.Point(151, 181);
            this.btnMostrarAnimales.Name = "btnMostrarAnimales";
            this.btnMostrarAnimales.Size = new System.Drawing.Size(185, 77);
            this.btnMostrarAnimales.TabIndex = 3;
            this.btnMostrarAnimales.Text = "Mostrar Animales";
            this.btnMostrarAnimales.UseVisualStyleBackColor = true;
            this.btnMostrarAnimales.Click += new System.EventHandler(this.btnMostrarAnimales_Click);
            // 
            // btnTransportes
            // 
            this.btnTransportes.Location = new System.Drawing.Point(404, 181);
            this.btnTransportes.Name = "btnTransportes";
            this.btnTransportes.Size = new System.Drawing.Size(185, 77);
            this.btnTransportes.TabIndex = 4;
            this.btnTransportes.Text = "Mostrar Transportes";
            this.btnTransportes.UseVisualStyleBackColor = true;
            this.btnTransportes.Click += new System.EventHandler(this.btnTransportes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransportes);
            this.Controls.Add(this.btnMostrarAnimales);
            this.Controls.Add(this.btnMostrarPersonas);
            this.Controls.Add(this.btnMovimientoPiezas);
            this.Controls.Add(this.btnMostrarInstrumentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarInstrumentos;
        private System.Windows.Forms.Button btnMovimientoPiezas;
        private System.Windows.Forms.Button btnMostrarPersonas;
        private System.Windows.Forms.Button btnMostrarAnimales;
        private System.Windows.Forms.Button btnTransportes;
    }
}


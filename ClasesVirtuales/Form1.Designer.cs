namespace ClasesVirtuales
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btDeletreo = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btMayuscula = new System.Windows.Forms.Button();
            this.btMinuscula = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btExtraer = new System.Windows.Forms.Button();
            this.btLongitud = new System.Windows.Forms.Button();
            this.btRemplazar = new System.Windows.Forms.Button();
            this.txtRemplazo = new System.Windows.Forms.TextBox();
            this.lblRemplazo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(12, 65);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(320, 20);
            this.txtString.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(274, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Escriba lo que quiera aqui :";
            // 
            // btDeletreo
            // 
            this.btDeletreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletreo.Location = new System.Drawing.Point(12, 104);
            this.btDeletreo.Name = "btDeletreo";
            this.btDeletreo.Size = new System.Drawing.Size(100, 30);
            this.btDeletreo.TabIndex = 2;
            this.btDeletreo.Text = "Deletrear";
            this.btDeletreo.UseVisualStyleBackColor = true;
            this.btDeletreo.Click += new System.EventHandler(this.btDeletreo_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(14, 184);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 16);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "...";
            // 
            // btMayuscula
            // 
            this.btMayuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMayuscula.Location = new System.Drawing.Point(118, 104);
            this.btMayuscula.Name = "btMayuscula";
            this.btMayuscula.Size = new System.Drawing.Size(104, 30);
            this.btMayuscula.TabIndex = 4;
            this.btMayuscula.Text = "Mayuscula";
            this.btMayuscula.UseVisualStyleBackColor = true;
            this.btMayuscula.Click += new System.EventHandler(this.btMayuscula_Click);
            // 
            // btMinuscula
            // 
            this.btMinuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinuscula.Location = new System.Drawing.Point(228, 104);
            this.btMinuscula.Name = "btMinuscula";
            this.btMinuscula.Size = new System.Drawing.Size(104, 30);
            this.btMinuscula.TabIndex = 5;
            this.btMinuscula.Text = "Minuscula";
            this.btMinuscula.UseVisualStyleBackColor = true;
            this.btMinuscula.Click += new System.EventHandler(this.btMinuscula_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(349, 80);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 6;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(346, 13);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(163, 64);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Escriba aqui lo que quiera\r\nextraer o la palabra que \r\nquiera reemplazar dentro \r" +
    "\ndel texto escrito";
            // 
            // btExtraer
            // 
            this.btExtraer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExtraer.Location = new System.Drawing.Point(490, 80);
            this.btExtraer.Name = "btExtraer";
            this.btExtraer.Size = new System.Drawing.Size(92, 28);
            this.btExtraer.TabIndex = 8;
            this.btExtraer.Text = "Extraer";
            this.btExtraer.UseVisualStyleBackColor = true;
            this.btExtraer.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btLongitud
            // 
            this.btLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLongitud.Location = new System.Drawing.Point(118, 140);
            this.btLongitud.Name = "btLongitud";
            this.btLongitud.Size = new System.Drawing.Size(104, 30);
            this.btLongitud.TabIndex = 9;
            this.btLongitud.Text = "Longitud";
            this.btLongitud.UseVisualStyleBackColor = true;
            this.btLongitud.Click += new System.EventHandler(this.btLongitud_Click);
            // 
            // btRemplazar
            // 
            this.btRemplazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemplazar.Location = new System.Drawing.Point(490, 114);
            this.btRemplazar.Name = "btRemplazar";
            this.btRemplazar.Size = new System.Drawing.Size(94, 28);
            this.btRemplazar.TabIndex = 10;
            this.btRemplazar.Text = "Remplazar";
            this.btRemplazar.UseVisualStyleBackColor = true;
            this.btRemplazar.Click += new System.EventHandler(this.btRemplazar_Click);
            // 
            // txtRemplazo
            // 
            this.txtRemplazo.Location = new System.Drawing.Point(349, 132);
            this.txtRemplazo.Name = "txtRemplazo";
            this.txtRemplazo.Size = new System.Drawing.Size(100, 20);
            this.txtRemplazo.TabIndex = 11;
            // 
            // lblRemplazo
            // 
            this.lblRemplazo.AutoSize = true;
            this.lblRemplazo.Location = new System.Drawing.Point(349, 103);
            this.lblRemplazo.Name = "lblRemplazo";
            this.lblRemplazo.Size = new System.Drawing.Size(138, 26);
            this.lblRemplazo.TabIndex = 12;
            this.lblRemplazo.Text = "Escriba aqui la palabra que \r\nse usara para reemplazar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 222);
            this.Controls.Add(this.lblRemplazo);
            this.Controls.Add(this.txtRemplazo);
            this.Controls.Add(this.btRemplazar);
            this.Controls.Add(this.btLongitud);
            this.Controls.Add(this.btExtraer);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btMinuscula);
            this.Controls.Add(this.btMayuscula);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btDeletreo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btDeletreo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btMayuscula;
        private System.Windows.Forms.Button btMinuscula;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btExtraer;
        private System.Windows.Forms.Button btLongitud;
        private System.Windows.Forms.Button btRemplazar;
        private System.Windows.Forms.TextBox txtRemplazo;
        private System.Windows.Forms.Label lblRemplazo;
    }
}


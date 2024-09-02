namespace ejercicio_4
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
            this.chkAceptar = new System.Windows.Forms.CheckBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAceptar
            // 
            this.chkAceptar.AutoSize = true;
            this.chkAceptar.Location = new System.Drawing.Point(280, 108);
            this.chkAceptar.Name = "chkAceptar";
            this.chkAceptar.Size = new System.Drawing.Size(63, 17);
            this.chkAceptar.TabIndex = 0;
            this.chkAceptar.Text = "Aceptar";
            this.chkAceptar.UseVisualStyleBackColor = true;
            this.chkAceptar.CheckedChanged += new System.EventHandler(this.chkAceptar_CheckedChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(277, 83);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(227, 13);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "¿Está de acuerdo con las normas del servicio?";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(334, 131);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.chkAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAceptar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnContinuar;
    }
}


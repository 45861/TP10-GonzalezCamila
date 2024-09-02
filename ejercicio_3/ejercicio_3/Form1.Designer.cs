namespace ejercicio_3
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
            this.chkOpcion1 = new System.Windows.Forms.CheckBox();
            this.chkOpcion2 = new System.Windows.Forms.CheckBox();
            this.chkOpcion3 = new System.Windows.Forms.CheckBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkOpcion1
            // 
            this.chkOpcion1.AutoSize = true;
            this.chkOpcion1.Location = new System.Drawing.Point(330, 106);
            this.chkOpcion1.Name = "chkOpcion1";
            this.chkOpcion1.Size = new System.Drawing.Size(64, 17);
            this.chkOpcion1.TabIndex = 0;
            this.chkOpcion1.Text = "Español";
            this.chkOpcion1.UseVisualStyleBackColor = true;
            // 
            // chkOpcion2
            // 
            this.chkOpcion2.AutoSize = true;
            this.chkOpcion2.Location = new System.Drawing.Point(330, 130);
            this.chkOpcion2.Name = "chkOpcion2";
            this.chkOpcion2.Size = new System.Drawing.Size(54, 17);
            this.chkOpcion2.TabIndex = 1;
            this.chkOpcion2.Text = "Ingles";
            this.chkOpcion2.UseVisualStyleBackColor = true;
            // 
            // chkOpcion3
            // 
            this.chkOpcion3.AutoSize = true;
            this.chkOpcion3.Location = new System.Drawing.Point(330, 154);
            this.chkOpcion3.Name = "chkOpcion3";
            this.chkOpcion3.Size = new System.Drawing.Size(64, 17);
            this.chkOpcion3.TabIndex = 2;
            this.chkOpcion3.Text = "Frances";
            this.chkOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(330, 187);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Seleccionado";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(449, 134);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.chkOpcion3);
            this.Controls.Add(this.chkOpcion2);
            this.Controls.Add(this.chkOpcion1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOpcion1;
        private System.Windows.Forms.CheckBox chkOpcion2;
        private System.Windows.Forms.CheckBox chkOpcion3;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblResultado;
    }
}


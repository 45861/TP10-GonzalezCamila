namespace ejercicio_2
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
            this.rbDim1 = new System.Windows.Forms.RadioButton();
            this.rbDim2 = new System.Windows.Forms.RadioButton();
            this.rbDim3 = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDim1
            // 
            this.rbDim1.AutoSize = true;
            this.rbDim1.Location = new System.Drawing.Point(6, 23);
            this.rbDim1.Name = "rbDim1";
            this.rbDim1.Size = new System.Drawing.Size(128, 17);
            this.rbDim1.TabIndex = 0;
            this.rbDim1.TabStop = true;
            this.rbDim1.Text = "Ancho: 800, Alto: 600";
            this.rbDim1.UseVisualStyleBackColor = true;
            // 
            // rbDim2
            // 
            this.rbDim2.AutoSize = true;
            this.rbDim2.Location = new System.Drawing.Point(6, 46);
            this.rbDim2.Name = "rbDim2";
            this.rbDim2.Size = new System.Drawing.Size(134, 17);
            this.rbDim2.TabIndex = 1;
            this.rbDim2.TabStop = true;
            this.rbDim2.Text = "Ancho: 1024, Alto: 768";
            this.rbDim2.UseVisualStyleBackColor = true;
            // 
            // rbDim3
            // 
            this.rbDim3.AutoSize = true;
            this.rbDim3.Location = new System.Drawing.Point(6, 69);
            this.rbDim3.Name = "rbDim3";
            this.rbDim3.Size = new System.Drawing.Size(140, 17);
            this.rbDim3.TabIndex = 2;
            this.rbDim3.TabStop = true;
            this.rbDim3.Text = "Ancho: 1280, Alto: 1024";
            this.rbDim3.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(233, 254);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label1";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(289, 228);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDim1);
            this.groupBox1.Controls.Add(this.rbDim2);
            this.groupBox1.Controls.Add(this.rbDim3);
            this.groupBox1.Location = new System.Drawing.Point(230, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDim1;
        private System.Windows.Forms.RadioButton rbDim2;
        private System.Windows.Forms.RadioButton rbDim3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


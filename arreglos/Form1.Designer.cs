
namespace arreglos
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbllista = new System.Windows.Forms.Label();
            this.btcargar = new System.Windows.Forms.Button();
            this.txtlista = new System.Windows.Forms.TextBox();
            this.btmostrar = new System.Windows.Forms.Button();
            this.txtnac = new System.Windows.Forms.TextBox();
            this.lblaño = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(14, 35);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(65, 20);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // lbllista
            // 
            this.lbllista.AutoSize = true;
            this.lbllista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllista.Location = new System.Drawing.Point(21, 97);
            this.lbllista.Name = "lbllista";
            this.lbllista.Size = new System.Drawing.Size(72, 31);
            this.lbllista.TabIndex = 1;
            this.lbllista.Text = "Lista";
            // 
            // btcargar
            // 
            this.btcargar.Location = new System.Drawing.Point(267, 55);
            this.btcargar.Name = "btcargar";
            this.btcargar.Size = new System.Drawing.Size(75, 23);
            this.btcargar.TabIndex = 3;
            this.btcargar.Text = "Cargar";
            this.btcargar.UseVisualStyleBackColor = true;
            this.btcargar.Click += new System.EventHandler(this.btcargar_Click);
            // 
            // txtlista
            // 
            this.txtlista.Location = new System.Drawing.Point(12, 58);
            this.txtlista.Name = "txtlista";
            this.txtlista.Size = new System.Drawing.Size(100, 20);
            this.txtlista.TabIndex = 1;
            // 
            // btmostrar
            // 
            this.btmostrar.Location = new System.Drawing.Point(358, 56);
            this.btmostrar.Name = "btmostrar";
            this.btmostrar.Size = new System.Drawing.Size(75, 23);
            this.btmostrar.TabIndex = 4;
            this.btmostrar.Text = "mostrar";
            this.btmostrar.UseVisualStyleBackColor = true;
            this.btmostrar.Click += new System.EventHandler(this.btmostrar_Click);
            // 
            // txtnac
            // 
            this.txtnac.Location = new System.Drawing.Point(127, 58);
            this.txtnac.Name = "txtnac";
            this.txtnac.Size = new System.Drawing.Size(71, 20);
            this.txtnac.TabIndex = 2;
            // 
            // lblaño
            // 
            this.lblaño.AutoSize = true;
            this.lblaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaño.Location = new System.Drawing.Point(129, 35);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(36, 20);
            this.lblaño.TabIndex = 4;
            this.lblaño.Text = "año";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 363);
            this.Controls.Add(this.txtnac);
            this.Controls.Add(this.lblaño);
            this.Controls.Add(this.btmostrar);
            this.Controls.Add(this.txtlista);
            this.Controls.Add(this.btcargar);
            this.Controls.Add(this.lbllista);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbllista;
        private System.Windows.Forms.Button btcargar;
        private System.Windows.Forms.TextBox txtlista;
        private System.Windows.Forms.Button btmostrar;
        private System.Windows.Forms.TextBox txtnac;
        private System.Windows.Forms.Label lblaño;
    }
}


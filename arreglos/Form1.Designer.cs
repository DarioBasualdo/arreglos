
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
            this.btfiltrar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lvlcodigo = new System.Windows.Forms.Label();
            this.btborrar = new System.Windows.Forms.Button();
            this.btbuscar = new System.Windows.Forms.Button();
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
            this.lbllista.Location = new System.Drawing.Point(12, 97);
            this.lbllista.Name = "lbllista";
            this.lbllista.Size = new System.Drawing.Size(72, 31);
            this.lbllista.TabIndex = 1;
            this.lbllista.Text = "Lista";
            // 
            // btcargar
            // 
            this.btcargar.Location = new System.Drawing.Point(354, 56);
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
            this.btmostrar.Location = new System.Drawing.Point(435, 56);
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
            // btfiltrar
            // 
            this.btfiltrar.Location = new System.Drawing.Point(354, 105);
            this.btfiltrar.Name = "btfiltrar";
            this.btfiltrar.Size = new System.Drawing.Size(75, 23);
            this.btfiltrar.TabIndex = 5;
            this.btfiltrar.Text = "filtrar";
            this.btfiltrar.UseVisualStyleBackColor = true;
            this.btfiltrar.Click += new System.EventHandler(this.btfiltrar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(354, 162);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(71, 20);
            this.txtcodigo.TabIndex = 8;
            // 
            // lvlcodigo
            // 
            this.lvlcodigo.AutoSize = true;
            this.lvlcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlcodigo.Location = new System.Drawing.Point(362, 137);
            this.lvlcodigo.Name = "lvlcodigo";
            this.lvlcodigo.Size = new System.Drawing.Size(56, 20);
            this.lvlcodigo.TabIndex = 9;
            this.lvlcodigo.Text = "codigo";
            // 
            // btborrar
            // 
            this.btborrar.Location = new System.Drawing.Point(435, 107);
            this.btborrar.Name = "btborrar";
            this.btborrar.Size = new System.Drawing.Size(75, 23);
            this.btborrar.TabIndex = 10;
            this.btborrar.Text = "Borrar";
            this.btborrar.UseVisualStyleBackColor = true;
            this.btborrar.Click += new System.EventHandler(this.btborrar_Click);
            // 
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(435, 162);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(75, 23);
            this.btbuscar.TabIndex = 11;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 363);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.btborrar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lvlcodigo);
            this.Controls.Add(this.btfiltrar);
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
        private System.Windows.Forms.Button btfiltrar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lvlcodigo;
        private System.Windows.Forms.Button btborrar;
        private System.Windows.Forms.Button btbuscar;
    }
}


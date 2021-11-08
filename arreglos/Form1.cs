using arreglos.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglos
{

    public partial class Form1 : Form
    {
        persona per = new persona();
        public listapersonas lista { get; set; } = new listapersonas();

        public Form1()
        {
            InitializeComponent();

        }

        private void btcargar_Click(object sender, EventArgs e)

        {


            per.Nombre = txtlista.Text;
            per.Añonac = Convert.ToInt32(txtnac.Text);

            if ( !lista.updatepersonas(per))
            {
                lbllista.Text = "Error";
            }
            else
            {
                btmostrar_Click(null,null);
                txtlista.Text = txtnac.Text = lista.vacio();
            }
            per = new persona();

        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
         
            lbllista.Text = lista.ToString();  
        }

        private void btfiltrar_Click(object sender, EventArgs e)
        {

            lbllista.Text = lista.ToStringfiltrado(2000);
            
          

            
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            per = lista.Buscarpersona(Convert.ToInt32(txtcodigo.Text));
            if (per.id >0)
            {
                txtlista.Text = per.Nombre;
                txtnac.Text = per.Añonac.ToString();
                txtlista.Focus();
                txtcodigo.Text = "";
            }
            else
            {
                txtcodigo.Text = "no existe";
                txtcodigo.Focus();
            }
          
        }

        private void btborrar_Click(object sender, EventArgs e)
        {
            if (!lista.deletpersona(per))
            {
                btmostrar_Click(null, null);
                txtlista.Text = txtnac.Text = lista.vacio();

            }
            else
            {
                lbllista.Text = "El registro"+per.Nombre+"no fue eliminado";
                
            }
            per = new persona();

        }

       
    }



}

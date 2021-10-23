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
        public listapersonas lista { get; set; } = new listapersonas();

        public Form1()
        {
            InitializeComponent();

        }

        private void btcargar_Click(object sender, EventArgs e)

        {
            

            if ( !lista.addpersonas(txtlista.Text, txtnac.Text))
            {
                lbllista.Text = "Error";
            }
            else
            {
                lbllista.Text = "Aceptado";
            }
            txtlista.Text = txtnac.Text= lista.vacio();


        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
         
            lbllista.Text = lista.ToString();  
        }

        private void btfiltrar_Click(object sender, EventArgs e)
        {

           lbllista.Text = lista.ToStringfiltrado(2000)
            
          

            
        }
    }



}

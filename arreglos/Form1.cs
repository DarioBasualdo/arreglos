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
        public persona[] Personas { get; set; }

        public Form1()
        {
            InitializeComponent();

        }

        private void btcargar_Click(object sender, EventArgs e)

        {
            persona persona = new persona();
            persona.Nombre = txtlista.Text;
            Redimencionar();
            Personas[Personas.Length-1] = persona;

        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            lbllista.Text = "Lista:\r\n";
            foreach (persona item in Personas)
            {
                lbllista.Text = lbllista.Text + item.Nombre + "\r\n";
            }

        }


        private void Redimencionar()
        {
            if (Personas==null)
            {
                Personas = new persona [1];
            }
            else
            {
                persona[] aux = new persona[Personas.Length+1];
                for (int i = 0; i < Personas.Length; i++)
                {
                    aux[i] = Personas[i];

                }
                Personas = aux;
            }

        }

    }



}

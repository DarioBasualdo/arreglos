using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos.clases
{
    public class listapersonas
    {
        public persona[] Personas { get; set; }
        public void Redimencionar()
        {
            if (Personas == null)
            {
                Personas = new persona[1];
            }
            else
            {
                persona[] aux = new persona[Personas.Length + 1];
                for (int i = 0; i < Personas.Length; i++)
                {
                    aux[i] = Personas[i];

                }
                Personas = aux;
            }

        }

        public bool addpersonas(string nombre, string año)
        {
            persona persona = new persona();
            persona.Nombre = nombre;
            persona.Añonac = System.Convert.ToInt32(año);
            bool res = persona.validar();
            if (res)
            {
                Redimencionar();
                Personas[Personas.Length - 1] = persona;
            }
            return res;

        }

        public override string ToString()
        {
            string resp;

            resp = "Lista:\r\n";
            foreach (persona item in Personas)
            {
                resp = resp + item.Añonac + "-" + item.Nombre + "\r\n";
            }
            return resp;
        }
        public string ToStringfiltrado(int añomi)
        {

            string resp;



            resp = "Lista:\r\n";
            foreach (persona item in Personas)
            {
                if (item.Añonac >= añomi)
                {
                    resp = resp + item.Añonac + "-" + item.Nombre + "\r\n";
                }


            }
            return resp;
        }

        public string vacio()
        {
            string limpio = "";

            return limpio;
        }

      
      
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos.clases
{
    public class listapersonas
    {
        public int ultimocodigo { get; set; } = 0;
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
                ultimocodigo = ultimocodigo + 1;
                persona.id = ultimocodigo;
                Redimencionar();
                Personas[Personas.Length - 1] = persona;
            }
            return res;

        }

        public bool updatepersonas(persona persona)
        {
            bool res = persona.validar();
            if (res)
            {
                if (persona.id == 0)
                {
                    ultimocodigo = ultimocodigo + 1;
                    persona.id = ultimocodigo;
                    Redimencionar();
                    Personas[Personas.Length - 1] = persona;
                }
                else
                {
                    for (int i = 0; i < Personas.Length ; i++)
                    {
                        if(Personas[i].id==persona.id)
                        {
                            Personas[i] = persona;
                            break;
                        }
                    }

                }

            }
            return res;

        }

        public override string ToString()
        {
            string resp;

            resp = "Lista:\r\n";
            foreach (persona item in Personas)
            {
                resp = resp
                    + item.id.ToString()
                    + "_" +
                     item.Añonac.ToString()
                    + "-" +
                    item.Nombre.ToString()
                    + "\r\n";
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
                    resp = resp
                  + item.id.ToString()
                  + item.Añonac.ToString()
                  + "-" +
                  item.Nombre.ToString()
                  + "\r\n";


                }


            }
            return resp;
        }

        public string vacio()
        {
            string limpio = "";

            return limpio;
        }

        public persona Buscarpersona(int id)
        {
            persona resp = new persona();


            foreach (persona item in Personas)
            {
                if (item.id == id)
                {
                    resp = item;
                    break;
                }

            }

            return resp;

        }


        public bool deletpersona(persona persona)
        {
            bool resp = false;
            for (int i = 0; i < Personas.Length; i++)
            {
                if (Personas[i].id == persona.id)
                {
                    eliminarregistro(i);
                    break;
                }
            }
            return resp;

        }


        public void eliminarregistro (int posicion)
        {
            for (int i = posicion; i < Personas.Length-1 ; i++)
            {
                Personas[i] = Personas[i + 1];
            }
            persona[] aux = new persona[Personas.Length - 1];
            for (int i = 0; i < Personas.Length-1; i++)
            {
                aux[i] = Personas[i];

            }
            Personas = aux;

        }
    }
}

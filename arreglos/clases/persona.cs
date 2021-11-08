using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos.clases
{
   public class persona
    {

        public int id { get; set; }
        public string Nombre { get; set; }
        public int Añonac { get; set; }

       

        public bool validar()
        {
            bool res = false;

            if (Añonac > 1900 && Añonac <= DateTime.Now.Year)
            {
                res = true;
            }

            return res ;
        
        }
        
        }
}

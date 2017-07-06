using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class Datos
    {
        public String texto = "Hola";
        public int a = 1;
        public int b = 2;
    }

    public class Metodo : Datos
    {

        public String Concatenar()
        {
            return texto + a + b;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra2
{
    class controlador
    {
        

        public int cantidad(String cadena, int codigo) {
            Int16 largo = 0;
            int resultado = 0;
            cManejoCadenas cadenas = new cManejoCadenas();
            switch (codigo) {
                case 1:
                    //largo = Convert.ToInt16(cadena.Length);
                   resultado = cadenas.tamaño(cadena);
                    break;
                case 2:
                    resultado = cadenas.vocales(cadena);
                    break;
                case 3:
                    resultado = cadenas.consonantes(cadena);
                    break;
                case 4:
                    resultado = cadenas.palabras(cadena);
                    break;
            }
            return resultado; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        /*TODO: 
        Decidir tipo de Valor
        public int Valor { get; set; }
        public String Valor { get; set; }
        */

        // Variable para definir el tipo de disco.
        // 1 -> el más pequeño
        // 2 -> mediano
        // 3 -> más grande
        public Disco(int Valor){

            this.Valor = Valor;
        }

        //getters y setter para obtener y añadir el valor
        public int Valor { get; set; }
    }
}

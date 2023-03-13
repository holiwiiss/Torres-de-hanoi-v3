using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        private int contador = 0;
        /*TODO: Implementar métodos*/
        //movemos de A a B
        public void mover_disco(Pila a, Pila b)
        {
            //Si A está vacio se rellenará A
            if (a.isEmpty())
            {
                // el metodo pop de la clase pila, además de eliminar te devuelve el "identificador"
                //del último listo que hay en esa pila, borrado e introducido en A
                a.push(b.pop());
                contador++;
            }// si B está vacio, se rellenará B y no A 
            else if (b.isEmpty())
            {
                //
                b.push(a.pop());
                contador++;
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}

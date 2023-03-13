using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        //contador de movimientos
        private int contador = 0;
        /*TODO: Implementar métodos*/
        //movemos de A a B
        
        public void mover_disco(Pila a, Pila b)
        {
            //Si A está vacio el disco pasará de B a A
            if (a.isEmpty())
            {
                // el metodo pop de la clase pila, además de eliminar te devuelve el "identificador"
                //del último listo que hay en esa pila, borrado e introducido en A
                a.push(b.pop());
                contador++;
            }// si B está vacio, se rellenará B y no A 
            else if (b.isEmpty())
            {
                b.push(a.pop());
                contador++;
            }// si el diametro del ultimo elemento de la pila A es menor, lo añadiremos a la pila B
            else if(a.Top < b.Top){
                b.push(a.pop() );
                contador++;
            }// si el diametro del ultimo elemento de la pila B es menor, lo añadiremos a la pila A
            else if(b.Top < a.Top) {
                a.push(b.pop() );
                contador++;
            }    
        }
        //Ahora haremos el método para solucionar el juego 
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            //si el número de discos es impar
            if (n % 2 != 0)
            {
                //Mientras que el palo destino no contenga todos los discos, seguiremos haciendo movimientos
                while (fin.Size != n)
                {
                    mover_disco(ini, fin);
                    Console.WriteLine("Movimiento numero: " + contador);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila inicial: " + ini.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila auxiliar: " + aux.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila final: " + fin.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");

                    mover_disco(ini, aux);
                    Console.WriteLine("Movimiento numero: " + contador);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila inicial: " + ini.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila auxiliar: " + aux.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila final: " + fin.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");

                    mover_disco(aux, fin);
                    Console.WriteLine("Movimiento numero: " + contador);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila inicial: " + ini.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila auxiliar: " + aux.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila final: " + fin.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");

                }
            }
            else
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, aux);
                    Console.WriteLine("Movimiento numero: " + contador);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila inicial: " + ini.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila auxiliar: " + aux.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila final: " + fin.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    mover_disco(ini, fin);
                    Console.WriteLine("Movimiento numero: " + contador);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila inicial: " + ini.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila auxiliar: " + aux.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila final: " + fin.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    mover_disco(aux, fin);
                    Console.WriteLine("Movimiento numero: " + contador);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila inicial: " + ini.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila auxiliar: " + aux.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tamaño pila final: " + fin.Size);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");

                    Console.Write("\n");
                }
            }


            return contador;

        }

        

    }
}

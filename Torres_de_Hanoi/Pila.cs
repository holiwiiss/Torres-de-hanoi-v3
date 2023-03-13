using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        /* TODO: Implementar métodos */

        //getters y setters
        public int Size { get; set; }

        public int Top { get; set; }

        public List<Disco> Elementos { get; set; }

        private int numeroDiscos;

        //constructor de la clase pila
        public Pila()
        {
            this.Size = 0;
            this.Top = 0;
            Elementos = new List<Disco>();
        }

        //Con este metodo añadiré un disco 
        public void push(Disco d)
        {
            //se añade a mi pila de discos un disco 
            Elementos.Add(d);
            // Actualizo el tamaño de la pila
            Size = Elementos.Count();
            // y saber cual es el disco que esta arriba del todo
            Top = d.Valor;
        }

        public Disco pop()
        {
            // elimino el último disco
            Disco ultimo = Elementos.Last();
            Elementos.RemoveAt(Elementos.Count - 1);

            // Actualizo el tamaño de la pila
            Size = Elementos.Count();
            
            //Actualizo el top
            if(Elementos.Count() == 0) { 
                // En este caso es 0 porque no hay elementos
                Top= 0;
            }
            else
            {
                //y en este caso devuelvo el último disco, porque si hay elementos 
                Top = Elementos.Last().Valor;
            }

            return ultimo;
        }                

        public bool isEmpty()
        {
            // Si la lista de discos es 0, quiere decir que no hay discos
            if(Elementos.Count() == 0)
            {
                //no hay discos asi que está vacía
                return true;
            }
            else
            {
                //si hay discos
                return false;
            }
            
        }

    }
}

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
        public int Size { get; set; }

        public int Top { get; set; }

        public List<Disco> Elementos { get; set; }

        public Pila()
        {
            this.Size = 0;
            this.Top = 0;
            Elementos = new List<Disco>();
        }


        public void push(Disco d)
        {
            Elementos.Add(d);
            Size = Elementos.Count();
            Top = d.Valor;
        }

        public Disco pop()
        {
            return null;
        }                

        public bool isEmpty()
        {
            return true;
        }

    }
}

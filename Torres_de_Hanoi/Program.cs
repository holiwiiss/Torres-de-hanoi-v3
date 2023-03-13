using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primero creamos las pilas
            Pila inicial = new Pila();
            Pila auxiliar = new Pila();
            Pila final = new Pila();
            //Creamos una variable tipo nuestro algoritmo para poder usar los metodos de la clase
            Hanoi hanoi = new Hanoi();

            //iniciamos el juego
            Console.WriteLine("Bienvenido al juego de las torres Hanoi");
            Console.WriteLine("3 torres");
            // Seleccionamos el numero de discos a utilizar
            Console.WriteLine("Introduce el numero de discos: ");
            int numeroDiscos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Has seleccionado " + numeroDiscos + "discos, ¡Empezamos!");
            //creamos tantos discos como ha solicitado el usuario
            for(int i = numeroDiscos; i>0; i--)
            { //esto es debido a que el disco mas grande tiene que ir al final 
                Disco disco = new Disco(i);
                inicial.push(disco);
            }
            //iniciamos el algoritmo para iniciar el juego 
            hanoi.iterativo(numeroDiscos, inicial, final, auxiliar);


            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

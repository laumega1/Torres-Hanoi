using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Disco> listaDiscos = new List<Disco>();
            // Pedimos que introduzca cuantos discos quiere que hayan
            int numeroDiscos = 0;

            while (numeroDiscos == 0)
            {
                Console.WriteLine("¿Cuantos discos quiere tener?");
                if(!Int32.TryParse(Console.ReadLine(), out numeroDiscos))
                {
                    Console.WriteLine("Introduzca un número");
                }
            }
            Console.WriteLine("hola");

            // Creamos el número de discos que se han pedido y los guardamos en un array
            for (int i = 0; i < numeroDiscos; i++)
            {
                // Creamos un disco
                Disco disco = new Disco(i+1);

                // Añadimos el disco a la lista
                listaDiscos.Add(disco);
            }

            Console.WriteLine(listaDiscos[0].Valor);

        }
    }
}

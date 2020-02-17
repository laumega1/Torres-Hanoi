using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            // Miramos si la pila a o la b están vacias
            if(a.NumeroDiscos == 0 && b.NumeroDiscos>0)
            {
                // Borramos el disco de la pila a y lo añadimos a la pila b
                Disco discoLista = b.pop();
                a.push(discoLista);
            }
            else if(b.NumeroDiscos == 0 && a.NumeroDiscos>0)
            {
                // Borramos el disco de la pila b y lo añadimos a la pila a
                Disco discoLista = a.pop();
                b.push(discoLista);
            }
            else if (a.Elementos[a.NumeroDiscos-1].Valor > b.Elementos[b.NumeroDiscos - 1].Valor)
            {
                // Borramos el disco de la pila b y lo añadimos a la pila a
                Disco discoLista = b.pop();
                a.push(discoLista);
            }
            else if (a.Elementos[a.NumeroDiscos - 1].Valor < b.Elementos[b.NumeroDiscos - 1].Valor)
            {
                // Borramos el disco de la pila a y lo añadimos a la pila b
                Disco discoLista = a.pop();
                b.push(discoLista);
            }
            
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            // Creamos una variable donde almacenar el número de movimientos que se van a hacer
            int m = 0;

            // Si n es impar
            if (n % 2 != 0)
            {
                // Mientras no haya solución
                while(fin.NumeroDiscos != n)
                {
                    m++;
                    mover_disco(ini, fin);
                    m++;
                    mover_disco(ini, aux);
                    m++;
                    mover_disco(aux, fin);
                    Console.WriteLine(fin.NumeroDiscos);
                }
            }
            else
            {
                // Mientras no haya solución
                while (fin.NumeroDiscos != n)
                {
                    m++;
                    mover_disco(ini, aux);
                    m++;
                    mover_disco(ini, fin);
                    m++;
                    mover_disco(aux, fin);
                }
            }
            Console.WriteLine(m);
            return m;
        }
    }
}

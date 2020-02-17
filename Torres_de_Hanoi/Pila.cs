using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int NumeroDiscos { get; set; }
        public List<Disco> Elementos { get; set; }

        /* TODO: Implementar métodos */
        public Pila(List<Disco> elementos)
        {
            Elementos = elementos;
            NumeroDiscos = elementos.Count();
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            NumeroDiscos++;
        }

        public Disco pop()
        {
            Disco discoSacado = Elementos[Elementos.Count - 1];
            Elementos.RemoveAt(Elementos.Count - 1);
            NumeroDiscos--;
            return discoSacado;
        }                

        public bool isEmpty()
        {
            if (Elementos.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

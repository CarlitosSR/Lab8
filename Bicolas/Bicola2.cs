using Lab8.Nodos;

namespace Lab8.Bicolas
{
    internal class Bicola2
    {
        private Nodo frente;
        private Nodo fin;

        public Bicola2()
        {
            frente = null;
            fin = null;
        }

        public Nodo getFrente()
        {
            return frente;
        }

        public void EncolarFinal(int valor)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = valor;
            nuevoNodo.sgte = null;

            if (frente == null)
            {
                frente = nuevoNodo;
                nuevoNodo.ant = null;
            }
            else
            {
                fin.sgte = nuevoNodo;
                nuevoNodo.ant = fin;
            }
            fin = nuevoNodo;
        }

        public void EncolarFrente(int valor)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = valor;
            nuevoNodo.ant = null;

            if (frente == null)
            {
                fin = nuevoNodo;
                nuevoNodo.sgte = null;
            }
            else
            {
                frente.ant = nuevoNodo;
                nuevoNodo.sgte = frente;
            }
            frente = nuevoNodo;
        }

        public int DesencolarFrente()
        {
            if (frente == null)
                throw new InvalidOperationException("La bicola está vacía. No se puede desencolar.");

            Nodo aux = frente;
            int valor = aux.dato;

            if (frente == fin)
            {
                frente = null;
                fin = null;
            }
            else
            {
                frente = frente.sgte;
                if (frente != null)
                    frente.ant = null;
            }
            aux = null;
            return valor;
        }

        public int DesencolarFinal()
        {
            if (fin == null)
                throw new InvalidOperationException("La bicola está vacía. No se puede desencolar.");

            Nodo aux = fin;
            int valor = aux.dato;

            if (frente == fin)
            {
                frente = null;
                fin = null;
            }
            else
            {
                fin = fin.ant;
                if (fin != null)
                    fin.sgte = null;
            }
            aux = null;
            return valor;
        }
    }
}

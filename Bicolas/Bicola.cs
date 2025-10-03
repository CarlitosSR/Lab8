using Lab8.Nodos;

namespace Lab8.Bicolas
{
    internal class Bicola
    {
        private Nodo frente;
        private Nodo fin;

        public Bicola()
        {
            frente = null;
            fin = null;
        }
        public Nodo getFrente()
        {
            return frente;
        }
        public void EncolarFinal ( int valor )
        {
            Nodo nuevoNodo;
            nuevoNodo = new Nodo();
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
        public void EncolarFrente (int valor)
        {
            
                Nodo nuevoNodo;
                nuevoNodo = new Nodo();
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
                frente.ant = null;
            }
            aux = null;
            return valor;
        }
        public int DesencolarFinal()
        {
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
                fin.sgte = null;
            }
            aux = null;
            return valor;

        }
    }
}

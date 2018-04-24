using System;

namespace Lab7
{
    public class Program
    {
        class Node
        {
            public int info;
            public Node izq, der;
        }
        Node raiz;

        public Program()
        {
            raiz = null;
        }
        public void Insertar (int info)
        {
            Node nuevo;
            nuevo = new Node();
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Node anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)
                    {
                        reco = reco.izq;
                    }
                    else
                    {
                        reco = reco.der;
                    }
                }
                if (info < anterior.info)
                {
                    anterior.izq = nuevo;
                }
                else
                {
                    anterior.der = nuevo;
                }
            }
        }

        private void ImprimirPre(Node reco)
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                ImprimirPre(reco.izq);
                ImprimirPre(reco.der);
            }
        }

        public void ImprimirPre()
        {
            ImprimirPre(raiz);
            Console.WriteLine();
        }

        internal static void Main(string[] args)
        {
            Program ab = new Program();
            Console.WriteLine("Node Padre: 100");
            ab.Insertar(100);
            Console.WriteLine("Node Hijo Izq: 25");
            ab.Insertar(25);
            Console.WriteLine("Node Hijo Der: 150");
            ab.Insertar(150);
              
            Console.WriteLine("Impresion Arbol Binario");
            ab.ImprimirPre();

            Console.ReadKey();
        }
    }
}

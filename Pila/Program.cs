using System;
using System.Collections.Generic;

namespace Pila
{

    interface IStack
    {
        void Push(int valor);
        bool IsEmpty { get; }
        int Pop();
    }

    class StackA : IStack
    {

        List<int> pilaa = new List<int>();
        public int index = 0;
       
        public void Push(int value)
        {
            pilaa.Add(value);
            index = (pilaa.Count);
           
        }

        public bool IsEmpty
        {
            get
            {
                if(index <= 0)
                {
                    Console.WriteLine("Menor ");
                    return true; //  falta CODIGO
                }
                else
                {
                    Console.WriteLine("Mayor ");
                    return false;
                }
            }
        }

        public int Pop()
        {
            //pilaa.RemoveAt(index-1);
           // index = index - 1;
            return pilaa[--index];
            
        }
    }

    class StackB : IStack
    {
        List<int> pilab = new List<int>();
        public int i = 0;


        public void Push(int value)
        {
            pilab.Add(value);
            i = pilab.Count;
        }

        //public bool IsEmpty => pilab.Count == 0 ? true : false;
        public bool IsEmpty => i == 0 ? true : false;

        public int Pop()
        {
            i = i - 1;
            return pilab[i];
        }
    }
    class Stack : IStack
    {
        int[] pila = new int[100];
        int cantidad = 0;
        public void Push(int valor)
        {
            pila[cantidad++] = valor;
        }

        public bool IsEmpty => cantidad == 0;

        public int Pop()
        {
            
            return pila[--cantidad];
        }


    }
    class Program
    {

        static void Main(string[] args)
        {

            var s = new StackB();
            s.Push(10);
            s.Push(20);
            s.Push(30);

           // while (!s.IsEmpty) // FALSE
           while(!s.IsEmpty)
            {
                Console.WriteLine(s.Pop());
            }
            Console.Read();

        }
    }
}

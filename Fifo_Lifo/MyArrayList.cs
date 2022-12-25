using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo
{
    class MyLifo<T>
    {
        int index=0;
        T[] data = new T[8]; //Node tipi

        public void Print()
        {
            for (int i = 0; i < index; i++)   // = olmaz bir şey yazmak zorunda kalır.
                Console.Write(data[i]);
            Console.WriteLine();
        }

        public T Pull()
        {
            if(index == -1)
                return default(T);
            index--;
            return data[index+1];
        }

        public bool Push(T data)
        {
            
            if(index >= this.data.Length) return false;
            this.data[index] = data;
            index++;
            return true;



        }
    }
    class MyFifo : IBaseList
    {
        int index = 0;
        int[] data = new int[8];
        public void Print()
        {
            for (int i = 0; i < index; i++)   // = olmaz bir şey yazmak zorunda kalır.
                Console.Write(data[i]);
            Console.WriteLine();
        }

        public int Pull()
        {
            var x = data[0];

            for(int i=0; i<index; i++)
            {
                data[i] = data[i+1];
            }
                
                

            index--;
            return x;
        }

        public bool Push(int data)
        {
            if (index >= this.data.Length) return false;
            this.data[index] = data;
            index++;
            return true;
        }
    }
}

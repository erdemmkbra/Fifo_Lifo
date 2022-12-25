using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo
{
    interface IBaseList
    {
        bool Push(int data);
        int Pull();
        void Print();
    }
    class Lifo : IBaseList
    {
        int size=8 ;
        int index=0 ;
        
        int[] data = new int[8];

            public bool Push(int data)
            {
                if (index >= 8) return false;

                this.data[index] = data;
                index++;
                return true;

            }

            public int Pull()
            {
                index--;
                return data[index + 1];

            }

            public void Print()
        {
            foreach (int i in data)
            { 
                Console.Write( i + " ");
            }
        }



        

    }
    class Fifo : IBaseList
    {
        int size = 8;
        int index = 0;

        int[] data = new int[8];

        public bool Push(int data)
        {
            if (index >= 8) return false;

            this.data[index] = data;
            index++;
            return true;

        }

        public int Pull()
        {


            data[index] = data[index + 1];
            return 0;
           
        }

        public void Print()
        {
            foreach (int i in data)
            {
                Console.Write(i + " ");
            }
        }
    }

}

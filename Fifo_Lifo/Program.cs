    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            //myLinkedList.AddLast(5);
            //myLinkedList.AddLast(6);
            //myLinkedList.AddLast(7);
            //myLinkedList.Print();
            //myLinkedList.RemoveLast();
            //myLinkedList.Print();
            //Console.WriteLine();

            //myLinkedList.AddFirst(3);
            //myLinkedList.AddFirst(9);
            //myLinkedList.AddFirst(8);
            //myLinkedList.Print();
            //myLinkedList.RemoveFirst();
            //myLinkedList.Print();

            Console.WriteLine("Sorting");
            //myLinkedList = new MyLinkedList();
            //myLinkedList.AddSortingList(12);
            //myLinkedList.AddSortingList(3);
  
            //myLinkedList.AddSortingList(5);

   
            myLinkedList.AddWithSort(3);
            myLinkedList.AddWithSort(4);
            myLinkedList.AddWithSort(6);
            myLinkedList.AddWithSort(8);
            myLinkedList.AddWithSort(5);
            myLinkedList.AddWithSort(7);
            myLinkedList.AddWithSort(2);
            myLinkedList.AddWithSort(9);




            myLinkedList.Print();

            Console.ReadLine();




            //Console.WriteLine("Fifo:");
            //myLinkedList = new MyLinkedList();
            //myLinkedList.AddLast(3);
            //myLinkedList.AddLast(4);
            //myLinkedList.AddLast(5);
            //myLinkedList.Print();
            //myLinkedList.RemoveFirst();
            //myLinkedList.Print();
            //myLinkedList.RemoveFirst();
            //myLinkedList.Print();


            //Console.WriteLine("Lifo");
            //myLinkedList = new MyLinkedList();
            //myLinkedList.AddLast(6);
            //myLinkedList.AddLast(7);
            //myLinkedList.AddLast(8);
            //myLinkedList.Print();
            //myLinkedList.RemoveLast();
            //myLinkedList.Print();
            //myLinkedList.RemoveLast();
            //myLinkedList.Print();


            //Console.WriteLine();
            //myfifo Myfifo = new myfifo();
            //Myfifo.push(3);
            //Myfifo.push(4);
            //Myfifo.push(5);
            //Myfifo.push(6);
            //Myfifo.Print();

            //Myfifo.pull();
            //Myfifo.Print();


            //MyLifo <int> mylifo = new MyLifo <int> ();
            //mylifo.Print();
            //mylifo.Push(5);
            //mylifo.Print();
            //mylifo.Push(3);
            //mylifo.Push(7);
            //mylifo.Print();
            //mylifo.Pull();
            //mylifo.Pull();
            //mylifo.Pull();
            //mylifo.Pull();
            //mylifo.Pull();
            //mylifo.Pull();


            //mylifo.Print();

            //MyFifo myFifo = new MyFifo();
            //myFifo.Push(5);
            //myFifo.Push(3);
            //myFifo.Push(7);
            //myFifo.Print();
            //myFifo.Pull();
            //myFifo.Print();







        }
    }
}

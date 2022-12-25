using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo
{
    public class Node
    {
        public int data;
        public int nodeId;
        public Node next = null;
 

        public Node(int data,int nodeId)
        {
            this.data = data;
            this.nodeId = nodeId;   

        }

    }
    public class MyLinkedList
    {
        Node root = null;

        public MyLinkedList()
        {
            
        }

        public void AddLast(int data) //en son eleman ekleme
        {
            if (root == null)
                root = new Node(data, 0);
            else
            {
                Node n = root;
                while(n.next != null)//kaç defa döndüğünü bilmediğimizden
                {
                    
                    n = n.next;

                }
                n.next = new Node(data, 0);
                

            }
            return;

        }
        public int Search(int data)
        {
            Node n = root;
            while (n.next != null)//kaç defa döndüğünü bilmediğimizden  
            {
                if (n.data == data)
                    return n.nodeId;
                n = n.next;
                
            }
            return -1;//nodeıd -1 olamaz.
        }

        public void AddMiddle(int data)
        {
            Node newItem = new Node(data,0);
            int index = Count()/2;
            Node n = root;
            int x = 0;
            while (n.next != null)
            {
                x++;
                if(x == index)
                {
                    break;
                }
                n = n.next;
            }
            newItem.next = n.next;
            n.next = newItem;

        }

        public int Count()
        {
            int count = 0;
            Node n = root;
            if(root == null)
                return count;

            while (n.next != null) 
            {
                count++;
                n = n.next;

            }
            return count;
        }


        public void AddFirst(int data)
        {
            if (root == null)
                root = new Node(data, 0); // 0 lar yerine static değişken yaz
            else
            {
              
                Node newNode = new Node(data, 0);
                newNode.next = root;
                root = newNode;
                Node n = root;

            }

        }


        public void AddWithSort(int data)
        {
            if (root == null)
                root = new Node(data, 0);
            else
            {
                Node newNode = new Node(data, 0);
                Node n = root;

                if (root.data < newNode.data)
                {
                    newNode.next = root;
                    root = newNode;
                    return;
                }
                while (n != null)
                {
                    if (n.data >= newNode.data && (n.next == null || (n.next != null && n.next.data < newNode.data)) )
                    {
                        newNode.next = n.next;
                        n.next = newNode;
                        return;
                    }
                    n = n.next;
                }
            }
        }

        public void AddSortingList(int data)
        {
            if (root == null)
                root = new Node(data, 0);

            else
            {
                Node n = root;

                if (n.next == null)
                {
                    Node newNode = new Node(data, 0);

                    if (n.data > newNode.data)
                    {
                        AddLast(data);

                    }

                    else
                    {
                        AddFirst(data);
                    }
                }

                while (n.next != null)
                {


                    Node newNode = new Node(data, 0);
                    if (n.data > newNode.data && n.next.data < newNode.data) //4 Bu yapıyı gezdir
                    {
                        newNode.next = n.next;
                        n.next = newNode;


                    }
                    else if (n.data < newNode.data) // 6
                    {
                        AddFirst(data);

                    }
                    else if (n.data > newNode.data && n.next.data > newNode.data)
                    {
                        AddLast(data);

                    }
                    return;

                }
            }
        }

        private Node NewNode(Node diz)
        {
            throw new NotImplementedException();
        }

        public Node RemoveLast()
        {
            Node temp = null;
            Node n = root;
            if (n == null)
                return null; //class default null
            if (n.next == null)
                n = null;
            while (n.next.next != null)//kaç defa döndüğünü bilmediğimizden
            {
                n = n.next;
            }
            temp = n.next;
            n.next = null;
            return temp;


        }

        public Node RemoveFirst()
        {
            Node temp = root;
            if (root != null)
            {
                root = root.next;
            }
            return temp;
        }

        public void Print()
        {
            Node n = root;
            while (n.next != null)//kaç defa döndüğünü bilmediğimizden
            {
                Console.Write(n.data + " ");
                n = n.next;

            }
            Console.Write(n.data + " ");
            Console.WriteLine();

        }

    }


    public class myfifo
    {
        MyLinkedList myLinkedList;

        public myfifo()
        {
            myLinkedList = new MyLinkedList();

        }
        public void push(int data)
        {
            myLinkedList.AddLast(data);

            
        }
        public int pull()
        {
            var node = myLinkedList.RemoveFirst();
            return node.data;
        }
        public void Print()
        {
            myLinkedList.Print();
        }
        
        

    }
}
//sıralı ekleme,static değişken
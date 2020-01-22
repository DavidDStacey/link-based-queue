using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Link_Based_Queue
{
    class Queue
    {
        Node front;
        Node rear;

        public void LinkListQueue()
        {
            this.front = this.rear = null;
        }


        internal void Enqueue(int item)
        {
            Node newNode = new Node(item);

            // if empty then front and rear 
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                // add to end 
                this.rear.Next = newNode;
                this.rear = newNode;
            }
            WriteLine("\n{0} inserted into Queue\n", item);
        }

        internal void Dequeue()
        {
            // checks if empty 
            if (this.front == null)
            {
                WriteLine("The Queue is empty\n");
                return;
            }

            Node temp = this.front;
            this.front = this.front.Next;

            if (this.front == null)
            {
                this.rear = null;
            }

            WriteLine("\nItem deleted is {0}\n", temp.Data);
        }
        //print queue then exit
        public void PrintQueue()
        {         
            if (front != null)
            {
                Write("\nThe current queue is: ");
                while (front != null)
                {
                    Write(front.Data + " ");
                    front = front.Next;
                }
                WriteLine("\n\nPress any key to exit.");
                ReadKey();
                Environment.Exit(0);
            }
            else
            {
                WriteLine("Empty List\n");
            }
        }
        //play peekaboo with queue
        public void Peek()
        {
            if (front != null)
            {
                WriteLine("\nThe current front of the queue is: {0}\n", front.Data);
            }
            else
            {
                WriteLine("\nEmpty List\n");
            }
        }
    }
}

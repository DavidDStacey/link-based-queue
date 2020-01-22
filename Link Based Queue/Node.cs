using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_Based_Queue
{
    class Node
    {

        private int data;
        private Node next;


        // Constructorss 
        public Node(int d)
        {
            data = d;
            next = null;
        }

        public int Data { get => data; set => data = value; }
        internal Node Next { get => next; set => next = value; }
    }
}


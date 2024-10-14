using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyCircularLinkedList
{
    internal class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }
        public Node? Prev {  get; set; }

        public Node() 
        {
            Value = 0;
            Next = null;
            Prev = null;
        }   

        public Node (int value) 
        {
            Value = value;
            Next = null;
            Prev = null;
        }

        public override string ToString()
        {
            return Value.ToString()+ ",";
        }

    }
}

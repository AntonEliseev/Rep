using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{


    class Queue
    {
        class MyNode
        {
            public object data;
            public MyNode next;
            public MyNode(MyNode next, object i)
            {
                data = i;
                this.next = next;
            }
        }
        MyNode top;
        MyNode tail;
        public int Count { get; private set; }
        public void Push(object data)
        {
            MyNode temp = new MyNode(null, data);
            if (Empty())
            {
                tail = temp;
                top = temp;
            }
            else
            {
                tail.next = temp;
                tail = temp;
            }
            Count++;
        }

        public object Pop()
        {
            if (top == null)
                return null;
            object result = top.data;
            top = top.next;
            Count--;
            return result;

        }
        public bool Empty()
        {
            if (top == null)
                return true;
            else
                return false;
        }
    }

}

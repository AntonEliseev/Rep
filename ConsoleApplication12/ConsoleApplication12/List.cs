using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Node //класс узла
    {
        public int inf;
        public Node next;
        public Node(int inf, Node next)
        {
            this.inf = inf;
            this.next = next;
        }
    }
    public class MyList // Класс списка
    {
        public Node head;
        public int count;
        public MyList()
        {
            head = null;
            count = 0;
        }

        public void Add(int inf) //Добавление элемента в конец списка
        {
            if (head == null)
            {
                head = new Node(inf, null);
            }
            else
            {
                Node p = head;
                while (p.next != null) p = p.next;
                p.next = new Node(inf, null);
            }
            count++;
        }
        public void Delete(int index) // Удалить по индексу
        {
            if (index != 0)
            {
                Node p = head;
                for (int i = 0; i < index - 1; i++)
                    p = p.next;
                if (p.next != null)
                    p.next = p.next.next;
            }
            else
                head = head.next;
            count--;
        }
        public void Insert(int index, int val) // Вставить элемент в позицию с указанным индексом
        {
            if (index != 0)
            {
                Node p = head;
                for (int i = 0; i < index; i++)
                    p = p.next;
                Node q = new Node(val, p.next);
                p.next = q;
            }
            else
            {
                Node q = new Node(val, head);
                head = q;
            }
            count++;
        }
        public Node GetNode(int index)//нахождение узла
        {
            if (index < count)
            {
                Node p = head;
                for (int i = 0; i < index; i++)
                    p = p.next;
                return p;
            }
            else
            {
                IndexOutOfRangeException ex = new IndexOutOfRangeException();
                throw (ex);
            }
        }
        public object GetVal(int index)//возвращение значения узла
        {
            Node p = GetNode(index);
            return p.inf;
        }
        public void Print() // Вывод списка
        {
            Node p = head;
            while (p != null)
            {
                Console.Write("{0} ", p.inf);
                p = p.next;
            }
        }
    }
}

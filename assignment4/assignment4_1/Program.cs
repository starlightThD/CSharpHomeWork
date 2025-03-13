using System;
using System.Runtime.CompilerServices;

namespace assignment4_1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            for(Node<T> node = head;node != null;node = node.Next)
            {
                action(node.Data);
            }
        }
    }
    public class assignment4_1
    {
        public static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for(int x= 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            for(Node<int> node = intlist.Head;node != null;node = node.Next)
            {
                Console.WriteLine(node.Data);
            }
            GenericList<string> strlist = new GenericList<string>();
            for(int x= 0; x < 10; x++)
            {
                strlist.Add("str" + x);
            }
            for(Node<string> node = strlist.Head;node != null;node = node.Next)
            {
                Console.WriteLine(node.Data);
            }
            Console.WriteLine("Output strlist using method ForEach:");
            strlist.ForEach(m => Console.WriteLine(m));
            Console.WriteLine("Output intlist max,min,sum using method ForEach:");
            int min = 0x3f3f3f3f;
            intlist.ForEach(m => min = Math.Min(min, m));
            int max = -0x3f3f3f3f;
            intlist.ForEach(m => max = Math.Max(max, m));
            int sum = 0;
            intlist.ForEach(m => sum += m);
            Console.WriteLine($"max = {max},min = {min},sum = {sum}");
        }
    }
}
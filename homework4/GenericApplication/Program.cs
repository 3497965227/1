using GenericApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication {

  // 链表节点
  public class Node<T> {
    public Node<T> Next { get; set; }
    public T Data { get; set; }

    public Node(T t) {
      Next = null;
      Data = t;
    }
  }

  //泛型链表类
  public class GenericList<T> {
    private Node<T> head;
    private Node<T> tail;

    public GenericList() {
      tail = head = null;
    }

    public Node<T> Head {
      get => head;
    }

    public void Add(T t) {
      Node<T> n = new Node<T>(t);
      if (tail == null) {
        head = tail = n;
      }else {
        tail.Next = n;
        tail = n;
      }
    }

        public static void ForEach(GenericList<T> t, Action<T> action)

        {

            Node<T> a = t.Head;

            while (a != null)

            {

                action(a.Data);

                a = a.Next;

            }

        }

    }
}

  class Program {
        static void Main(string[] args)
        {
      // 整型List
      GenericList<int> intlist = new GenericList<int>();
      for (int x = 0; x < 10; x++) {
        intlist.Add(x);
      }
        /*for (Node<int> node = intlist.Head; 
              node != null; node = node.Next) {
          Console.WriteLine(node.Data);
        }
        */
        int sum = 0, max = 0, min = 0;

        GenericList<int>.ForEach(intlist, m => Console.Write($"{ m}"));
        Console.WriteLine("");
        GenericList<int>.ForEach(intlist, m => sum += m);
        GenericList<int>.ForEach(intlist, m => max = max < m ? m : max);
        GenericList<int>.ForEach(intlist, m => min = min > m ? m : min);
        Console.WriteLine($"max is{max},min is {min},sum is {sum}");
       



    }
   

  }

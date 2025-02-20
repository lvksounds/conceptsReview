using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorythmsAndDataEstructs.Challenges
{
    /*
    Listas encadeadas sao estruturas mais flexiveis que arrays.
    Elas possuem varios usos e implementações.
    Basicamente, sao compostas de Nós, um tipo que possue duas informações (campos): 
    o valor, ou o dado em si que aquele nó armazena e o proximo Nó (referencia).
    Listas encadeadas podem crescer de maneira livre e também nao necessitam de 
    alocação de memoria previa como os arrays. 
    
    */
    public class Node<T>
    {
        public T? Data {get; set;}
        public Node<T>? Next {get; set;}
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
    public class MyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> previous;
        
        public void Add(T data)
        {
            var newNode = new Node<T>(data);
            if(head == null) head = newNode;
            else
            {
                 
                var current = head;
                while(current.Next != null)
                {
                    previous = current;   
                    current = current.Next;
                }
                current.Next = newNode;
                
            }
        }

        public void Display()
        {
            var current = head;
            var previous = head;
            while(current != null)
            {
                Console.WriteLine($"Current: {current.Data }");
                Console.WriteLine($"previous: {previous.Data}");
                previous = current;
                current = current.Next;
            }
            Console.WriteLine();
        }
        public void RevertList() {
             var current = head;
             var previous = head;
             List<T> nums = new List<T>();
             while(current != null)
             {
               nums.Add(current.Data);
               current = current.Next;
             }
             for (var i = nums.ToArray().Length ; i > 0; i--) 
             {
                Console.WriteLine(nums[i - 1]);
             }
        }
    }
}
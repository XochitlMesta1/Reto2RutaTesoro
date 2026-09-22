using System;
using System.Collections.Generic;

namespace Reto2RutaTesoro
{
    public class ListaSimple
    {
        private Node? head;

        public Node? Head => head;
        public bool IsEmpty => head == null;

        public void Insert(int id, string name, string hint, int dangerLevel)
        {
            if (Find(id) != null)
                throw new InvalidOperationException($"A location with ID {id} already exists.");

            Node newNode = new Node(id, name, hint, dangerLevel);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public Node? Find(int id)
        {
            Node? current = head;
            while (current != null)
            {
                if (current.Id == id)
                    return current;
                current = current.Next;
            }
            return null;
        }

        public bool Update(int id, string name, string hint, int dangerLevel)
        {
            Node? node = Find(id);
            if (node == null)
                return false;

            node.Name = name;
            node.Hint = hint;
            node.DangerLevel = dangerLevel;
            return true;
        }

        public bool Delete(int id)
        {
            if (head == null)
                return false;

            if (head.Id == id)
            {
                head = head.Next;
                return true;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Id == id)
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public List<Node> Traverse()
        {
            List<Node> result = new List<Node>();
            Node? current = head;
            while (current != null)
            {
                result.Add(current);
                current = current.Next;
            }
            return result;
        }

        public int Count()
        {
            int count = 0;
            Node? current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public void Clear()
        {
            head = null;
        }
    }
}

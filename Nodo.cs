using System;
using System.Collections.Generic;
using System.Text;
namespace Reto2RutaTesoro
{
    public class Node
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }
        public int DangerLevel { get; set; }
        public Node? Next { get; set; }

        public Node(int id, string name, string hint, int dangerLevel)
        {
            Id = id;
            Name = name;
            Hint = hint;
            DangerLevel = dangerLevel;
            Next = null;
        }
    }
}
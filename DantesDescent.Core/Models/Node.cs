using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DantesDescent.Core.Models
{
    public abstract class Node
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public Transform Transform { get; set; } = new();

        public Node Parent { get; set; }
        public List<Node> Children { get; set; }

        public HashSet<string> Tags { get; set; }

        public Node(string name = "Node", Node parent = null)
        {
            Name = name;
            Parent = parent;
        }

        // Events
        protected virtual void Initialise() { }
        protected virtual void Draw() { }
        protected virtual void Update() { }
    }
}
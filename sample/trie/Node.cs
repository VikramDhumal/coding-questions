using System.Collections.Generic;

namespace trie
{
    public class Node
    {
        public char Value { get; set; }
        public List<Node> Children { get; set; }

        public Node(char value)
        {
            Value = value;
            Children = new List<Node>();
        }
    }
}

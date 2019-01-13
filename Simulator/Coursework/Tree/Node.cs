using System.Collections.Generic;

namespace Coursework
{
    class Node
    {
        private Leaf leaf;

        public Dictionary<string, Node> Children { get; set; }
        public Node SuffixLink { get; set; }
        public int Start { get; set; }
        public int End { get => leaf.LeafValue; }
        public int EdgeLength { get => End - Start + 1; }


        public Node(SuffixTree tree, int start, Leaf end)
        {
            SuffixLink = tree.Root;
            Start = start;
            leaf = end;
            Children = new Dictionary<string, Node>();
        }
    }

}
;


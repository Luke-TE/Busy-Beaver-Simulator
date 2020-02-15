using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{    
    class SuffixTree
    {
        private Leaf LeafEnd; //move this to build subroutine
        private Node ActiveNode;
        private int ActiveEdge;
        private int ActiveLength; 

        public List<string> Actions { get; set; }
        public Node Root { get; set; }


        public SuffixTree(List<string> actions)
        {            
            Actions = actions;            
            LeafEnd = new Leaf(0);
            Root = new Node(this, -1, new Leaf(-1));
            
            Build(0, Actions.Count);
        }

        public void Build(int initialPosition, int suffixes, string terminationChar = "$")
        {
            Actions.Add(terminationChar);            
            ActiveNode = Root;
            int SuffixesLeft = 0;

            for (int position = initialPosition; position < suffixes + initialPosition; position++)
            {
                Node newestNode = null;
                LeafEnd.LeafValue = position;
                SuffixesLeft++;


                while (SuffixesLeft > 0)
                {
                    if (ActiveLength == 0)
                        ActiveEdge = position;

                    if (!ActiveNode.Children.ContainsKey(Actions[ActiveEdge]))
                    {
                        ActiveNode.Children.Add(Actions[ActiveEdge], new Node(this, position, LeafEnd));

                        if (newestNode != null)
                        {
                            newestNode.SuffixLink = ActiveNode;
                            newestNode = null;
                        }
                    }

                    else
                    {
                        Node nextNode = ActiveNode.Children[Actions[ActiveEdge]];
                        if (ActiveLength >= nextNode.EdgeLength)
                        {
                            ActiveEdge += nextNode.EdgeLength;
                            ActiveLength -= nextNode.EdgeLength;
                            ActiveNode = nextNode;
                            continue;
                        }

                        if (Actions[nextNode.Start + ActiveLength] == Actions[position])
                        {
                            if (newestNode != null && ActiveNode != Root)
                            {
                                newestNode.SuffixLink = ActiveNode;
                                newestNode = null;
                            }

                            ActiveLength++;

                            break;
                        }

                        int splitEnd = nextNode.Start + ActiveLength - 1;
                        Node splitNode = new Node(this, nextNode.Start, new Leaf(splitEnd));

                        ActiveNode.Children[Actions[ActiveEdge]] = splitNode;
                        splitNode.Children[Actions[position]] = new Node(this, position, LeafEnd);
                        nextNode.Start += ActiveLength;
                        splitNode.Children[Actions[nextNode.Start]] = nextNode;

                        if (newestNode != null)
                            newestNode.SuffixLink = splitNode;

                        newestNode = splitNode;
                    }

                    SuffixesLeft--;

                    if (ActiveNode == Root && ActiveLength > 0)
                    {
                        ActiveLength--;
                        ActiveEdge = position - SuffixesLeft + 1;
                    }

                    else if (ActiveNode != Root)
                        ActiveNode = ActiveNode.SuffixLink;

                }
            }

            Actions.Remove(terminationChar);

        }

        public bool CheckIfRecurring()
        {
            if (Root.Children.Count <= 3)
                return true;
                        
            int greatestDepth = TraverseTree(Root) - 1;            
            return greatestDepth > Actions.Count / 2;
        }

        private int TraverseTree(Node node)
        {            
            if (node.Children.Count == 0)
                return 0;
            return node.Children.Values.Max(x => TraverseTree(x)) + node.EdgeLength;
        }

    }

}
;


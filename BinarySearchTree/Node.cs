using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int info;
        public Node left;
        public Node right;

        public Node(int info)
        {
            this.info = info;
            left = null;
            right = null;
        }
    }
}

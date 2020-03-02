using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
         public Node rootNode;
         public Node currentNode;

        public BinaryTree()
        {
            rootNode = null;
        }
        public void Add(int info)
        {
            Node temporaryNode = new Node(info);

            if (rootNode == null)
            {
                rootNode = temporaryNode;
                this.currentNode = rootNode;
                return;
            }
            if (info > currentNode.info)
            {
                if (currentNode.right == null)
                {
                    currentNode.right = temporaryNode;
                }
                else
                {
                    currentNode = currentNode.right;
                    Add(info);
                }
            }
            else if (info < currentNode.info)
            {
                if (currentNode.left == null)
                {
                    currentNode.left = temporaryNode;

                }
                else
                {
                    currentNode = currentNode.left;
                    Add(info);
                }
            }
            currentNode = rootNode;
        }
        public bool SearchTree(int info)
        {
            
            Node foundNode = currentNode;
            while (foundNode != currentNode)
            {
                if (info < foundNode.info)
                {
                    foundNode = foundNode.left;
                }
                else if (info > foundNode.info)
                {
                    foundNode = foundNode.right;
                }
                else if (info == foundNode.info)
                {
                    return true;
                
                }
            }
            return false;
        }
        
    }
}

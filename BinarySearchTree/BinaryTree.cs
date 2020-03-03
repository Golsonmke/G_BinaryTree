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

            Node tempNode = rootNode;
            while (true)
            {
                if (tempNode.info == info)
                {
                    return true;

                }
                else if (info < tempNode.info)
                {
                    if (tempNode.left == null)
                    {
                        return false;
                    }
                    else
                    {
                        tempNode = tempNode.left;
                    }


                }
                else if (info > tempNode.info)
                {
                    if (tempNode.right == null)
                    {
                        return false;
                    }
                    else
                    {
                        tempNode = tempNode.right;
                    }
                }

                

            }
            
          
           
            
            
        }
       
    }
}

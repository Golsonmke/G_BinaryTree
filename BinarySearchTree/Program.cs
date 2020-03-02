using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(45);
            binaryTree.Add(43);
            binaryTree.Add(25);
            binaryTree.Add(23);
            binaryTree.Add(67);

            Console.WriteLine("Was it found? " +  binaryTree.SearchTree(25));
            Console.ReadLine();

        }
    }
}

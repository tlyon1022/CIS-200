// Prog 5
// 4-21-2020
// T7938
// File Test.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Prog5
{
    class Test
    {
        static void Main() 
        {
            
            int[] intArray = { 9, 4, 10, 43, 54, 32, 99, 12, 32, 1}; // array of ints
            double[] doubleArray = { 5.5, 7.3, 7.2, 9.8, 10.3, 23.3, 32.0, 22, 90.1, 45.4 }; //array of doubles
            string[] stringArray =
               {"sixty-six", "twenty-two", "three", "six", "twelve", "one", "five", "ten", "seven", "forty"}; // array of strings

            // create int Tree
            var intTree = new Tree<int>(); // new generic int tree
            var doubleTree = new Tree<double>(); // new generic double tree
            var stringTree = new Tree<string>(); // new generic string tree
            PopulateTree(intArray, intTree, nameof(intTree)); // invoke population of tree
            TraverseTree(intTree, nameof(intTree)); // inorder traversal
            Pause();
            PopulateTree(doubleArray, doubleTree, nameof(doubleTree)); // invoke population of tree
            TraverseTree(doubleTree, nameof(doubleTree)); // inorder traversal
            Pause();
            PopulateTree(stringArray, stringTree, nameof(stringTree)); // invoke population of tree
            TraverseTree(stringTree, nameof(stringTree)); // inorder traversal



        }

        // populate Tree with array elements
        private static void PopulateTree<T>(Array array, Tree<T> tree, string name) where T : IComparable<T>
        {
            Console.WriteLine($"\n\n\nInserting into {name}:");
            // insert each node into tree
            foreach (T data in array)
            {
                Console.Write($"{data} ");
                tree.InsertNode(data);
            }
        }

        // perform traversals
        private static void TraverseTree<T>(Tree<T> tree, string treeType) where T : IComparable<T>
        {

            // perform inorder traversal of tree
            Console.WriteLine($"\n\nInorder traversal of {treeType}");
            tree.InorderTraversal();

         
        }
        // pause program 
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Clear(); // Clear screen
        }
    }
}


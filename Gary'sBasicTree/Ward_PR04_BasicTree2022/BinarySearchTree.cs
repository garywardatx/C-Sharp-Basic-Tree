/*********************************************************************************************************

 * Project: Basic Trees
 * 
 * File: Binary Search Tree Class
 * 
 * Langauge: VS C#
 * 
 *
 *
 * Description: This class implements the binary search tree.
 * 
 *
 * College: Husson University
 * 
 * Course:  IT 325
 * 
 * Author: Gary Edward Ward
 * 
 * 
 * 
 * Change Log:
 * 
 * Date                         Description of Change
 * 
 * ---------------           ----------------------------------------------------------------------------
 * 
 * 2/17/2022               - Initial writing
 * 2/17/2022               - Added regions
 * 2/23/2022               - Added properties
 * 2/23/2022               - Added Insert method to add items into the binary search tree
 * 2/26/2022               - Revised Insert method
 * 2/26/2022               - Added a Min and Max method
 * 2/26/2022               - Working on displaying items from the file using Insert Method and 
 *                           IterateInOrder. These methods now compile without errors but do not display
 *                           data.
 * 2/26/2022               - Working on displaying countNode, Max, and Min functions.                          
 * 2/26/2022               - Need to come back to postorder, preorder, and depth traversal. Spent too much
 *                           time trying to figure out the integration of the insert method and display 
 *                           routines. 
 * 
 * 
 * 
 * 
*********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ward_PR04_BasicTree2022 {
    class BinarySearchTree {

        #region Constants
        #endregion Constants

        #region Data Members

        #endregion Data Members

        #region Properties

        public int Count;                       // the number of nodes in the file

        public Node Parent { get; set; }        // Pointer to the parent node
        private Node Current { get; set; }      // pointer to the current node
        public Node Root { get; set; }          // Pointer to the root of the tree

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Constructor for the binary search tree.
        /// </summary>
        public BinarySearchTree() {
            Root = null;
            Parent = null;
            Count = 0;
        }

        #endregion Constructor

        #region Events

        #endregion Events

        #region Methods

        /// <summary>
        /// Returns the number of nodes in the binary search tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public void nodeCount(ListBox theListBox) {
          
            theListBox.Items.Add(Count.ToString());

        }

        /// <summary>
        /// Inserts an item into the binary search tree
        /// </summary>
        /// <param name="item"></param>
        public void Insert(int data) {

            // Create a node for the item being inserted
            // Set the key of the new node to the item being inserted
            Node newNode = new Node(data);

            // Check if the tree is empty
            if (Root is null) {
                Root = newNode;

            } else {
                bool done = false;
                Node Current = Root;
                Node Parent;
                while (!done) {
                    Parent = Current;
                    if (data < Current.Data) {
                        Current = Current.LeftChild;
                        if (Current is null) {
                            Parent.LeftChild = newNode;
                            done = true;
                        }
                    } else if (data > Current.Data) {
                        Current = Current.RightChild;

                        if (Current is null) {
                            Parent.RightChild = newNode;
                            done = true;
                            //nodeCount(Root);
                        }
                        

                    } else {
                        MessageBox.Show(String.Format("The number is a duplicate, please try again."));

                    }
                }
                
            }
            Count++;
            //MessageBox.Show(data + "-" + Count); used for debugging count
        }

        /// <summary>
        /// Count traversal routine.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="count"></param>
        public int CountTraversal(Node current, int count) {
            
            if (current != null) {
                CountTraversal(current.LeftChild, count);
                count++;
                //theListBox.Items.Add(current.ToString());
                CountTraversal(current.RightChild, count);

            }

            return count;
            

        }

        /// <summary>
        /// This routine iterates through the ordered link list.
        /// inorder - node if there is a left node, go left
        /// once left is done, then process the parent node or the node youre on
        /// once you process the parent, then move on to the right
        /// leftchild, parent, rightchild
        /// </summary>
        /// <param name="start"></param>
        /// <param name="theListBox"></param>
        public void InOrderTraversal(Node current, ListBox theListBox) {
            if (current != null) {
                InOrderTraversal(current.LeftChild, theListBox);
                theListBox.Items.Add(current.ToString());
                InOrderTraversal(current.RightChild, theListBox);
                
            } 

        }

        /// <summary>
        /// This routine processes the parent node, then the leftchild, and
        /// finally the rightchild.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="theListBox"></param>
        public void PreOrderTraversal(Node current, ListBox theListBox) {
            if (current != null) {
                theListBox.Items.Add(current.ToString());
                PreOrderTraversal(current.LeftChild, theListBox);
                PreOrderTraversal(current.RightChild, theListBox);
                
            }

        }

        /// <summary>
        /// This routine processes the leftchild, then the rightchild, and
        /// finally the parent node. 
        /// </summary>
        /// <param name="current"></param>
        /// <param name="theListBox"></param>
        public void PostOrderTraversal(Node current, ListBox theListBox) {
            if (current != null) {
               PostOrderTraversal(current.LeftChild, theListBox);
               PostOrderTraversal(current.RightChild, theListBox);
               theListBox.Items.Add(current.ToString());
            }

        }

        /// <summary>
        /// Returns the largest item in the subtree of a given node in the 
        /// binary search tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Max(Node node) {
            while (node.RightChild != null) {
                node = node.RightChild;

            }
            return node.Data;
        }

        /// <summary>
        /// Returns the smallest item in the subtree of a given node in the 
        /// binary search tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Min(Node node) {
            while (node.LeftChild != null) {
                node = node.LeftChild;

            }
            return node.Data;
        }

        #endregion Methods

    }   
}   

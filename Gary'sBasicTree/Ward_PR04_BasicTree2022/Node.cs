/*********************************************************************************************************

 * Project: Basic Trees
 * 
 * File: Node Class
 * 
 * Langauge: VS C#
 * 
 *
 *
 * Description: This is the node class for the binary tree.
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
 * 2/23/2022               - Added constructor
 * 2/23/2022               - Added method
 * 4/17/2022               - Modified ToString method to display data more effectively. 
 * 
 * 
 * 
 * 
*********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ward_PR04_BasicTree2022 {
    class Node {

        #region Constants
        #endregion Constants

        #region Data Members

        #endregion Data Members

        #region Properties                        

        public int Data;                        // The data from the file
        public Node Key { get; set; }           // The integer held by each node
        public Node LeftChild { get; set; }     // Pointer to the left child of the parent
        public Node RightChild { get; set; }    // Pointer to the right child of the parent
        public Node Parent { get; set; }        // Pointer to the parent node

        public Node Next { get; set; }          // Pointer to the next node

        #endregion Properties

        #region Constructor


        public Node(int data) {
            Data = data;
            LeftChild = null;
            RightChild = null;
  
        }

        #endregion Constructor

        #region Events

        #endregion Events

        #region Methods

        /// <summary>
        /// This routine outputs a Node in a default format
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            /*return String.Format("[data] = {0}, [left child] = {1}, [right child] = {2}", Data, LeftChild, RightChild);*/
            return String.Format("[data] = {0}, [left child] = {1}, [right child] = {2}",
                Data,
                LeftChild == null ? "null" : LeftChild.Data.ToString(),
                RightChild == null ? "null" : RightChild.Data.ToString());

        }

        #endregion Methods


    }


}

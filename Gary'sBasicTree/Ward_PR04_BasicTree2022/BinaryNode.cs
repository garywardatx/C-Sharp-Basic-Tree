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
 * 2/23/2022               - Added Insert method to add items into the binary search tree
 * 
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

namespace Ward_PR04_BasicTree2022 {
    class BinaryNode {

        #region Constants
        #endregion Constants

        #region Data Members

        #endregion Data Members

        #region Properties                        

        public String Data {get; set;}                  // the data processed from the file
        public BinaryNode LeftChild { get; set; }       // Pointer to the left child of the parent
        public BinaryNode RightChild { get; set; }      // Pointer to the right child of the parent


        #endregion Properties

        #region Constructor

        public BinaryNode(string data) {
            Data = data;
           
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
            return String.Format("[key] = {0}, [left child] = {1}, [right child] = {2}", Key, LeftChild, RightChild);

        }

        #endregion Methods

    }
}

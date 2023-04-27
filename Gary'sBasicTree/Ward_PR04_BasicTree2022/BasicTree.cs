/*********************************************************************************************************

 * Project: Basic Trees
 * 
 * File: Searching Algorithms 
 * 
 * Langauge: VS C#
 * 
 *
 *
 * Description: Creates a Binary Search Tree in C#.
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
 * 2/17/2022               - Completed form setup
 * 2/17/2022               - Added the node class
 * 2/23/2022               - Added the binary search tree class
 * 2/23/2022               - Created the routine to get the name of a file.
 * 2/24/2022               - Continuing to work on node setup and insert method.
 * 2/25/2022               - Due to difficulty setting up the Basic Tree Insert method and displaying the 
 *                           file data using the DisplayList routine, added a button to select the file 
 *                           and a separate button to process the file to get a working program. 
 * 2/26/2022               - The program will compile without errors. 
 * 2/26/2022               - There is an issue with the ProcessFile method on line 185. Working on this.
 * 2/26/2022               - Working on displaying countNode, Max, and Min functions.                          
 * 2/26/2022               - Need to come back to postorder, preorder, and depth traversal. Spent too much
 *                           time trying to figure out the integration of the insert method and display 
 *                           routines. 
 * 4/17/2022               - Revised ProcessFile routine with assistance from Dr. Wright. 
 * 4/17/2022               - Revised DisplayData routine to display InOrder, PreOrder, and PostOrder 
 *                           Traversals.  
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
    public partial class BasicTree : Form {
        public BasicTree() {
            InitializeComponent();
        }

        #region Constants
        #endregion Constants

        #region Data Members

        BinarySearchTree binaryTree = new BinarySearchTree();       // creates an empty binary search tree
        

        #endregion Data Members

        #region Properties



        #endregion Properties

        #region Events


        /// <summary>
        /// Call the routine that processes the file and displays 
        /// the results on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProcessFile_Click(object sender, EventArgs e) {
            
            // start with an empty link list each time
            binaryTree = new BinarySearchTree();

            // process the file
            ProcessFile(textBoxFileName.Text.Trim());

            // display the results
            // wordList.IterateByOrder(wordList.Top, listBoxWordOrder);
            DisplayData(binaryTree, listBoxInOrder);

        }

        private void buttonSelectFile_Click(object sender, EventArgs e) {

            String fileName;

            // get the file name
            fileName = GetFileName();

            // Process the file

            if (fileName != string.Empty) {
                textBoxFileName.Text = fileName;
            }

        }


        #endregion Events

        #region Methods

        private void DisplayData(BinarySearchTree binaryTree, ListBox theListBox) {
            int count = 0;

            // clear the list box
            theListBox.Items.Clear();

            // display the contents of the list
            binaryTree.InOrderTraversal(binaryTree.Root, listBoxInOrder);
            binaryTree.PreOrderTraversal(binaryTree.Root, listBoxPreOrder);
            binaryTree.PostOrderTraversal(binaryTree.Root, listBoxPostOrder);
            
            count = binaryTree.CountTraversal(binaryTree.Root, count);
            listBoxCountTraversal.Items.Add(count);
            
            binaryTree.nodeCount(listBoxCount);

            listBoxMinMax.Items.Add("Min value = " + binaryTree.Min(binaryTree.Root));

            listBoxMinMax.Items.Add("Max value = " + binaryTree.Max(binaryTree.Root));

            //binaryTree.nodeCount(binaryTree.Count, listBoxInOrder);

            // display the header
            //theListBox.Items.Add(String.Empty);
            //theListBox.Items.Add(String.Format("{0}", binaryTree));

        }


        /// <summary>
        /// This routine will use OpenFileDialog to allow the user to retrieve a 
        /// single file. If the user does not select a file, the routine returns 
        /// null.
        /// </summary>
        /// <returns></returns>
        private String GetFileName() {
            String filePath = null;

            // configure the open file dialog
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openDialog.FilterIndex = 1;
            openDialog.Multiselect = false;
            openDialog.RestoreDirectory = true;

            // show dialog to the user
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                filePath = openDialog.FileName;
            }

            // Return the filename or null. 
            return filePath;


        }

        

        /// <summary>
        /// This routine will process the data in the text file
        /// and add it to the link list.
        /// </summary>
        /// <param name="fileName"></param>

        private void ProcessFile(String fileName) {
            String line;             // one line of text from the file
            

            // check to verify that the file exists
            if (File.Exists(fileName)) {
                // attempt to open the file
                using (FileStream stream = File.Open(fileName, FileMode.Open)) {

                    using (StreamReader reader = new StreamReader(stream)) {
                        // read a line at a time
                        while ((line = reader.ReadLine()) != null) {
                            // split the line into words
                            // place into an array
                            String[] dataArray = line.Split(' ');
                            foreach (String data in dataArray) {
                                if (int.TryParse(data.Trim(), out var tempInt)) {
                                    ProcessData(tempInt);
                                }

                            }
                        }

                    }

                }

            } else {
                MessageBox.Show(String.Format("The file '{0}' does not exist.", fileName));

            }
     
        }



        /// <summary>
        /// This routine will process the data in the file 
        /// by adding it to the link list
        /// </summary>
        /// <param name="word">The word to be added</param>
        public void ProcessData(int data) {

            binaryTree.Insert(data);

        }



        #endregion Methods

        
    }
}

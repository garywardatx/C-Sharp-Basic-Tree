# C-Sharp-Basic-Tree
This code implements a binary search tree in C# using the following specifications:

The data is integer data and is be read in from a file. The program processes each file and produces errors for incorrect files.

Structure: The binary search property is maintained when inserting items into the binary search tree.
The value of a key of a node must be greater than the value of a key of any node in its left subtree, and less
than the value of any node in its right subtree.

Nodes:

Parent link
Key
LeftChild link
RightChild link

Methods:

Constructor(s) - initializes an instance of the class
Count - returns the number of nodes in the binary search tree using a Property
CountTraverse - returns the number of nodes in the binary tree using tree Traversal
Insert - insert an item into the binary search tree
InOrder - display the binary search tree in order
Min - returns the smallest item in the subtree of a given node in the binary search tree
Max - returns the largest item in the subtree of a given node in the binary search tree
PreOrder - display the binary tree in pre-order
PostOrder - display the binary tree in post-order

Display:

Three list boxes are used on the form. Each is labelled accordingly based on the information below.

In the left ListBox, contents of the tree are displayed in PreOrder.

In the middle ListBox, contents of the tree are displayed in InOrder.

In the right ListBox, contents of the tree are displayed in PostOrder.

Below the left ListBox, the Count property is displayed.

Below the right ListBox, the CountTraversal is displayed.

Below the center ListBox, the min and max value for the tree are displayed.



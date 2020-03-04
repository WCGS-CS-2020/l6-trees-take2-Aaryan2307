using System;

namespace L6Trees
{

    /*
     * Tasks:
     * 1) Complete the implementation of the Node methods
     * 2) Print out the tree using the different tree traversal metods
     * 3) Test findNote() and deleteNode()
     *
     *
     */
    class Node
    {
        // Attributes
        private Node left;
        private Node right;
        private string item;

        //Methods
        public Node(string i)
        {
            left = null;
            right = null;
            item = i;
        }
        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        public Node Left
        {
            get { return left; }
            set { left = value; }
        }
        public Node Right
        {
            get { return right; }
            set { right = value; }
        }
        public Boolean deleteNote(string item) { return true; }
        void printTree() { }
    }
    class BinaryTree
    {
       private Node root;
       public BinaryTree()
        {
            root = null;
        }
        public void addNode(string data)
        {
            if (root == null)
            {
                root = new Node(data);
                return;
            }
                InsertRec(root, new Node(data));
        }
       public void InsertRec(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.Item.CompareTo(root.Item) == 1)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    InsertRec(root.Left, newNode);
                }

            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    InsertRec(root.Right, newNode);
                }
            }
        }
        public bool findNode(string data)
        {
            Console.WriteLine(findRec(root, data));
            return true;
        }
        public string findRec(Node root, string data)
        {
            if (root != null)
            {
                if (root.Item == data)
                {
                    Console.WriteLine(data);
                    return data;
                }
                else if (data.CompareTo(root.Item) == 1)
                {
                    findRec(root.Left, data);
                    return data;
                }
                else
                {
                    findRec(root.Right, data);
                    return data;
                }
            }
            else
            {
                Console.WriteLine("Item not found");
                return null;
            }

        }
        public void DisplayTree(Node root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                DisplayTree(root.Left);
                Console.WriteLine(root.Item + " ");
                DisplayTree(root.Right);
            }
        }
        public Node Root
        {
            get { return root; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            BinaryTree binTree = new BinaryTree();
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            // process all the nodes on the array
            
            foreach (string mon in months)
             {
                binTree.addNode(mon);
             }
            // print out the tree using different traversal methods
           // binTree.DisplayTree(binTree.Root);
            // Test the findNote() and deleteNode()
             binTree.findNode("g");
        }
    }
}

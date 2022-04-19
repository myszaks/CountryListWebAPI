using static CountryListWebAPI.SharedFunctions;

namespace CountryListWebAPI
{
    public class TreeBuilder
    {
        public TreeNode root { get; set; }
        private TreeNode current { get; set; }
        private TreeNode tempParent { get; set; }
        public static TreeBuilder tree { get; set; }

        public TreeBuilder()
        {
            this.root = null;
        }


        public static void BuildTree()
        {
            tree = new TreeBuilder();

            tree.root = InsertNodeToTree(tree.root, CountryList.ElementAt(0).Value, CountryList.ElementAt(0).Key);
            for (int i = 1; i < CountryList.Count; i++)
            {
                InsertNodeToTree(tree.root, CountryList.ElementAt(i).Value, CountryList.ElementAt(i).Key);
            }
        }

        static TreeNode InsertNodeToTree(TreeNode root, int data, string sdata)
        {
            TreeNode newNode = new TreeNode(data, sdata);

            TreeNode x = root;
            TreeNode y = null;

            while (x != null)
            {
                y = x;
                if (data < x.data) x = x.leftNode;
                else x = x.rightNode;
            }

            if (y == null) y = newNode;
            else if (data < y.data) y.leftNode = newNode;
            else y.rightNode = newNode;

            return y;
        }
    }
}

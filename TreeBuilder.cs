using static CountryListWebAPI.SharedFunctions;

namespace CountryListWebAPI
{
    public class TreeBuilder
    {
        public TreeNode? Root { get; set; } = null;
        public static TreeBuilder Tree { get; set; } = new();

        public void BuildTree()
        {
            if (Tree.Root == null) Tree.Root = InsertNodeToTree(Tree.Root, CountryList.ElementAt(0).Value, CountryList.ElementAt(0).Key);

            for (int i = 1; i < CountryList.Count; i++)
            {
                InsertNodeToTree(Tree.Root, CountryList.ElementAt(i).Value, CountryList.ElementAt(i).Key);
            }
        }

        static TreeNode InsertNodeToTree(TreeNode root, int value, string country)
        {
            TreeNode newNode = new(value, country);

            TreeNode x = root;
            TreeNode y = null;

            while (x != null)
            {
                y = x;
                if (value < x.Data) x = x.LeftNode;
                else x = x.RightNode;
            }

            if (y == null) y = newNode;
            else if (value < y.Data) y.LeftNode = newNode;
            else y.RightNode = newNode;

            return y;
        }
    }
}

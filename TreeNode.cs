using System.Diagnostics;

namespace CountryListWebAPI
{
    public class TreeNode
    {
        public int data { get; set; }
        public string country { get; set; }
        public TreeNode leftNode { get; set; }
        public TreeNode rightNode { get; set; }

        public TreeNode(int value, string svalue)
        {
            this.data = value;
            this.country = svalue;
        }
    }
}

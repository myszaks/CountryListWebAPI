namespace CountryListWebAPI
{
    public class TreeNode
    {
        public int Data { get; set; }
        public string Country { get; set; }
        public TreeNode? LeftNode { get; set; } = null;
        public TreeNode? RightNode { get; set; } = null;

        public TreeNode(int value, string svalue)
        {
            this.Data = value;
            this.Country = svalue;
        }
    }
}

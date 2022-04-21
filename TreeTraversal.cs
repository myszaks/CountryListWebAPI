namespace CountryListWebAPI
{
    public class TreeTraversal
    {
        public static Boolean FindRoute(TreeNode root, List<string> route, int searchValue)
        {
            if (root == null) return false;

            route.Add(root.Country);

            while (root.Data != searchValue)
            {
                if (root.Data != searchValue)
                {
                    if (root.LeftNode == null)
                    {
                        root = root.RightNode;
                    }
                    else if (root.RightNode == null)
                    {
                        root = root.LeftNode;
                    }
                    else
                    {
                        if (root.LeftNode.Data == searchValue)
                        {
                            route.Add(root.LeftNode.Country);
                            break;
                        }
                        else if (root.RightNode.Data == searchValue)
                        {
                            route.Add(root.RightNode.Country);
                            break;
                        }
                        else if (searchValue > root.Data && root.RightNode != null)
                        {
                            root = root.RightNode;
                        }
                        else if (searchValue < root.Data && root.LeftNode != null)
                        {
                            root = root.LeftNode;
                        }
                        else return false;
                    }
                }
                else
                {
                    route.Add(root.Country);
                    break;
                }

                route.Add(root.Country);
            }
            return true;
        }

        public static List<string> ListRoute(TreeNode root, int value)
        {
            List<string> route = new();

            if (FindRoute(root, route, value))
            {
                return route;
            }

            return null;
        }
    }
}

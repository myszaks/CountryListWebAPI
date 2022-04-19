using System.Diagnostics;

namespace CountryListWebAPI
{
    public class TreeTraversal
    {        
        public static Boolean FindRoute(TreeNode root, List<string> route, int searchValue)
        {
            if (root == null) return false;
            route.Add($"Destination: {SharedFunctions.CountryList.FirstOrDefault(x => x.Value == searchValue)}");
            route.Add("Route: ");
            route.Add(root.country);

            while (root.data != searchValue)
            {
                if (root.data != searchValue)
                {
                    if (root.leftNode == null)
                    {
                        root = root.rightNode;
                    }
                    else if (root.rightNode == null)
                    {
                        root = root.leftNode;
                    }
                    else
                    {
                        if (root.leftNode.data == searchValue)
                        {
                            route.Add(root.leftNode.country);
                            break;
                        }
                        else if (root.rightNode.data == searchValue)
                        {
                            route.Add(root.rightNode.country);
                            break;
                        }
                        else if (searchValue > root.data && root.rightNode != null)
                        {
                            root = root.rightNode;
                        }
                        else if (searchValue < root.data && root.leftNode != null)
                        {
                            root = root.leftNode;
                        }
                        else return false;
                    }
                }
                else
                {
                    route.Add(root.country);
                    break;
                }

                route.Add(root.country);
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

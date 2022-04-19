using Microsoft.AspNetCore.Mvc;
using CountryListWebAPI;



namespace CountryListWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreeNodeController : ControllerBase
    {

        [HttpGet("{destination}")]
        public ActionResult<List<string>> Get(string destination)
        {
            TreeBuilder.BuildTree();

            if (SharedFunctions.CountryList.TryGetValue(destination.ToUpper(), out int result))
            {
                List<string> route = TreeTraversal.ListRoute(TreeBuilder.tree.root, result);

                return route;
            }
            return null;
        }

    }
}

using Microsoft.AspNetCore.Mvc;

namespace CountryListWebAPI.Controllers
{
    public class ReturnMessage
    {
        public string Destination { get; set; } = "";
        public List<string> List { get; set; } = new();
    }

    [ApiController]
    public class TreeNodeController : ControllerBase
    {
        [HttpGet("{destination}")]
        public ActionResult<ReturnMessage> Get(string destination)
        {
            TreeBuilder tb = new();
            tb.BuildTree();

            if (SharedFunctions.CountryList.TryGetValue(destination.ToUpper(), out int result))
            {
                List<string> route = TreeTraversal.ListRoute(TreeBuilder.Tree.Root, result);

                return new ReturnMessage()
                {
                    Destination = destination.ToUpper(),
                    List = route
                };
            }
            return BadRequest(new Dictionary<string, object>() { { "Error", "Wrong destination!" } });
        }


    }
}

using System.Web.Mvc;
using ShlyashApi.Models;

namespace ShlyashApi.Controllers
{
    public class IndexController : Controller
    {
        public string HealthCheck()
        {
            return "Mobile and desktop API is online";
        }
        [HttpGet]
        public ActionResult Index()
        {

            TokenData tokenData = new TokenData
            {
                client = new MobileClient { Name = "Android", Type = ClientType.Mobile }
        ,
                Key="63nummnbynin"
            };
            return View("About",tokenData);
        }


        public ActionResult Contact()
        {
            return Content("some info");
        }
    }
}
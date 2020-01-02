using System.Web.Mvc;

using System;
using ShlyashApi.Models;
using System.Data.SQLite;
using static System.IO.File;

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

            ViewBag.Title = "Registarion";

            return View("Index", tokenData);
        }


        public ActionResult Contact()
        {
            return Content("some info");
        }
        public string Statistics()
        {

            if (!Exists("AccessDB.sqlite"))
            {
                SQLiteConnection.CreateFile("AccessDB.sqlite");
                return "DB creted"; 
            }
            else
                return  "DB not creted";
        }
    }
}
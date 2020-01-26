using Moq;
using ShlyahApi.Client.Models;
using ShlyahApi.Client.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShlyahApi.Client.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult Index()
        {
            return View();
        }
      //  public ViewResult ViewLog()
        //{
            //Mock<IAccessLogsRepo> mock = new Mock<IAccessLogsRepo>();
            //mock.Setup(m => m.tokenDatas).Returns(new List<TokenData> { new TokenData(), new TokenData() }.AsQueryable());
            //return View(mock.Object);
        //}
    }
}
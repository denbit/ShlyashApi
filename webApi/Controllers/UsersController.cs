using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShlyahApi.Client.Repo;

namespace ShlyahApi.Client.Controllers
{
    public class UsersController : Controller
    {
        public UsersController( ICommonUserRepo userRepo)
        {
            this.repo = userRepo;
        }
        private readonly ICommonUserRepo repo;
        // GET: Users
        public ActionResult List()
        {
            return View(repo.Users);
        }
    }
}
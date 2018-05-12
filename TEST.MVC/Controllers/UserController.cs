using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST.MVC.IBLL;
using TEST.MVC.Model;

namespace TEST.MVC.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserService userSvc = BLLContainer.Container.Resolve<IUserService>();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(User user)
        {
            if (string.IsNullOrEmpty(user.Name))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                if (userSvc.Add(user))
                {
                    return Redirect("Index");
                }
                else
                {
                    return Content("No");
                }
            }
            return View();
        }
    }
}
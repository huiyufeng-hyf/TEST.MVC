
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using TEST.MVC.IBLL;
using TEST.MVC.Web.Models;

namespace TEST.MVC.Web.Controllers
{
    public class UserApiController : ApiController
    {
        private IUserService userSvc = BLLContainer.Container.Resolve<IUserService>();

        int pageSize = 10;
        [HttpPost]
        public IHttpActionResult GetData(int curPage = 1)
        {
            int total = userSvc.GetModels(u => true).Count();
            var pages = new PageList(curPage, total, pageSize);
            var list = (from u in userSvc.GetModelsByPage(pageSize, curPage, true, u => u.Id, u => true).ToList()
                        select new
                        {
                            Name = u.Name,
                            Id = u.Id
                        }).ToList();
            var data = new { list = list, pages = pages };
            return Ok(data);
        }
    }
}

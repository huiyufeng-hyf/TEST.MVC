using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST.MVC.IBLL;
using TEST.MVC.IDAL;
using TEST.MVC.Model;

namespace TEST.MVC.BLL
{
    public partial class DeptService : BaseService<Dept>, IDeptService
    {
        private IDeptDAL deptDAL = DALContainer.Container.Resolve<IDeptDAL>();

        public override void SetDal()
        {
            Dal = deptDAL;
        }

        //protected override void SetRequiredFieldOnCreatedNewItem(Dept item)
        //{
        //    if (item.Created == null || item.Created == new DateTime())
        //        item.Created = DateTime.Now;

        //    if (item.Modified == null || item.Modified == new DateTime())
        //        item.Modified = DateTime.Now;

        //    if (item.Author == null || item.Author < 1)
        //        item.Author = CurrentUserId;

        //    if (item.Editor == null || item.Editor < 1)
        //        item.Editor = CurrentUserId;
        //}
    }
}

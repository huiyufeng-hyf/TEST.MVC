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
    public partial class UserService : BaseService<User>, IUserService
    {
        private IUserDAL userDAL = DALContainer.Container.Resolve<IUserDAL>();
        public override void SetDal()
        {
            Dal = userDAL;
            userDAL.DisplayTest();
            //Dal.DisplayTest();
        }

        //protected override void SetRequiredFieldOnCreatedNewItem(User item)
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

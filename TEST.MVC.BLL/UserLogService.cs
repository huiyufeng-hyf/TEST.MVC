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
    public partial class UserLogService : BaseService<UserLog>, IUserLogService
    {
        private IUserLogDAL userLogDAL = DALContainer.Container.Resolve<IUserLogDAL>();

        public override void SetDal()
        {
            Dal = userLogDAL;
        }

        //protected override void SetRequiredFieldOnCreatedNewItem(UserLog item)
        //{
        //    if (item.Created == null || item.Created == new DateTime())
        //        item.Created = DateTime.Now;

        //    if (item.UserId < 1)
        //        item.UserId = CurrentUserId;
        //}
    }
}

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
    }
}

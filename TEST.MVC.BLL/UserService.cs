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
        }
    }
}

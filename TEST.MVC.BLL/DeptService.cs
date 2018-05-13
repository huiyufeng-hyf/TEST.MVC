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
    }
}

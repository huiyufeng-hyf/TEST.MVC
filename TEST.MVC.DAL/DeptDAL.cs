using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST.MVC.IDAL;
using TEST.MVC.Model;

namespace TEST.MVC.DAL
{
    public partial class DeptDAL : BaseDAL<Dept>, IDeptDAL
    {
    }
}

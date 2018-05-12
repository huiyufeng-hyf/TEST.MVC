using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TEST.MVC.Model;

namespace TEST.MVC.DAL
{
    public partial class DbContextFactory
    {
        public static DbContext Create()
        {
            DbContext dbCxt = CallContext.GetData("DbContext") as DbContext;
            if(dbCxt == null)
            {
                dbCxt = new TestMvcDBEntities();
                CallContext.SetData("DbContext", dbCxt);
            }
            return dbCxt;
        }
    }
}

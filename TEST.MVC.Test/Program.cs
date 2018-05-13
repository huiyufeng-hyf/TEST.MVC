using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST.MVC.BLL;
using TEST.MVC.Common;
using TEST.MVC.IBLL;
using TEST.MVC.Model;

namespace TEST.MVC.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestMvcDBEntities dbCxt = new TestMvcDBEntities();
            //--> to add a new user
            //User user = new User
            //{
            //    Name = "u11test"
            //};
            //dbCxt.User.Add(user);
            //dbCxt.SaveChanges();

            //Console.WriteLine(dbCxt.User.Count());

            //--> to update an user data
            //User u10 = dbCxt.User.Where(u => u.Name == "u10test").FirstOrDefault();
            //u10.IsDeleted = false;
            //u10.Modified = DateTime.Now;
            //dbCxt.SaveChanges();

            //--> to add user with dept together
            //User u1 = new User { Name = "u1 test" };
            //User u2 = new User { Name = "u2 test" };
            //Dept d1 = new Dept { Name = "d1" };
            //d1.User.Add(u1);
            //d1.User.Add(u2);
            //dbCxt.Dept.Add(d1);
            //dbCxt.SaveChanges();
            //Console.WriteLine(dbCxt.Dept.FirstOrDefault().User.Count);

            IUserService userSvc = BLLContainer.Container.Resolve<IUserService>();
            IUserLogService ulSvc = BLLContainer.Container.Resolve<IUserLogService>();
            User u2 = new User { Name = "u8 test" };
            //userSvc.Add(u2);
            UserLog ulog = new UserLog
            {
                Operation = Constants.GetUserLogType(Constants.UserLogType.Add),
                User = u2
            };
            ulSvc.Add(ulog);

            //User user = userSvc.GetModels(u => u.Id == 3).FirstOrDefault();
            //user.Created = DateTime.Now;
            //user.Modified = DateTime.Now;
            //user.IsDeleted = false;
            //userSvc.Update(user);


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST.MVC.Model;

namespace TEST.MVC.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMvcDBEntities dbCxt = new TestMvcDBEntities();
            //User user = new User
            //{
            //    Name = "u11test"
            //};
            //dbCxt.Users.Add(user);
            //dbCxt.SaveChanges();

            Console.WriteLine(dbCxt.Users.Count());

            User u10 = dbCxt.Users.Where(u => u.Name == "u10test").FirstOrDefault();
            u10.IsDeleted = false;
            u10.Modified = DateTime.Now;
            dbCxt.SaveChanges();
            Console.ReadLine();
        }
    }
}

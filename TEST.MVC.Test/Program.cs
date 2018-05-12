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
            DbContext dbCxt = new TestMvcDBEntities();
            User user = new User
            {
                Name = "u4test"
            };
            dbCxt.Set<User>().Add(user);
            dbCxt.SaveChanges();

            Console.WriteLine(dbCxt.Set<User>().ToList().Count);
            Console.ReadLine();
        }
    }
}

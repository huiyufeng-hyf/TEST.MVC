using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST.MVC.DAL;
using TEST.MVC.IDAL;

namespace TEST.MVC.DALContainer
{
    public class Container
    {
        private static IContainer container = null;

        public static T Resolve<T>()
        {
            try
            {
                if(container == null)
                {
                    Initialize();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("IOC实例化出错！" + ex.Message);
            }

            return container.Resolve<T>();
        }

        public static void Initialize()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UserDAL>().As<IUserDAL>().InstancePerLifetimeScope();
            builder.RegisterType<DeptDAL>().As<IDeptDAL>().InstancePerLifetimeScope();
            builder.RegisterType<UserLogDAL>().As<IUserLogDAL>().InstancePerLifetimeScope();
            container = builder.Build();
        }
    }
}

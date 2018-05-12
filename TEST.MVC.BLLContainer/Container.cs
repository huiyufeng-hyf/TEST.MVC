using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST.MVC.BLL;
using TEST.MVC.IBLL;

namespace TEST.MVC.BLLContainer
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
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            container = builder.Build();
        }
    }
}

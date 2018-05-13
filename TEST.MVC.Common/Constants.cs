using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST.MVC.Common
{
    public static class Constants
    {
        public enum SystemLogType
        {
            Login = 1,
            Logout = 2,
            Error = 3
        }

        public enum UserLogType
        {
            Add = 4,
            Delete = 5,
            Update = 6,
            View = 7,
            Download = 8
        }

        public static string GetSystemLogType(SystemLogType slt)
        {
            switch (slt)
            {
                case SystemLogType.Login:
                    return "登录";
                case SystemLogType.Logout:
                    return "退出";
                case SystemLogType.Error:
                    return "异常错误";
                default:
                    break;
            }

            return string.Empty;
        }

        public static string GetUserLogType(UserLogType ult)
        {
            switch (ult)
            {
                case UserLogType.Add:
                    return "添加";
                case UserLogType.Delete:
                    return "删除";
                case UserLogType.Update:
                    return "修改";
                case UserLogType.View:
                    return "查看";
                case UserLogType.Download:
                    return "下载";
                default:
                    break;
            }

            return string.Empty;
        }
    }

}

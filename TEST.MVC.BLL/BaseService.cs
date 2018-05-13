using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TEST.MVC.IDAL;

namespace TEST.MVC.BLL
{
    public abstract partial class BaseService<T> where T : class, new()
    {
        public BaseService()
        {
            SetDal();
        }

        protected IBaseDAL<T> Dal { get; set; }

        public abstract void SetDal();
        //protected abstract void SetRequiredFieldOnCreatedNewItem(T item);

        //private int _currentUserId = -1;
        //protected int CurrentUserId
        //{
        //    get
        //    {
        //        return GetCurrentUser();
        //    }
        //}

        //private int GetCurrentUser()
        //{
        //    if (_currentUserId != -1)
        //    {
        //        return _currentUserId;
        //    }
        //    else
        //    {
        //        if (true)// to check the current login user == null
        //        {
        //            WriteTestUser();
        //            if (_currentUserId == -1)
        //            {
        //                throw new NullReferenceException("Can not get the current login user information");
        //            }
        //        }
        //        else
        //        {
        //            // to get the current login user id
        //        }

        //        return _currentUserId;
        //    }
        //}

        public virtual bool Add(T t)
        {
            //SetRequiredFieldOnCreatedNewItem(t);
            Dal.Add(t);
            return Dal.SaveChanges();
        }

        public virtual bool Delete(T t)
        {
            Dal.Delete(t);
            return Dal.SaveChanges();
        }

        public virtual bool Update(T t)
        {
            Dal.Update(t);
            return Dal.SaveChanges();
        }

        public virtual IQueryable<T> GetModels(Expression<Func<T, bool>> whereLambda)
        {
            return Dal.GetModels(whereLambda);
        }

        public virtual IQueryable<T> GetModelsByPage<type>(int pageSize, int pageIndex, bool isAsc, Expression<Func<T, type>> orderByLambda, Expression<Func<T, bool>> whereLambda)
        {
            return Dal.GetModelsByPage(pageSize, pageIndex, isAsc, orderByLambda, whereLambda);
        }

        //[Conditional("DEBUG")]
        //private void WriteTestUser()
        //{
        //    _currentUserId = 1;
        //}

    }
}

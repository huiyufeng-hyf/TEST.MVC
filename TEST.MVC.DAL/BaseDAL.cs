using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TEST.MVC.DAL
{
    public abstract partial class BaseDAL<T> where T : class, new()
    {
        private DbContext dbCxt = DbContextFactory.Create();

        protected abstract void SetRequiredFieldOnCreatedNewItem(T item);

        private int _currentUserId = -1;
        protected int CurrentUserId
        {
            get
            {
                return GetCurrentUser();
            }
        }

        private int GetCurrentUser()
        {
            if (_currentUserId != -1)
            {
                return _currentUserId;
            }
            else
            {
                if (true)// to check the current login user == null
                {
                    WriteTestUser();
                    if (_currentUserId == -1)
                    {
                        throw new NullReferenceException("Can not get the current login user information");
                    }
                }
                else
                {
                    // to get the current login user id
                }

                return _currentUserId;
            }
        }

        public void Add(T t)
        {
            SetRequiredFieldOnCreatedNewItem(t);
            dbCxt.Set<T>().Add(t);
        }

        public void Delete(T t)
        {
            dbCxt.Set<T>().Remove(t);
        }

        public void Update(T t)
        {
            dbCxt.Set<T>().AddOrUpdate(t);
        }

        public IQueryable<T> GetModels(Expression<Func<T, bool>> whereLambda)
        {
            return dbCxt.Set<T>().Where(whereLambda);
        }

        public IQueryable<T> GetModelsByPage<type>(int pageSize, int pageIndex, bool isAsc, Expression<Func<T, type>> orderByLambda, Expression<Func<T, bool>> whereLambda)
        {
            if (isAsc)
            {
                return dbCxt.Set<T>().Where(whereLambda).OrderBy(orderByLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            else
            {
                return dbCxt.Set<T>().Where(whereLambda).OrderByDescending(orderByLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
        }

        public bool SaveChanges()
        {
            return dbCxt.SaveChanges() > 0;
        }

        [Conditional("DEBUG")]
        private void WriteTestUser()
        {
            _currentUserId = 1;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TEST.MVC.DAL
{
    public partial class BaseDAL<T> where T : class, new()
    {
        private DbContext dbCxt = DbContextFactory.Create();

        public void Add(T t)
        {
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

    }
}

using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepositoryDAL<T> : IGenericDAL<T> where T : class
    {
        //burada Metot Gorevlerini YAZDIK
         

        public void DeleteDAL(T t)
        {
            using var db = new Context();

            db.Remove(t);
            db.SaveChanges();
        }

        public T GetByIdDAL(int id)
        {
			using var db = new Context();
			return db.Set<T>().Find(id);
		}

        public List<T> GetListAllDAL()
        {
            using var db = new Context();

            return db.Set<T>().ToList();
        }

		public List<T> GetListAllDAL(Expression<Func<T,bool>> filter)
		{
			using var db = new Context();
            return db.Set<T>().Where(filter).ToList();
		}

		

		public void InsertDAL(T t)
        {
            using var db = new Context();
            db.Add(t);
            db.SaveChanges();
        }

        public void UpdateDAL(T t)
        {
            using var db = new Context();
            db.Update(t);
            db.SaveChanges();
        }
    }
}

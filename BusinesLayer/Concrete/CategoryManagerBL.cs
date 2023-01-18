using Businesslayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entityframework;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Concrete
{
    public class CategoryManagerBL : ICategoryServiceBL
    {

        ICategoryDAL _categoryDAL;

        public CategoryManagerBL(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

     
        public void TentityDeleteBl(Category t)
        {
            _categoryDAL.DeleteDAL(t);
        }

        public Category TentityGetByIdBL(int id)
        {
            return _categoryDAL.GetByIdDAL(id);
        }

        public List<Category> TentityGetListBl()
        {
            return _categoryDAL.GetListAllDAL();
        }

        public void TentityInsertBl(Category t)
        {
            _categoryDAL.InsertDAL(t);
        }

        public void TentityUpdateBl(Category t)
        {
            _categoryDAL.UpdateDAL(t);
        }
    }
}

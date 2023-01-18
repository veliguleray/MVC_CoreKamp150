using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Abstract
{
    public interface IGenericServiceBL<T>
    {
        void TentityInsertBl(T t);
        void TentityDeleteBl(T t);
        void TentityUpdateBl(T t);

        List<T> TentityGetListBl();

        T TentityGetByIdBL(int id);
    }
}

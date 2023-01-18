using Businesslayer.Abstract;
using DataAccessLayer.Abstract;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Concrete
{
    public class WriterManagerBL : IWriterServiceBL
    {
        IWriterDAL _writerDAL;  //  nesne/ fiel türettik

        public WriterManagerBL(IWriterDAL writerDAL)   // field e deger atamak ıcın constractur metot kullandık
        {
            _writerDAL = writerDAL;
        }

        public List<Writer> GetWriterByIdBL( int id)
        {
            return _writerDAL.GetListAllDAL(x=>x.WriterID==id).ToList();
        }

        public List<Writer> GetWriterByIdBL()
        {
            throw new NotImplementedException();
        }

        public void TentityDeleteBl(Writer t)
        {
            _writerDAL.DeleteDAL(t);
        }

        public Writer TentityGetByIdBL(int id)
        {
            return _writerDAL.GetByIdDAL(id);
        }

        public List<Writer> TentityGetListBl()
        {
            return _writerDAL.GetListAllDAL();
        }

        public void TentityInsertBl(Writer t)
        {
            _writerDAL.InsertDAL(t);
        }

        public void TentityUpdateBl(Writer t)
        {
            _writerDAL.UpdateDAL(t);
        }

       
    }
}

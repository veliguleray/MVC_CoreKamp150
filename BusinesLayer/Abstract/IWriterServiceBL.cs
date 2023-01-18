using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Abstract
{
    public interface IWriterServiceBL:IGenericServiceBL<Writer>
    {

        List<Writer> GetWriterByIdBL(int id);  // 68

        //void WriterInsertBl(Writer writer);
        //void WriterDeleteBl(Writer writer);
        //void WriterUpdateBl(Writer writer);

        //List<Writer> WriterGetListBl();

        //Writer WriterGetByIdBL(int id);
    }
}

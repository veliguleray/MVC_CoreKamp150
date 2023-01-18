using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entityframework
{
    public class EfCommentRepositoryDAL : GenericRepositoryDAL<Comment>, ICommentDAL
    {


    }
}

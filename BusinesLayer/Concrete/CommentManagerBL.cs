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
    public class CommentManagerBL : ICommentServiceBL
    {
        ICommentDAL _commentDAL;

		public CommentManagerBL(ICommentDAL commentDAL)
		{
			_commentDAL = commentDAL;
		}

		public void CommentDeleteBl(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment CommentGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> CommentGetListBl(int id)
        {
            //return _commentDAL.GetListAllDAL(x=>x.BlogId==1);
            return _commentDAL.GetListAllDAL(x=>x.BlogId==id);
        }
        public void CommentInsertBl(Comment comment)
        {
            _commentDAL.InsertDAL(comment);
        }

        public void CommentUpdateBl(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void TentityDeleteBl(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TentityGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TentityGetListBl()
        {
            throw new NotImplementedException();
        }

        public void TentityInsertBl(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TentityUpdateBl(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}

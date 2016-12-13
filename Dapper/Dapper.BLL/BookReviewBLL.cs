using Dapper.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Model;
using Dapper.Factory;
using Dapper.IDAL;

/*
 * create by Mao Qingyu 
 */

namespace Dapper.BLL
{
    public class BookReviewBLL:IBookReviewBLL
    {
        private static readonly IBookReviewDAL dal = DALFactory.CreateBookReviewDAL();

        public bool Insert(BookReview bookReview)
        {
            return dal.Insert(bookReview) > 0 ? true : false;
        }

        public bool Update(BookReview bookReview)
        {
            return dal.Update(bookReview) > 0 ? true : false;
        }

        public bool Delete(BookReview bookReview)
        {
            return dal.Delete(bookReview) > 0 ? true : false;
        }

        public bool Delete(string id)
        {
            return dal.Delete(id) > 0 ? true : false;
        }

        public IList<BookReview> GetList()
        {
            return dal.GetList();
        }

        public BookReview GetEntity(string id)
        {
            return dal.GetEntity(id);
        }
    }
}

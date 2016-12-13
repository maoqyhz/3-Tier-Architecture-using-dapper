using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by Mao Qingyu 
 */

namespace Dapper.IBLL
{
    public interface IBookReviewBLL
    {

        #region CRUD

        bool Insert(BookReview bookReview);

        bool Update(BookReview bookReview);

        bool Delete(BookReview bookReview);

        bool Delete(string id);

        IList<BookReview> GetList();

        BookReview GetEntity(string id);

        #endregion
    }
}

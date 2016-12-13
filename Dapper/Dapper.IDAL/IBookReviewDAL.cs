using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by Mao Qingyu 
 */

namespace Dapper.IDAL
{
    public interface IBookReviewDAL
    {
        #region CRUD

        int Insert(BookReview bookReview);

        int Update(BookReview bookReview);

        int Delete(BookReview bookReview);

        int Delete(string id);

        IList<BookReview> GetList();

        BookReview GetEntity(string id);

        #endregion
    }
}

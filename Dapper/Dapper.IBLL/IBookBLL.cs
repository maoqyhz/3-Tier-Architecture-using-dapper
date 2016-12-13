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
    public interface IBookBLL
    {
        #region CRUD

        bool Insert(Book book);

        bool Update(Book book);

        bool Delete(Book book);

        bool Delete(string id);

        IList<Book> GetBookList();

        Book GetEntity(string id);

        Book GetEntityWithRefence(string id);

        #endregion
    }
}

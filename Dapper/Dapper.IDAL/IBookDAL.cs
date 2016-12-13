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
    public interface IBookDAL
    {
        #region CRUD

        int Insert(Book book);

        int Update(Book book);

        int Delete(Book book);

        int Delete(string id);

        IList<Book> GetList();

        /// <summary>
        /// 根据主键获得Book
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Book GetEntity(string id);

        /// <summary>
        /// 根据主键获得Book包括BookReview
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Book GetEntityWithRefence(string id);

        #endregion
    }
}

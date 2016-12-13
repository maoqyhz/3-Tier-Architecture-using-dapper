using Dapper;
using Dapper.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Factory;
using System.Data;
using Dapper.Model;
using DapperExtensions;
using DapperExtensions.Mapper;

/*
 * create by Mao Qingyu 
 */

namespace Dapper.SQLServerDAL
{
    public class BookDAL : IBookDAL
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }

        #region CRUD using raw dapper

        public int Insert(Model.Book book)
        {
            using (Conn)
            {
                string query = "INSERT INTO Book(Name)VALUES(@name)";
                return Conn.Execute(query, book);
            }
        }

        public int Update(Model.Book book)
        {
            using (Conn)
            {
                string query = "UPDATE Book SET  Name=@name WHERE id =@id";
                return Conn.Execute(query, book);
            }
        }

        public int Delete(Model.Book book)
        {
            using (Conn)
            {
                string query = "DELETE FROM Book WHERE id = @id";
                return Conn.Execute(query, book);
            }
        }

        public int Delete(string id)
        {
            using (Conn)
            {
                string query = "DELETE FROM Book WHERE id = @id";
                return Conn.Execute(query, new { id = id });
            }
        }

        public IList<Model.Book> GetList()
        {
            using (Conn)
            {
                string query = "SELECT * FROM Book";
                return Conn.Query<Book>(query).ToList();
            }
        }

        public Model.Book GetEntity(string id)
        {
            Book book;
            string query = "SELECT * FROM Book WHERE id = @id";
            using (Conn)
            {
                book = Conn.Query<Book>(query, new { id = id }).SingleOrDefault();
                return book;
            }
        }

        public Book GetEntityWithRefence(string id)
        {
            using (Conn)
            {
                string query = "SELECT * FROM Book b LEFT JOIN BookReview br ON br.BookId = b.Id WHERE b.id = @id";
                Book lookup = null;
                var b = Conn.Query<Book, BookReview, Book>(query,
                    (book, bookReview) =>
                    {
                        if (lookup == null || lookup.Id != book.Id)
                            lookup = book;
                        if (bookReview != null)
                            lookup.Reviews.Add(bookReview);
                        return lookup;
                    }, new { id = id }).Distinct().SingleOrDefault();
                return b;
            }
        }

        #endregion


    }
}
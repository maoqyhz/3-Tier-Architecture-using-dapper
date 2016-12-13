using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using Dapper.IDAL;
using Dapper.Factory;
using System.Data;
using Dapper.Model;

/*
 * create by Mao Qingyu 
 */

namespace Dapper.SQLServerDAL
{
    public class BookReviewDAL : IBookReviewDAL
    {

        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }

        public int Insert(BookReview bookReview)
        {
            using (Conn)
            {
                string query = "INSERT INTO BookReview(BookId,Content)VALUES(@bookId,@content)";
                return Conn.Execute(query, bookReview);
            }
        }

        public int Update(BookReview bookReview)
        {
            using (Conn)
            {
                string query = "UPDATE BookReview SET  BookId=@bookId,Content=@content  WHERE id =@id";
                return Conn.Execute(query, bookReview);
            }
        }

        public int Delete(BookReview bookReview)
        {
            using (Conn)
            {
                string query = "DELETE FROM BookReview WHERE id = @id";
                return Conn.Execute(query, bookReview);
            }
        }

        public int Delete(string id)
        {
            using (Conn)
            {
                string query = "DELETE FROM BookReview WHERE id = @id";
                return Conn.Execute(query, new { id = id });
            }
        }

        public IList<BookReview> GetList()
        {
            using (Conn)
            {
                string query = "SELECT * FROM BookReview";
                return Conn.Query<BookReview>(query).ToList();
            }
        }

        public BookReview GetEntity(string id)
        {
            BookReview br;
            string query = "SELECT * FROM BookReview WHERE id = @id";
            using (Conn)
            {
                br = Conn.Query<BookReview, Book, BookReview>(query,
                  (bookReview, book) =>
                  {
                      bookReview.AssoicationWithBook = book;
                      return bookReview;
                  }, new { id = id }).SingleOrDefault();
                return br;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Factory;
using Dapper.IDAL;
using Dapper.Model;
using Dapper.IBLL;
using Dapper.BLL;
using DapperExtensions.Mapper;

namespace Dapper.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBookBLL bll = new BookBLL();
            var list = bll.GetBookList();
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine(bll.GetEntity("27"));
        }
    }
}

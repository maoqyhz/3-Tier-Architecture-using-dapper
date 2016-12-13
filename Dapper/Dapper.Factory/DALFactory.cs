using Dapper.IDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

/*
 * create by Mao Qingyu 
 */

namespace Dapper.Factory
{
    /// <summary>
    /// DAL工厂，读取App.config的配置文件实例化相应的DAL对象
    /// </summary>
    public class DALFactory
    {
        private static readonly string path = ConfigurationManager.AppSettings["ConsoleDAL"];

        public DALFactory() { }

        public static IBookDAL CreateBookDAL()
        {
            string className = path + ".BookDAL";
            return (IBookDAL)Assembly.Load(path).CreateInstance(className);
        }

        public static IBookReviewDAL CreateBookReviewDAL()
        {
            string className = path + ".BookReviewDAL";
            return (IBookReviewDAL)Assembly.Load(path).CreateInstance(className);
        }
    }
}

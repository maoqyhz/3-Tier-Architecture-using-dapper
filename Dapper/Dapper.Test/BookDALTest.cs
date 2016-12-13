using Dapper.SQLServerDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dapper.Model;

namespace Dapper.Test
{
    
    
    /// <summary>
    ///这是 BookDALTest 的测试类，旨在
    ///包含所有 BookDALTest 单元测试
    ///</summary>
    [TestClass()]
    public class BookDALTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///GetEntity 的测试
        ///</summary>
        [TestMethod()]
        public void GetEntityTest()
        {
            BookDAL target = new BookDAL(); // TODO: 初始化为适当的值
            string id = "27"; // TODO: 初始化为适当的值
            Book expected = null; // TODO: 初始化为适当的值
            Book actual;
            actual = target.GetEntity(id);

            Assert.AreEqual("test", actual.Name);
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Insert 的测试
        ///</summary>
        [TestMethod()]
        public void InsertTest()
        {
            BookDAL target = new BookDAL(); // TODO: 初始化为适当的值
            Book book = new Book
            {
                Name="Android程序设计"
            }; // TODO: 初始化为适当的值
            int expected = 0; // TODO: 初始化为适当的值
            int actual;
            actual = target.Insert(book);
            Assert.AreEqual(1, actual);
           // Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Update 的测试
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            BookDAL target = new BookDAL(); // TODO: 初始化为适当的值
            Book book = new Book()
            {
                Id=1,
                Name="汇编语言"
            }; // TODO: 初始化为适当的值
            int expected = 0; // TODO: 初始化为适当的值
            int actual;
            actual = target.Update(book);
            Assert.AreEqual(1, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///GetList 的测试
        ///</summary>
        [TestMethod()]
        public void GetListTest()
        {
            BookDAL target = new BookDAL(); // TODO: 初始化为适当的值
            string id = "1"; // TODO: 初始化为适当的值
            Book expected = null; // TODO: 初始化为适当的值
            Book actual;
            actual = target.GetEntityWithRefence(id);
            Console.WriteLine(actual);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Insert 的测试
        ///</summary>
        [TestMethod()]
        public void InsertTest1()
        {
            BookDAL target = new BookDAL(); // TODO: 初始化为适当的值
            Book book = new Book { Name="test"}; // TODO: 初始化为适当的值
            int expected = 12; // TODO: 初始化为适当的值
            int actual;
            actual = target.Insert(book);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}

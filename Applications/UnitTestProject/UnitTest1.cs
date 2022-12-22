using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLogin ()
        {
            int count_login = 1;
            int count_password = 1;
            bool expected = true;
            Applications.MainWindow a = new Applications.MainWindow();
            bool actual=a.Login(count_login, count_password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodLogin2()
        {
            int count_login = 1;
            int count_password = 0;
            bool expected = false;
            Applications.MainWindow a = new Applications.MainWindow();
            bool actual = a.Login(count_login, count_password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodAppealsInfoStatus()
        {
            string status = "В разработке";
            Applications.AppealsInfo a = new Applications.AppealsInfo();
            bool actual = a.Method(status);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodAppealsInfoStatus2()
        {
            string status = "Готово";
            Applications.AppealsInfo a = new Applications.AppealsInfo();
            bool actual = a.Method(status);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodStatus()
        {
            string status = "Готово";
            Applications.AppealsInfo a = new Applications.AppealsInfo();
            bool actual = a.MethodStatus(status);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}

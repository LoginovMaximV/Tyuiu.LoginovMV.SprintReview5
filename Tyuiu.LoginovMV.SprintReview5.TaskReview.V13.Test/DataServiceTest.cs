using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.SprintReview5.TaskReview.V13.Lib;
using System.IO;
namespace Tyuiu.LoginovMV.SprintReview5.TaskReview.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\\Users\Валерий\source\repos\Tyuiu.LoginovMV.SprintReview5\DataSprint5\OutPutDataFileTask7V13.txt";
            FileInfo file = new FileInfo(path);
            bool fileExist = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Stub.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void FindLogFile_NameFile_True()
        {
            FileManager fileManager = new FileManager();
            bool actual = fileManager.FindLogFile("file1.txt");
            Assert.IsTrue(actual);

           // Assert.IsTrue(fileManager.FindLogFile("file1.txt"));
        }
    }
}

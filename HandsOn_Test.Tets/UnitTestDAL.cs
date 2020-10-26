using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HandsOn_Test.DAL.Repositories;
using System.Collections.Generic;
using HandsOn_Test.DAL.Models;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HandsOn_Test.Tets
{
    [TestClass]
    public class UnitTestDAL
    {
        [TestMethod]
        public void TestRepo()
        {
            var repo = new EmployeeRepository();
            var result = repo.GetAllAsync().Result;
            Assert.IsNotNull(result.Count());
            Console.Write(result);
        }
    }
}

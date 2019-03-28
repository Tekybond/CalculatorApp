using CalculatorApp.DAL;
using CalculatorApp.DAL.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests.DAL
{
    [TestClass]
    public class RepositoryTest
    {
        private readonly IRepository objRepository;

        public RepositoryTest()
        {
            objRepository = new Repository();
        }

        [TestMethod]
        public void GetRingColorModelTest()
        {
            var result = objRepository.GetRingColorData();
            Assert.IsNotNull(result);
        }
    }
}

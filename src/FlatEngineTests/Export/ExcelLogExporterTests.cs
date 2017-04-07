using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatEngine.Export;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using FlatEngine.Tests;
using FlatEngine.TestData.Tests;

namespace FlatEngine.Export.Tests
{
    [TestClass()]
    public class ExcelLogExporterTests
    {
        private string tempTestDir;

        #region Additional test elements

        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            tempTestDir = TestUtil.CreateTempDir();
        }

        [TestCleanup()]
        public void TestCleanup()
        {
            TestUtil.DeleteDir(tempTestDir);
        }

        #endregion

        #region "Constructor"

        #region "Normal patterns"

        [TestMethod()]
        public void ConstructorTest_Norm()
        {
            string fileName = tempTestDir + @"\Dummy.csv";
            using (ExcelLogExporter target = new ExcelLogExporter(fileName))
            {
                Assert.IsNotNull(target);
            }
        }

        #endregion

        #region "Abnormal patterns"

        [TestMethod()]
        public void ConstructorTest_Abnorm_1()
        {
            try
            {
                using (ExcelLogExporter target = new ExcelLogExporter(""))
                {
                    Assert.Fail();
                }
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod()]
        public void ConstructorTest_Abnorm_2()
        {
            try
            {
                using (ExcelLogExporter target = new ExcelLogExporter(null))
                {
                    Assert.Fail();
                }
            }
            catch (ArgumentException)
            {
            }
        }

        #endregion

        #endregion

        [TestMethod()]
        public void ExportTest()
        {
            Assert.Fail();
        }
    }
}

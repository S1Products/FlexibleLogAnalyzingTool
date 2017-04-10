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

using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

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

        #region "Custom assertion"

        private void AssertSameExcel(string expectedFile, string actualFile)
        {
            string expFullPath = Path.GetFullPath(expectedFile);
            string actFullPath = Path.GetFullPath(actualFile);

            XSSFWorkbook expWorkbook = null;
            XSSFWorkbook actWorkbook = null;

            try
            {
                expWorkbook = new XSSFWorkbook(expFullPath);
                actWorkbook = new XSSFWorkbook(actFullPath);

                Assert.AreEqual(expWorkbook.NumberOfSheets, actWorkbook.NumberOfSheets);

                for (int i = 0; i < expWorkbook.NumberOfSheets; i++)
                {
                    ISheet expSheet = expWorkbook.GetSheetAt(i);
                    ISheet actSheet = actWorkbook.GetSheetAt(i);

                    Assert.AreEqual(expSheet.SheetName, actSheet.SheetName);
                    Assert.AreEqual(expSheet.LastRowNum, actSheet.LastRowNum);
                }
            }
            finally
            {
                if (expWorkbook != null)
                {
                    expWorkbook.Close();
                }

                if (actWorkbook != null)
                {
                    actWorkbook.Close();
                }
            }
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

        #region "Export"

        #region "Normal patterns"

        [TestMethod()]
        public void ExportTest_Norm_1()
        {
            string fileName = tempTestDir + @"\Dummy.xlsx";

            using (ProjectAccessor accessor = new ProjectAccessor())
            {
                FlatProject project = accessor.OpenProject(TestDataConstants.TEST_DATA_PATH_01);

                ParsedLog log = accessor.GetLogReader().ReadLines(project, 0, int.MaxValue);

                using (ExcelLogExporter target = new ExcelLogExporter(fileName))
                {
                    target.Export(project, log);
                }

                Assert.IsTrue(File.Exists(fileName));
                AssertSameExcel(TestDataConstants.EXCEL_DATA_PATH_01, fileName);
            }
        }

        [TestMethod()]
        public void ExportTest_Norm_2()
        {
            string fileName = tempTestDir + @"\Dummy.xlsx";

            using (ProjectAccessor accessor = new ProjectAccessor())
            {
                FlatProject project = accessor.OpenProject(TestDataConstants.TEST_DATA_PATH_01);

                ParsedLog log = new ParsedLog();

                using (ExcelLogExporter target = new ExcelLogExporter(fileName))
                {
                    target.Export(project, log);
                }

                Assert.IsTrue(File.Exists(fileName));
                AssertSameExcel(TestDataConstants.EXCEL_DATA_PATH_02, fileName);
            }
        }

        #endregion

        #region "Abnormal patterns"

        [TestMethod()]
        public void ExportTest_Abnorm_1()
        {
            string fileName = tempTestDir + @"\Dummy.xlsx";

            using (ProjectAccessor accessor = new ProjectAccessor())
            {
                FlatProject project = accessor.OpenProject(TestDataConstants.TEST_DATA_PATH_01);

                ParsedLog log = accessor.GetLogReader().ReadLines(project, 0, int.MaxValue);

                try
                {
                    using (ExcelLogExporter target = new ExcelLogExporter(fileName))
                    {
                        target.Export(null, log);
                        Assert.Fail();
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Assert.AreEqual("FlatProject", ex.ParamName);
                }
            }
        }

        [TestMethod()]
        public void ExportTest_Abnorm_2()
        {
            string fileName = tempTestDir + @"\Dummy.xlsx";

            using (ProjectAccessor accessor = new ProjectAccessor())
            {
                FlatProject project = accessor.OpenProject(TestDataConstants.TEST_DATA_PATH_01);
                ParsedLog log = new ParsedLog();

                try
                {
                    using (ExcelLogExporter target = new ExcelLogExporter(fileName))
                    {
                        target.Export(project, null);
                        Assert.Fail();
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Assert.AreEqual("ParsedLog", ex.ParamName);
                }
            }
        }

        [TestMethod()]
        public void ExportTest_Abnorm_3()
        {
            string fileName = tempTestDir + @"\Dummy.xlsx";

            try
            {
                using (ExcelLogExporter target = new ExcelLogExporter(fileName))
                {
                    target.Export(null, null);
                    Assert.Fail();
                }
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("FlatProject", ex.ParamName);
            }
        }

        #endregion

        #endregion
    }
}

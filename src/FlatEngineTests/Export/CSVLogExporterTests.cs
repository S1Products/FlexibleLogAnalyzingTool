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
    public class CSVLogExporterTests
    {
        public const string SKIP_LINE_SYMBOL = "#";

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

        private void AssertSameCSV(string expectedCSVFile, string actualCSVFile)
        {
            using (StreamReader expReader = new StreamReader(expectedCSVFile))
            {
                using (StreamReader actReader = new StreamReader(actualCSVFile))
                {
                    while (true)
                    {
                        string expLine = expReader.ReadLine();
                        string actLine = actReader.ReadLine();

                        if (expLine == null && actLine == null)
                        {
                            return;
                        }
                        else if ((expLine == null && actLine != null)
                            || (expLine != null && actLine == null))
                        {
                            Assert.Fail("Unexpected CSV file exported.");
                        }

                        // Check skip line (e.g. Exported date)
                        if (expLine.Length > 0 && expLine.Substring(0, 1) == SKIP_LINE_SYMBOL)
                        {
                            continue;
                        }

                        if (expLine != actLine)
                        {
                            Assert.Fail("Unexpected CSV file exported. Expected:" + expLine + ", Actual:" + actLine);
                        }
                    }
                }
            }
        }

        #endregion

        #region "Constructor"

        #region "Normal patterns"

        [TestMethod()]
        public void ConstructorTest_Norm_P1()
        {
            string fileName = tempTestDir + @"\Dummy.csv";
            using (CSVLogExporter target = new CSVLogExporter(fileName))
            {
                Assert.IsNotNull(target);
                Assert.AreEqual(CSVLogExporter.DEFAULT_DELIMITER, target.Delimiter);
                Assert.IsTrue(File.Exists(fileName));
            }
        }

        [TestMethod()]
        public void ConstructorTest_Norm_P2()
        {
            string fileName = tempTestDir + @"\Dummy.csv";
            string delim = "|";

            using (CSVLogExporter target = new CSVLogExporter(fileName, delim))
            {
                Assert.IsNotNull(target);
                Assert.AreEqual(delim, target.Delimiter);
                Assert.IsTrue(File.Exists(fileName));
            }
        }

        [TestMethod()]
        public void ConstructorTest_Norm_P4()
        {
            string fileName = tempTestDir + @"\Dummy.csv";
            string delim = "|";
            bool append = false;
            Encoding utf8 = Encoding.UTF8;

            using (CSVLogExporter target = new CSVLogExporter(fileName, delim, append, utf8))
            {
                Assert.IsNotNull(target);
                Assert.AreEqual(delim, target.Delimiter);
                Assert.IsTrue(File.Exists(fileName));
            }
        }

        #endregion

        #region "Abnormal patterns"

        [TestMethod()]
        public void ConstructorTest_Abnorm_P1_1()
        {
            string fileName = @"";

            try
            {
                using (CSVLogExporter target = new CSVLogExporter(fileName))
                {
                    Assert.Fail();
                }
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod()]
        public void ConstructorTest_Abnorm_P1_2()
        {
            string fileName = null;
            
            try
            {
                using (CSVLogExporter target = new CSVLogExporter(fileName))
                {
                    Assert.Fail();
                }
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod()]
        public void ConstructorTest_Abnorm_P1_3()
        {
            string fileName = @"dummy:/aaa.csv";

            try
            {
                using (CSVLogExporter target = new CSVLogExporter(fileName))
                {
                    Assert.Fail();
                }
            }
            catch (NotSupportedException)
            {
            }
        }

        [TestMethod()]
        public void ConstructorTest_Abnorm_P2_1()
        {
            string fileName = tempTestDir + @"\Dummy.csv";
            string delim = @"";

            using (CSVLogExporter target = new CSVLogExporter(fileName, delim))
            {
                Assert.IsNotNull(target);
                Assert.AreEqual(delim, target.Delimiter);
                Assert.IsTrue(File.Exists(fileName));
            }
        }

        [TestMethod()]
        public void ConstructorTest_Abnorm_P2_2()
        {
            string fileName = tempTestDir + @"\Dummy.csv";
            string delim = null;

            using (CSVLogExporter target = new CSVLogExporter(fileName, delim))
            {
                Assert.IsNotNull(target);
                Assert.AreEqual(delim, target.Delimiter);
                Assert.IsTrue(File.Exists(fileName));
            }
        }

        [TestMethod()]
        public void ConstructorTest_Abnorm_P4_3()
        {
            string fileName = tempTestDir + @"\Dummy.csv";
            string delim = "|";
            bool append = false;
            Encoding utf8 = null;

            try
            {
                using (CSVLogExporter target = new CSVLogExporter(fileName, delim, append, utf8))
                {
                    Assert.Fail();
                }
            }
            catch (ArgumentNullException)
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
            string fileName = tempTestDir + @"\Dummy.csv";

            using (ProjectAccessor accessor = new ProjectAccessor())
            {
                FlatProject project = accessor.OpenProject(TestDataConstants.TEST_DATA_PATH_01);

                ParsedLog log = accessor.GetLogReader().ReadLines(project, 0, int.MaxValue);

                using (CSVLogExporter target = new CSVLogExporter(fileName))
                {
                    target.Export(project, log);
                }

                Assert.IsTrue(File.Exists(fileName));
                AssertSameCSV(TestDataConstants.CSV_DATA_PATH_01, fileName);
            }
        }

        [TestMethod()]
        public void ExportTest_Norm_2()
        {
            string fileName = tempTestDir + @"\Dummy.csv";

            using (ProjectAccessor accessor = new ProjectAccessor())
            {
                FlatProject project = accessor.OpenProject(TestDataConstants.TEST_DATA_PATH_01);

                ParsedLog log = accessor.GetLogReader().ReadLines(project, 0, int.MaxValue);

                using (CSVLogExporter target = new CSVLogExporter(fileName))
                {
                    target.Delimiter = "|";
                    target.Export(project, log);
                }

                Assert.IsTrue(File.Exists(fileName));
                AssertSameCSV(TestDataConstants.CSV_DATA_PATH_02, fileName);
            }
        }

        [TestMethod()]
        public void ExportTest_Norm_3()
        {
            string fileName = tempTestDir + @"\Dummy.csv";

            using (ProjectAccessor accessor = new ProjectAccessor())
            {
                FlatProject project = accessor.OpenProject(TestDataConstants.TEST_DATA_PATH_01);

                // Empty logs
                ParsedLog log = new ParsedLog();

                using (CSVLogExporter target = new CSVLogExporter(fileName))
                {
                    target.Export(project, log);
                }

                Assert.IsTrue(File.Exists(fileName));
                AssertSameCSV(TestDataConstants.CSV_DATA_PATH_03, fileName);
            }
        }

        #endregion

        #region "Abnormal patterns"

        [TestMethod()]
        public void ExportTest_Abnorm_1()
        {
            string fileName = tempTestDir + @"\Dummy.csv";

            using (ProjectAccessor accessor = new ProjectAccessor())
            {
                FlatProject project = accessor.OpenProject(TestDataConstants.TEST_DATA_PATH_01);

                ParsedLog log = accessor.GetLogReader().ReadLines(project, 0, int.MaxValue);

                using (CSVLogExporter target = new CSVLogExporter(fileName))
                {
                    try
                    {
                        target.Export(null, log);
                        Assert.Fail();
                    }
                    catch (ArgumentNullException ex)
                    {
                        Assert.AreEqual("FlatProject", ex.ParamName);
                    }
                }
            }
        }

        [TestMethod()]
        public void ExportTest_Abnorm_2()
        {
            string fileName = tempTestDir + @"\Dummy.csv";

            using (ProjectAccessor accessor = new ProjectAccessor())
            {
                FlatProject project = accessor.OpenProject(TestDataConstants.TEST_DATA_PATH_01);

                using (CSVLogExporter target = new CSVLogExporter(fileName))
                {
                    try
                    {
                        target.Export(project, null);
                        Assert.Fail();
                    }
                    catch (ArgumentNullException ex)
                    {
                        Assert.AreEqual("ParsedLog", ex.ParamName);
                    }
                }
            }
        }

        #endregion

        #endregion
    }
}

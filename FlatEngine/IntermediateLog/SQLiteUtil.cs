using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.SQLite;

namespace FlatEngine.IntermediateLog
{
    public class SQLiteUtil
    {
        private static Log log = new Log(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Open connection to SQLite
        /// </summary>
        /// <param name="fileName">Database file name</param>
        /// <returns>Connection</returns>
        public static SQLiteConnection OpenConnection(string fileName)
        {
            log.In(fileName);

            SQLiteConnection con = new SQLiteConnection("Data Source=" + fileName + ";Version=3;");
            con.Open();

            log.Out(con);
            return con;
        }

        /// <summary>
        /// Close connection from SQLite
        /// </summary>
        /// <param name="con">Connection</param>
        public static void CloseConnection(SQLiteConnection con)
        {
            log.In(con);

            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            log.Out();
        }
    }
}

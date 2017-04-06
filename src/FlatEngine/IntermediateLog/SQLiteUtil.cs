#region Apache License
//
// Licensed to the Apache Software Foundation (ASF) under one or more 
// contributor license agreements. See the NOTICE file distributed with
// this work for additional information regarding copyright ownership. 
// The ASF licenses this file to you under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with 
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

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

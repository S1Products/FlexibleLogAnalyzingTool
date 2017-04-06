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

namespace FlatEngine.IntermediateLog
{
    /// <summary>
    /// Constant values for Intermediate log access
    /// </summary>
    /// <author>Miura Acoustic</author>
    public class IntermediateLogConstants
    {
        #region "Hashed values table"

        /// <summary>
        /// Hashed value table name
        /// </summary>
        public const string TABLE_NAME_HASHED_VALUES = "HASHED_VALUES";

        /// <summary>
        /// Hashed value index name
        /// </summary>
        public const string INDEX_NAME_HASHED_VALUES = "HASHED_VALUES_IDX";

        /// <summary>
        /// Hashed value ID column name
        /// </summary>
        public const string COL_NAME_HV_ID = "ID";

        /// <summary>
        /// Hashed value column name
        /// </summary>
        public const string COL_NAME_HV_VALUE = "VALUE";

        #endregion

        #region "Log files table"

        /// <summary>
        /// Log files table name
        /// </summary>
        public const string TABLE_NAME_LOG_FILES = "LOG_FILES";

        /// <summary>
        /// Log files index name
        /// </summary>
        public const string INDEX_NAME_LOG_FILES = "LOG_FILES_IDX";

        /// <summary>
        /// Log files ID column name
        /// </summary>
        public const string COL_NAME_LF_ID = "ID";

        /// <summary>
        /// Log files file name column name
        /// </summary>
        public const string COL_NAME_LF_FILE_NAME = "FILE_NAME";

        #endregion

        #region "Parsed log table"

        /// <summary>
        /// Parsed log table name
        /// </summary>
        public const string TABLE_NAME_PARSED_LOGS = "PARSED_LOGS";

        /// <summary>
        /// Parsed log index name
        /// </summary>
        public const string INDEX_NAME_PARSED_LOGS = "PARSED_LOGS_IDX";

        /// <summary>
        /// Parsed log ID column name
        /// </summary>
        public const string COL_NAME_PL_ID = "ID";

        /// <summary>
        /// Parsed log line number column name
        /// </summary>
        public const string COL_NAME_PL_LINE_NUM = "LINE_NUM";

        /// <summary>
        /// Parsed log file name ID column name
        /// </summary>
        public const string COL_NAME_PL_FILE_ID = "FILE_NAME_ID";

        /// <summary>
        /// Parsed log has error flag column name
        /// </summary>
        public const string COL_NAME_PL_HAS_ERROR = "HAS_ERROR";

        /// <summary>
        /// Parsed log not parsed line column name
        /// </summary>
        public const string COL_NAME_PL_NOT_PARSED_LINE = "NOT_PARSED_LINE";

        #endregion
    }
}

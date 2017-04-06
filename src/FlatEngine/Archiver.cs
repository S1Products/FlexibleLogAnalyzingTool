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

using System.IO.Compression;

namespace FlatEngine
{
    /// <summary>
    /// Zip archiver to project items.
    /// </summary>
    public class Archiver
    {
        private static Log log = new Log(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Compress zip file from specified directory
        /// </summary>
        /// <param name="sourceDir">Archiving source directory</param>
        /// <param name="destFileName">Destination of zip file</param>
        public static void CompressDirectory(string sourceDir, string destFileName)
        {
            log.In(sourceDir, destFileName);

            ZipFile.CreateFromDirectory(sourceDir, destFileName, CompressionLevel.Optimal, false);

            log.Out();
        }

        /// <summary>
        /// Decompress zip file to specified directory
        /// </summary>
        /// <param name="projectFilePath">Decompress target zip file path</param>
        /// <param name="destDir">Destination of decompressed files</param>
        public static void Decompress(string projectFilePath, string destDir)
        {
            log.In(projectFilePath, destDir);

            ZipFile.ExtractToDirectory(projectFilePath, destDir);

            log.Out();
        }
    }
}

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
using System.IO;

using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using FlatEngine.IntermediateLog;
using FlatEngine.Export;

namespace FlatEngine
{
    /// <summary>
    /// Project file accessor.
    /// </summary>
    /// <author>Miura Acoustic</author>
    public class ProjectAccessor
    {
        private Log log = new Log(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Database file name
        /// </summary>
        public const string DATABASE_FILE_NAME   = "ParsedLog.db";

        /// <summary>
        /// Flat project file name
        /// </summary>
        public const string FLAT_PROJECT_FILE_NAME = "Flat.project";

        /// <summary>
        /// Opened project file
        /// </summary>
        private FlatProject currentProject;

        /// <summary>
        /// Parsed log reader
        /// </summary>
        private IntermediateLogReader reader;

        /// <summary>
        /// Current opened project property
        /// </summary>
        public FlatProject CurrentProject
        {
            get
            {
                return currentProject;
            }
        }

        #region "Operate Project file"

        /// <summary>
        /// Create new project
        /// </summary>
        /// <param name="logFileName">Log file name</param>
        /// <param name="projectName">Project name</param>
        /// <param name="patternDef">Analyzing pattern</param>
        /// <param name="enc">Log file encoding</param>
        /// <returns>Created project</returns>
        public FlatProject CreateProject(String logFileName, string projectName, PatternDefinition patternDef, Encoding enc)
        {
            log.In(logFileName, projectName, patternDef);

            using(FileStream readStream = new FileStream(logFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)){

                FlatProject ret = CreateProject(logFileName, readStream, projectName, patternDef, enc);
                log.Out(ret);
                return ret;
            }
        }

        /// <summary>
        /// Create new project
        /// </summary>
        /// <param name="fileName">Log file name</param>
        /// <param name="logStream">Log file stream</param>
        /// <param name="projectName">Project name</param>
        /// <param name="patternDef">Analyzing pattern</param>
        /// <param name="enc">Log file encoding</param>
        /// <returns>Created project</returns>
        public FlatProject CreateProject(string fileName, Stream logStream, string projectName, PatternDefinition patternDef, Encoding enc)
        {
            log.In(logStream, projectName, patternDef);

            if (patternDef == null)
            {
                patternDef = PatternDefinition.CreateDefault();
            }

            currentProject = new FlatProject();
            currentProject.ProjectName = projectName;
            currentProject.PatternDefinition = patternDef;

            string tempDir = CreateTempDirectory();
            currentProject.WorkingDirectory = tempDir;

            string logFileName = CreateDatabaseFilePath(currentProject);

            using (IntermediateLogWriter imLogWriter = new IntermediateLogWriter(logFileName, patternDef))
            {
                imLogWriter.Write(fileName, logStream, enc);
            }

            reader = new IntermediateLogReader(logFileName);

            log.Out(currentProject);
            return currentProject;
        }

        /// <summary>
        /// Open project from archived project file
        /// </summary>
        /// <param name="projectFilePath">Archived project file path</param>
        /// <returns>Opened flat project</returns>
        public FlatProject OpenProject(string projectFilePath)
        {
            log.In(projectFilePath);

            string tempDirectory = CreateTempDirectory();
            Archiver.Decompress(projectFilePath, tempDirectory);

            currentProject = DeserializeProject(CreateProjectFilePath(tempDirectory));
            currentProject.WorkingDirectory = tempDirectory;

            string logFileName = CreateDatabaseFilePath(currentProject);
            reader = new IntermediateLogReader(logFileName);

            log.Out(currentProject);
            return currentProject;
        }

        /// <summary>
        /// Save project to archived project file
        /// </summary>
        /// <param name="projectFilePath">Project file path</param>
        public void SaveProject(string projectFilePath)
        {
            log.In(projectFilePath);

            if (File.Exists(projectFilePath))
            {
                File.Delete(projectFilePath);
            }

            reader.Close();

            SerializeProject(currentProject, CreateProjectFilePath(currentProject.WorkingDirectory));
            Archiver.CompressDirectory(currentProject.WorkingDirectory, projectFilePath);

            string logFileName = CreateDatabaseFilePath(currentProject);
            reader = new IntermediateLogReader(logFileName);

            log.Out();
        }

        /// <summary>
        /// Close current project.
        /// And remove temporary working directory
        /// </summary>
        public void CloseProject()
        {
            log.In();

            if(currentProject != null)
            {
                reader.Close();
                DeleteTempDirectory(currentProject.WorkingDirectory);
                currentProject = null;
            }

            log.Out();
        }

        #endregion

        #region "Import log"

        /// <summary>
        /// Import log file to database
        /// </summary>
        /// <param name="fileName">Log file name</param>
        /// <param name="enc">Log file encoding</param>
        public void ImportLog(string fileName, Encoding enc)
        {
            log.In(fileName, enc);

            using (FileStream readStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                ImportLog(fileName, readStream, enc);
            }

            log.Out();
        }

        /// <summary>
        /// Import log file to database
        /// </summary>
        /// <param name="fileName">Log file name</param>
        /// <param name="logStream">Log file stream</param>
        /// <param name="enc">Log file encoding</param>
        public void ImportLog(string fileName, Stream logStream, Encoding enc)
        {
            log.In(fileName, logStream, enc);

            PatternDefinition patternDef = currentProject.PatternDefinition;
            string logFileName = CreateDatabaseFilePath(currentProject);

            using (IntermediateLogWriter imLogWriter = new IntermediateLogWriter(logFileName, patternDef))
            {
                imLogWriter.Write(fileName, logStream, enc);
            }

            log.Out();
        }

        #endregion

        #region "Export log"

        public void ExportLog(LogExporter exporter)
        {
            log.In(exporter);

            ParsedLog parsedLog 
                = reader.ReadLines(currentProject, 0, int.MaxValue);

            ExportLog(exporter, parsedLog);

            log.Out();
        }

        public void ExportLog(LogExporter exporter, ParsedLog parsedLog)
        {
            log.In(exporter);

            exporter.Export(currentProject, parsedLog);

            log.Out();
        }

        #endregion

        /// <summary>
        /// Get log reader
        /// </summary>
        /// <returns>Log reader</returns>
        public IntermediateLogReader GetLogReader()
        {
            return reader;
        }

        #region "Internal method"

        #region "Create file path"

        /// <summary>
        /// Create database file path with current project working directory.
        /// </summary>
        /// <param name="project">Opened project</param>
        /// <returns>Database file path</returns>
        private string CreateDatabaseFilePath(FlatProject project)
        {
            log.InPrivate(project);

            string ret = project.WorkingDirectory + @"\" + DATABASE_FILE_NAME;
            log.OutPrivate(ret);
            return ret;
        }

        /// <summary>
        /// Create project file path
        /// </summary>
        /// <param name="filePath">Working directory</param>
        /// <returns></returns>
        private string CreateProjectFilePath(string filePath)
        {
            log.InPrivate(filePath);

            string ret = filePath + @"\" + FLAT_PROJECT_FILE_NAME;
            log.OutPrivate(ret);
            return ret;
        }

        #endregion

        #region "Processing for temp dir"

        /// <summary>
        /// Create temporary directory
        /// </summary>
        /// <returns>Temporary directory path</returns>
        private string CreateTempDirectory()
        {
            log.InPrivate();

            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);

            log.OutPrivate(tempDirectory);
            return tempDirectory;
        }

        /// <summary>
        /// Delete temporary directory
        /// </summary>
        /// <param name="tempDirectory">Temporary directory path</param>
        private void DeleteTempDirectory(string tempDirectory)
        {
            log.InPrivate(tempDirectory);

            if (Directory.Exists(tempDirectory))
            {
                Directory.Delete(tempDirectory, true);
            }

            log.OutPrivate();
        }

        #endregion

        #region "Serializer for FlatProject"

        /// <summary>
        /// Serialize project to file
        /// </summary>
        /// <param name="project">Target project</param>
        /// <param name="path">Destination path</param>
        private void SerializeProject(FlatProject project, string path)
        {
            log.In(project, path);

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, project);
            }

            log.Out();
        }

        /// <summary>
        /// Deserialize project from file
        /// </summary>
        /// <param name="path">Source path</param>
        /// <returns>Project</returns>
        private FlatProject DeserializeProject(string path)
        {
            log.In(path);

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();

                FlatProject ret = (FlatProject)bf.Deserialize(fs);
                log.Out(ret);
                return ret;
            }
        }

        #endregion 

        #endregion
    }
}

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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using FlatEngine;

namespace FlexibleLogAnalyzerTool
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>Miura Acoustic</author>
    public class SettingFileAccessor
    {
        public static void InitializeSettingDirectories(string appPath)
        {
            // 設定ファイルの置き場所を作成
            string settingRootPath = CreateSettingRootPath(appPath);

            if (!Directory.Exists(settingRootPath))
            {
                Directory.CreateDirectory(settingRootPath);
            }

            // パターン定義ファイルの置き場所を作成
            string patternPath = CreatePatternDefinitionPath(appPath);

            if (!Directory.Exists(patternPath))
            {
                Directory.CreateDirectory(patternPath);
            }
        }

        #region "PatternDefinitionの処理"

        public static PatternDefinition AddNewPatternDefinition(string appPath)
        {
            PatternDefinition newPattern = PatternDefinition.CreateNew();
            SavePatternDefinition(appPath, newPattern);

            return newPattern;
        }

        public static PatternDefinition CopyPatternDefinition(string appPath, PatternDefinition source)
        {
            PatternDefinition dest = PatternDefinition.Copy(source);
            SavePatternDefinition(appPath, dest);

            return dest;
        }

        public static void SavePatternDefinition(string appPath, PatternDefinition pattern)
        {
            string patternPath = CreatePatternDefinitionPath(appPath);

            string filePath = patternPath + @"\" + pattern.PatternName + "_" + pattern.ID + SettingsConstants.EXTENSION_PATTERN_FILE;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            SerializePatternDefinition(pattern, filePath);
        }

        public static List<PatternDefinition> LoadPatternDefinitionList(string appPath)
        {
            List<PatternDefinition> patternList = new List<PatternDefinition>();

            string patternPath = CreatePatternDefinitionPath(appPath);
            string[] files = Directory.GetFiles(patternPath, "*" + SettingsConstants.EXTENSION_PATTERN_FILE);

            foreach (string file in files)
            {
                PatternDefinition pattern = DeserializePatternDefinition(file);
                patternList.Add(pattern);
            }

            return patternList;
        }

        public static void DeletePatternDefinition(string appPath, PatternDefinition pattern)
        {
            string patternPath = CreatePatternDefinitionPath(appPath);
            string filePath = patternPath + @"\" + pattern.PatternName + "_" + pattern.ID + SettingsConstants.EXTENSION_PATTERN_FILE;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        #endregion

        #region "内部処理"

        private static string CreateSettingRootPath(string appPath)
        {
            return appPath + @"\" + SettingsConstants.SETTING_DIR_ROOT;
        }

        private static string CreatePatternDefinitionPath(string appPath)
        {
            return CreateSettingRootPath(appPath) + @"\" + SettingsConstants.SETTING_DIR_PATTERN;
        }

        #region "シリアライザ"

        public static void SerializeObject(object obj, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, obj);
            }
        }

        public static object DeserializeObject(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return bf.Deserialize(fs);
            }
        }

        public static void SerializePatternDefinition(PatternDefinition pattern, string path)
        {
            SerializeObject(pattern, path);
        }

        public static PatternDefinition DeserializePatternDefinition(string path)
        {
            return (PatternDefinition)DeserializeObject(path);
        }

        #endregion 

        #endregion
    }
}

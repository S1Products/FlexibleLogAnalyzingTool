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

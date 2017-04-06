using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatEngine.Export
{
    public abstract class LogExporter : IDisposable
    {
        /// <summary>
        /// Export logs to specified format
        /// </summary>
        /// <param name="project">Target project</param>
        /// <param name="log">Target logs</param>
        public void Export(FlatProject project, ParsedLog log)
        {
            OnRenderDocumentHeader(project, log);

            OnRenderMain(project, log);

            OnRenderDocumentFooter(project, log);
        }

        public abstract void OnRenderDocumentHeader(FlatProject project, ParsedLog log);

        public abstract void OnRenderMain(FlatProject project, ParsedLog log);

        public abstract void OnRenderDocumentFooter(FlatProject project, ParsedLog log);


        public void Close()
        {
            OnClose();
        }

        public abstract void OnClose();

        public void Dispose()
        {
            Close();
        }
    }
}

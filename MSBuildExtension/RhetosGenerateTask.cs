using System.Diagnostics;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Rhetos.MSBuildExtension
{
    public class RhetosGenerateTask : Task
    {
        [Required]
        public string NugetFolder { get; set; }

        [Required]
        public string ResolvedPackagesFile { get; set; }

        [Required]
        public ITaskItem[] References { get; set; }

        [Required]
        public string ProjectFullPath { get; set; }

        [Required]
        public string OutputFolder { get; set; }

        public override bool Execute()
        {
            return true;
        }

        private void MyProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Log.LogMessage(MessageImportance.High, e.Data);
        }

        private void MyProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Log.LogError(e.Data);
        }
    }
}
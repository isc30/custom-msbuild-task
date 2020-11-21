using System;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace CustomTask
{
    public class TestTask : Task
    {
        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "Hello from the Custom MsBuild Task!");
            return true;
        }
    }
}

using System;

namespace RunCommands
{
    public class ExecuteCommands
    {
        public string ExecuteCommand(string command)
        {
            
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C" + command);
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = processStartInfo;
            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            ////Console.WriteLine(result);
            return result;
        }
    }
}

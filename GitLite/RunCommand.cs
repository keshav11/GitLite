/*
 * Created by SharpDevelop.
 * User: Keshav
 * Date: 8/28/2015
 * Time: 7:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
namespace GitLite
{
    /// <summary>
    /// Description of RunCommand.
    /// </summary>
    public class RunCommand
    {
        public static string runCommand(string runCommandString, string location)
        {

            Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = @"cmd.exe";
            p.StartInfo.Arguments = @"/c " + runCommandString;

            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.WorkingDirectory = location;
            p.Start();

            string strOutput = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return strOutput;
        }
    }
}

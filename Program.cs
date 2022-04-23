using System;
using System.IO;

namespace ArgsToFile
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args.Length < 1) return;
            string argstr = string.Join(" ", args);
            string path =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "adb.log");
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(argstr);
                }
            } else {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(argstr); ;
                }
            }
        }
    }
}

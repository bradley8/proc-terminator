using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProcTerminator
{
    class ProcessTerminator
    {
        internal bool TerminateProcesses(string[] processNames)
        {
            var procs = new List<Process>();
            Console.Clear();
            DisplayBanner();

            foreach (var name in processNames)
            {
                procs.AddRange(Process.GetProcessesByName(name));
            }

            Console.WriteLine("------------------------------------------------------------");

            if (procs.Count > 0)
            {
                foreach (var proc in procs)
                {
                    if (!proc.HasExited)
                    {
                        Console.WriteLine(proc + " process terminated");
                        proc.Kill();
                    }
                }
            }
            else
            {
                foreach (var name in processNames)
                {
                    Console.WriteLine("No " + name + " processes to terminate");
                }
            }

            Console.WriteLine("------------------------------------------------------------");

            return true;
        }

        /// <summary>
        /// Runs procterminator quietly, helpful when called from the command line and no UI is desired.
        /// </summary>
        /// <param name="processNames"></param>
        /// <returns></returns>
        internal bool TerminateProcessesQuietly(string[] processNames)
        {
            var procs = new List<Process>();
            
            foreach (var name in processNames)
            {
                procs.AddRange(Process.GetProcessesByName(name));
            }

            if (procs.Count > 0)
            {
                foreach (var proc in procs)
                {
                    if (!proc.HasExited)
                    {
                        proc.Kill();
                    }
                }
            }

            return true;
        }

        public void DisplayBanner()
        {
            // Display the banner.
            Console.WriteLine(@"___  ____ ____ ____    ___ ____ ____ _  _ _ _  _ ____ ___ ____ ____ ");
            Console.WriteLine(@"|__] |__/ |  | |        |  |___ |__/ |\/| | |\ | |__|  |  |  | |__/ ");
            Console.WriteLine(@"|    |  \ |__| |___     |  |___ |  \ |  | | | \| |  |  |  |__| |  \ v3.1");
            Console.WriteLine(@"------------------------------------------------------------------------");
            Console.WriteLine(@"B-radical Software 2018");
            Console.WriteLine(@"C3 Certified");
            Console.WriteLine(@"");

        }
    }
}

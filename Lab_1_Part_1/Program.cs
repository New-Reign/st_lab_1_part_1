using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(Process p in Process.GetProcesses())
            {
                using(p)
                {
                    Console.WriteLine(p.ProcessName);
                    Console.WriteLine(" PID: " + p.Id);
                    Console.WriteLine(" Memory: " + p.PeakWorkingSet64);
                    Console.WriteLine(" Threads: " + p.Threads.Count);
                    try
                    {
                        Console.WriteLine(" Start Time: " + p.StartTime);
                        Console.WriteLine( "Processor Time: " + p.TotalProcessorTime);
                    }
                    catch(System.ComponentModel.Win32Exception ex)
                    {
                        Console.WriteLine(" You have insufficient permissions.");
                    }
                }
            }
        }
    }
}

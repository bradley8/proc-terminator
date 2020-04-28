using System;

namespace ProcTerminator
{
    class TerminatorApp
    {
        static void Main(string[] args)
        {
            // Terminator object. Used to terminate processes.
            ProcessTerminator terminator = new ProcessTerminator();

            // If there are command line arguments, run terminator quietly without a UI.
            if (args.Length > 0)
            {
                terminator.TerminateProcessesQuietly(args);
            }
            else
            {
                // Holds the user's menu choice.
                string choice;

                // Display the banner.
                terminator.DisplayBanner();

                // Display menu options until user types "e" to exit.
                do
                {
                    // Display menu options.
                    Console.WriteLine("(Press)");
                    Console.WriteLine("(1) To Terminate Chrome processes");
                    Console.WriteLine("(2) To Terminate Firefox processes");
                    Console.WriteLine("(3) To Terminate IE processes");
                    Console.WriteLine("(4) To Terminate Edge processes");
                    Console.WriteLine("(5) To Terminate browser processes");
                    Console.WriteLine("(6) To Terminate ALM processes");
                    Console.WriteLine("(7) To Terminate UFT processes");
                    Console.WriteLine("Or e to exit");

                    // Get the user's choice
                    choice = Console.ReadLine().ToLower().Trim();

                    // Act on the choice
                    switch (choice)
                    {
                        case "1":
                            // Terminate Chrome processes
                            terminator.TerminateProcesses(new string[] { "chrome", "chromedriver" });
                            break;

                        case "2":
                            // Terminate Firefox processes
                            terminator.TerminateProcesses(new string[] { "firefox", "geckodriver" });
                            break;

                        case "3":
                            // Terminate Internet Explorer processes
                            terminator.TerminateProcesses(new string[] { "iexplore", "iedriverserver" });
                            break;

                        case "4":
                            // Terminate Internet Explorer processes
                            terminator.TerminateProcesses(new string[] { "microsoftedge", "microsoftwebdriver" });
                            break;

                        case "5":
                            // Termine all processes
                            terminator.TerminateProcesses(new string[]
                            { 
                              "chrome",
                              "chromedriver",
                              "firefox",
                              "geckodriver",
                              "iexplore", 
                              "iedriverserver",
                              "microsoftedge",
                              "microsoftwebdriver"
                            });
                            break;

                        case "6":
                            // Terminate ALM Client processes
                            terminator.TerminateProcesses(new string[] { "ALM-Client" });
                            break;
                                                        
                        case "7":
                            // Terminate UFT processes
                            terminator.TerminateProcesses(new string[] { "UFT" });
                            break;
                            
                    }

                } while (choice != "e");
            }
        }
    }
}

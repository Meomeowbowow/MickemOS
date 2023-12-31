/*
 * PROJECT: MICKEM OS COMMAND HANDLER
 * VERSION: 0.1
 * PROGRAMMER: MEOMEOWBOWOW
 * FILE: /CORE/COMMAND/COMMANDHANDLER.CS
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MickemOS.Kernel;
using MickemOS.Core.FileSystem;

namespace MickemOS.Commands
{
    class CommandHandler
    {

        public static void HandleCommands()
        {
            MickemOS.Core.FileSystem.FSManager.Manager.RegisterVFS();

            while (true)
            {
                string command;
                Console.Write("\nuser@mickem>");
                command = Console.ReadLine();

                if (command.ToLower() == "echo")
                {
                    string echotext;
                    Console.Write("Enter text to echo:");
                    echotext = Console.ReadLine();
                    Console.Write(echotext);
                }

                else if (command.ToLower() == "help")
                {
                    Console.Write("Welcome to the MickemOS Help Centre!\n");
                    Console.Write("Help - Shows the help centre\n");
                    Console.Write("Echo - Echos text\n");
                    Console.Write("kernel-ver - Shows the current kernel version\n");
                    Console.Write("Minfo - Shows MickemOS Info\n");
                    Console.Write("Clear - Clears the screen\n");
                    Console.Write("Restart - Restart your machine\n");
                    Console.Write("Shutdown    - Restart your machine");
                }

                if (command.ToLower() == "clear")
                {
                    Console.Clear();
                }

                if (command.ToLower() == "restart")
                {
                    string rebootans;
                    Console.Write("Are you sure you want to restart this machine (Y/n)? ");
                    rebootans = Console.ReadLine();

                    if (rebootans.ToLower() == "y")
                    {
                        Cosmos.System.Power.Reboot();
                    }

                }

                if (command.ToLower() == "shutdown")
                {
                    Cosmos.System.Power.Shutdown();
                }

                if (command.ToLower() == "kernel-ver")
                {
                    Console.Write("Kernel Version: MickemOS Kernel " + MickemOS.Kernel.Kernel.kernel_ver);
                }

                if (command.ToLower() == "minfo")
                {
                    Console.Write("Kernel Version: MickemOS Kernel " + MickemOS.Kernel.Kernel.kernel_ver);
                    Console.Write("OS Version: MickemOS 1 | Build " + MickemOS.Kernel.Kernel.os_build);
                }

                if (command.ToLower() == "beep")
                {
                    Console.Beep();
                }

                if (command.ToLower() == "create-file")
                {
                    Console.Write("Enter a file name, path and extension: ");
                    string path = Console.ReadLine();
                    MickemOS.Core.FileSystem.FSManager.Manager.CreateFile(path);

                }

                if (command.ToLower() == "free-space")
                {
                    MickemOS.Core.FileSystem.FSManager.Manager.GetFreeSpace(@"0:\");
                    Console.Write(MickemOS.Core.FileSystem.FSManager.Manager.freespace);
                }

                if (command.ToLower() == "get-files")
                {
                    MickemOS.Core.FileSystem.FSManager.Manager.ListFiles(@"0:\");
                }

                if (command.ToLower() == "write-file")
                {
                    Console.Write("Enter the path to the file you want to write to: ");
                    string filepath = Console.ReadLine();
                    Console.Write("Enter the content you would like to write: ");
                    string content = Console.ReadLine();
                    MickemOS.Core.FileSystem.FSManager.Manager.WriteToFile(filepath, content);
                }
            }
        }
    }
}

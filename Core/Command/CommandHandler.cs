using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MickemOS.Kernel;

namespace MickemOS.Commands
{
    class CommandHandler
    {

        public static void HandleCommands()
        {


            while (true)
            {
                string command;
                Console.Write("user@mickem>");
                command = Console.ReadLine();

                if (command.ToLower() == "echo")
                {
                    string echotext;
                    Console.Write("Enter text to echo:");
                    echotext = Console.ReadLine();
                    Console.Write(echotext + "\n");
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
                    Console.Write("Shutdown    - Restart your machine\n");
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
                    Console.Write("Kernel Version: MickemOS Kernel 1.0\n");
                }

                if (command.ToLower() == "minfo")
                {
                    Console.Write("Kernel Version: MickemOS Kernel" + MickemOS.Kernel.Kernel.kernel_ver +"\n");
                    Console.Write("OS Version: MickemOS 1 | Build " + MickemOS.Kernel.Kernel.os_build + "\n");
                }
            }
        }
    }
}

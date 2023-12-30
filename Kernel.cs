using System;
using System.Threading;
using System.IO;
using Sys = Cosmos.System;
using MickemOS.Core;

namespace MickemOS.Kernel
{
    public class Kernel : Sys.Kernel
    {
        public static string kernel_ver = "1.4";
        public static string os_build = "1305";

        protected override void BeforeRun()
        {
            Console.Write("[  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  ] ");
            Console.Write("Loading Main Kernel...\n");
            Thread.Sleep(3000);
            Console.Write("[  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  ] ");
            Console.Write("Main Kernel Loaded\n");
            Thread.Sleep(1000);
            Console.Write("[  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  ] ");
            Console.Write("Loading Data...\n");
            Thread.Sleep(2000);
            Console.Write("[  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  ] ");
            Console.Write("Initializing 'CommandHandler.cs'...\n");
            Thread.Sleep(2000);
            Console.Write("[  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  ] ");
            Console.Write("Loading All MickemOS Files...\n");
            Thread.Sleep(2000);
            Console.Write("[  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  ] ");
            Console.Write("Starting file 'Main.cs'...\n");
            Thread.Sleep(1000);
            Console.Write("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("MickemOS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("!");
            Thread.Sleep(2000);
            MickemOS.Core.Main.AfterKernel();

        }

        protected override void Run()
        {
            
        }
    }
}

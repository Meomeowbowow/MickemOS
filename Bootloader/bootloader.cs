using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*
 * PROJECT: MICKEM OS BOOTLOADER
 * VERSION: 0.2
 * PROGRAMMER: MEOMEOWBOWOW
 * FILE: BOOTLOADER/BOOTLOADER.CS
 */

using System.IO;
using MickemOS.Core;
using Sys = Cosmos.System;

namespace MickemOS.Bootloader
{
    class bootloader
    {
        public static void StartBootProccess()
        {
            Console.Clear();
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
            Thread.Sleep(3000);
            Console.Write("[  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  ] ");
            Console.Write("Collecting Device Data...\n");
            Thread.Sleep(5000);
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
    }
}

/*
 * PROJECT: MICKEM OS MAIN FILE
 * VERSION: 0.6
 * PROGRAMMER: MEOMEOWBOWOW
 * FILE: MAIN.CS
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using MickemOS.Commands;


namespace MickemOS.Core
{
    public static class Main
    {
        public static void AfterKernel()
        {
            Console.Clear();
            Console.Write("Copyright 2012 - 2023 by MickemOS and Small Newt Games\n");
            Console.Write("MickemOS Command Line Interface\n");
            Console.Write("\n");
            Commands.CommandHandler.HandleCommands();
        }
    }
}

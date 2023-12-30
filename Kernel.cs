using System;
using System.Threading;
using System.IO;
using Sys = Cosmos.System;
using MickemOS.Core;
using MickemOS.Bootloader;

namespace MickemOS.Kernel
{
    public class Kernel : Sys.Kernel
    {
        public static string kernel_ver = "1.8";
        public static string os_build = "1608";

        protected override void BeforeRun()
        {
            Console.Write("Starting MickemOS Bootloader");
            Thread.Sleep(1000);
            MickemOS.Bootloader.bootloader.StartBootProccess();


        }

        protected override void Run()
        {
            //NOT USING THIS FUNCTION - USING MAIN.CS FILE
        }
    }
}

/*
 * PROJECT: MICKEM OS FILESYSTEM MANAGER
 * VERSION: 0.1
 * PROGRAMMER: MEOMEOWBOWOW
 * FILE: /CORE/FILESYSTEM/MANAGER.CS
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.FileSystem;

namespace MickemOS.Core.FileSystem.FSManager
{
    class Manager
    {
        public static CosmosVFS vfs = new CosmosVFS();
        public static string fs_type;
        public static long freespace;


        public static void RegisterVFS()
        {
            Cosmos.System.FileSystem.VFS.VFSManager.RegisterVFS(vfs);
        }

        public static void CreateFile(string path)
        {
            try
            {
                vfs.CreateFile(@"1:\testing.txt");
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
                
        }

        public static void GetFreeSpace(string path)
        {
            freespace = vfs.GetAvailableFreeSpace(path);
        }

        public static void GetFSType(string path)
        {
            fs_type = vfs.GetFileSystemType(path);
        }

        public static void WriteToFile(string path, string content)
        {
            try
            {
                File.WriteAllText(path, content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void ListFiles(string path)
        {
            var directory_list = Directory.GetFiles(path);

            try
            {
                foreach (var file in directory_list)
                {
                    var content = File.ReadAllText(file);

                    Console.WriteLine("File name: " + file);
                    Console.WriteLine("File size: " + content.Length);
                    Console.WriteLine("Content: " + content);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AsyncHello
{
   public static class AsyncReadFile
    {
        public static async Task<string> ReadHello(string path)
        {
            using Task<string> task = File.ReadAllTextAsync(path);
            await task;
            return task.Result;
        }

        public static async Task<string> ReadWorld(string path)
        {
            using Task<string> task = File.ReadAllTextAsync(path);
            await task;
            return task.Result;
        }

        public static async Task<string> Concat(string path1, string path2)
        {
            var str1 = await ReadHello(path1);
            var str2 = await ReadWorld(path2);
            return str1 + " " + str2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DumpPicker
{
    public class DumpFiles
    {
        /// <summary>
        /// 获取当前指定目录下的文件列表
        /// </summary>
        /// <returns></returns>
        public static Queue<string> GetFiles(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] files = d.GetFiles("*.txt");
            Queue<string> listFiles = new Queue<string>(files.Length);
            foreach(FileInfo info in files)
            {
                listFiles.Enqueue(info.Name);
            }
            return listFiles;
            
        }

        /// <summary>
        /// 获取当前路径
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentPath()
        {
            return System.Environment.CurrentDirectory;
        }

        /// <summary>
        /// 读取文件所有列表
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ReadFileContent(string path)
        {
            string content = File.ReadAllText(path, Encoding.UTF8);
            return content.Replace("\n", "\r\n");
        }
    }
}

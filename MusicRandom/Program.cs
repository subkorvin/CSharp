using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MusicRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            String sourceDir = "f:\\MP3\\MP3 Наше";
            String targetDir = "d:\\Temp\\2";
            String[] targetlist = Directory.GetFiles(targetDir, "*");
            if (targetlist != null)
            {
                foreach(string f in targetlist)
                {
                    File.Delete(f);
                }
            }
            double targetSize = 30 * 1024 * 1024;
            Random rnd = new Random();
            






            DirectoryInfo di = new DirectoryInfo(sourceDir);
            var list = di.GetFiles("*.mp3", SearchOption.AllDirectories);
            List<long> filesize = new List<long>();
            foreach (FileInfo f in list)
            {
                filesize.Add(f.Length);
            }
            long fileSize = 0;
            while(targetSize > fileSize)
            {
                var s = rnd.Next(filesize.Count);
                fileSize = list[s].Length + fileSize;
                try
                {
                    File.Copy(Path.Combine(sourceDir, list[s].FullName), Path.Combine(targetDir, list[s].Name));
                }
                catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message);
                }
                Console.WriteLine(list[s].Name);
            }
        }
    }
}

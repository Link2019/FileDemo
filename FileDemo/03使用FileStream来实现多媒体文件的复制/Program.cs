using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03使用FileStream来实现多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            //思路：是将要复制的多媒体文件读取出来，然后再写入到你指定的位置
            string source = @"C:\Users\Administrator.USER-20190915QG\Desktop\1\文件流的学习.avi";
            string target = @"C:\Users\Administrator.USER-20190915QG\Desktop\2\文件流的学习.avi";
            CopyFile(source, target);
            Console.WriteLine("复制成功！");
            Console.ReadKey();

        }
        /// <summary>
        /// 使用FileStream实现多媒体文件的复制
        /// </summary>
        /// <param name="source">文件的来源</param>
        /// <param name="target">你指定复制的位置</param>
        private static void CopyFile(string source, string target)
        {
            //1、创建一个负责读取的流
            using (FileStream fsRead=new FileStream(source,FileMode.OpenOrCreate,FileAccess.Read))
            {
                //2、创建一个负责写入的流
                using (FileStream fsWrite=new FileStream(target,FileMode.OpenOrCreate,FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //因为文件可能会比较大，所以我们在读取的时候，通过循环去读取
                    while(true)
                    {
                        //返回本次实际读取到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        if(r==0)
                        {
                            break;//读完退出
                        }
                        fsWrite.Write(buffer, 0, r);
                    }

                }
            }
        }
    }
}

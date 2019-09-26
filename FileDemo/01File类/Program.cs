using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //File类
            #region File文件的读取，是将字节数组转字符串

            //File.ReadAllBytes(string path) 读取文本文件到字节数组中，返回byte[]
            //byte[] buffer = File.ReadAllBytes(@"抽象类特点.txt");//相对路径
            //byte[] buffer = File.ReadAllBytes(@"C:\Users\Administrator.USER-20190905BJ\Desktop\抽象类特点.txt");
            ////将字节数组中的每一个元素都按照我们制定的编码格式解码成字符串
            //string str = Encoding.Default.GetString(buffer);
            //Console.WriteLine(str);
            //Console.ReadKey();

            ////File.ReadAllLines(string path) 读取文本文件到字符串数组中，返回string[]
            //string[] contents = File.ReadAllLines(@"C:\Users\Administrator.USER-20190905BJ\Desktop\抽象类特点.txt",Encoding.Default);
            //foreach (string item in contents)
            //{
            //    Console.WriteLine(item);
            //}
            ///*
            //for (int i = 0; i < contents.Length; i++)
            //{
            //    Console.WriteLine(contents[i]);
            //}
            //*/
            //Console.ReadKey();

            ////File.ReadAllText(string path) 读取文本文件到字符串中，返回str
            //string str = File.ReadAllText(@"C:\Users\Administrator.USER-20190905BJ\Desktop\抽象类特点.txt", Encoding.Default);
            //Console.WriteLine(str);
            //Console.ReadKey();

            #endregion

            #region File文件的写入，是将字符串转字节数组

            ////File.WriteAllBytes(string path, new byte[])，将byte[] 全部写入到文件
            //string str = "Hello World！！！";
            //byte[] buffer = Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\Administrator.USER-20190905BJ\Desktop\Hello.txt", buffer);
            //Console.WriteLine("写入成功！");
            //Console.ReadKey();

            ////File.WriteAllLines(string path, string[] contents)， 将字符串数组逐行保存到文件path中，会覆盖旧内容。
            //string[] contents = { "Hello！", "Hello!!", "Hello!!!" };
            //File.WriteAllLines(@"C:\Users\Administrator.USER-20190905BJ\Desktop\Hello.txt", contents);
            //Console.WriteLine("写入成功！");
            //Console.ReadKey();

            ////File.WriteAllText(string path, string contents) ，将文本contents保存到文件path中，会覆盖旧内容。
            string str = "你好，世界！";
            File.WriteAllText(@"C:\Users\Administrator.USER-20190905BJ\Desktop\Hello.txt", str);
            Console.WriteLine("写入成功！");
            Console.ReadKey();



            #endregion




        }

    }
}

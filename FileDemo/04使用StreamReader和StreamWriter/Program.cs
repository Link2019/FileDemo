using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04使用StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用StreamReader来读取一个文本文件
            using (StreamReader sr = new StreamReader(@"C:\Users\Administrator.USER-20190915QG\Desktop\抽象类特点.txt", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            Console.ReadKey();


            //使用StreamWriter来写入一个文本文件
            using (StreamWriter sw=new StreamWriter(@"C:\Users\Administrator.USER-20190915QG\Desktop\new3.txt",true))
            {
                sw.Write("今天天气好晴朗！");
            }
            Console.WriteLine("写入成功！");
            Console.ReadKey();
        }
    }
}

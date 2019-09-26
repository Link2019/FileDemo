using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FileStream类
{
    class Program
    {
        static void Main(string[] args)
        {
            //File类和FileStream类
            #region 对比读取数据
            //使用File来读取数据
            //byte[] buffer = File.ReadAllBytes(@"C:\Users\Administrator.USER-20190915QG\Desktop\抽象类特点.txt");
            //string str = Encoding.Default.GetString(buffer);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //使用FileStream来读取数据
            //FileStream fsRead = new FileStream(@"C:\Users\Administrator.USER-20190915QG\Desktop\抽象类特点.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            ////返回本次实际读取到的有效字节数
            //int r = fsRead.Read(buffer, 0, buffer.Length);
            ////将字节数组转换成字符串
            //string str = Encoding.Default.GetString(buffer, 0, r);
            ////关闭流
            //fsRead.Close();
            ////释放流资源
            //fsRead.Dispose();
            //Console.WriteLine(str);
            //Console.ReadKey();

            #endregion

            #region 对比写入数据
            //使用File类来写入数据
            //string str = "今天天气不错！";
            //byte[] buffer = Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\Administrator.USER-20190915QG\Desktop\new.txt", buffer);
            //Console.WriteLine("写入成功！");
            //Console.ReadKey();



            //使用FileStream类来写入数据
            //FileStream fsWrite = new FileStream(@"C:\Users\Administrator.USER-20190915QG\Desktop\new2.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //string str = "今天心情很好！";
            //byte[] buffer = Encoding.Default.GetBytes(str);
            //fsWrite.Write(buffer, 0, buffer.Length);
            //fsWrite.Close();
            //fsWrite.Dispose();
            //Console.WriteLine("写入成功！");
            //Console.ReadKey();

            #endregion

            #region 写在using当中
            //FileStream读取
            //using (FileStream fsRead = new FileStream(@"C:\Users\Administrator.USER-20190915QG\Desktop\抽象类特点.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] buffer = new byte[1024 * 1024 * 5];
            //    int r = fsRead.Read(buffer, 0, buffer.Length);
            //    string str = Encoding.Default.GetString(buffer, 0, r);
            //    Console.WriteLine(str);
            //}
            //Console.ReadKey();




            //FileStream写入
            using (FileStream fsWrite=new FileStream(@"C:\Users\Administrator.USER-20190915QG\Desktop\new2.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                string str = "今天心情很好！";
                byte[] buffer = Encoding.Default.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
                Console.WriteLine("写入成功");
            }
            Console.ReadKey();


            #endregion


        }
    }
}

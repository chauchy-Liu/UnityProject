using System;
using System.Diagnostics;
/*
    C#与C++几个明显区别
*/
// See https://aka.ms/new-console-template for more information

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            Object a;
            int b = 3;
            Console.WriteLine("Hello, World!");
            //数组     
            //int arr[10]; //c++方式定义数组
            int[] pArr; //c#方式定义数组
            //pArr[0] = 1; 报错，必须用new初始化数组才能使用
            pArr = new int[10];
            for (int i=0; i<pArr.Length; i++){
                pArr[i] = i*10;
                // Console.WriteLine(pArr[i]);
                Console.Write(pArr[i]+" ");
            }
            Console.WriteLine();
            int a1 = 10;
            int[,] pArr2 = new int[a1,10];//c#定义了10x10二维数组
            for (int i=0; i<10; i++){
                for (int j=0; j<10; j++){
                    pArr2[i,j] = i*j;
                    Console.Write(pArr2[i,j]+" ");
                    // Console.WriteLine(pArr2[i,j]);
                }
                Console.Write("\n");
            }
            //string(特殊引用类型)
            string str;
            str = "你好帅！";
            Console.WriteLine(str);
            string str2 = "赵云，马超，张飞，黄忠，关羽";
            string[] strArr = str2.Split("，");
            for (int i=0; i<strArr.Length; i++){
                Console.WriteLine(strArr[i]);
            }
            //C#控制台的输入与输出
            Console.WriteLine("WriteLine 行输出，带换行");
            Console.Write("Write 不换行输出\n");
            Console.WriteLine("占位符输出：0:{0} 1:{1} 交换 0:{1} 1:{0}", 250, 360);
            Console.WriteLine("请输入一个字符");
            int c = Console.Read();//读取一个字符
            Console.WriteLine("读取的字符为：{0}", c);
            Console.ReadLine();//消除缓冲区中的回车
            Console.WriteLine("请输入一个按键");
            var key = Console.ReadKey();//读取一个按键
            Console.WriteLine();
            Console.WriteLine("读取按键为：{0}", key.KeyChar);
            Console.WriteLine("请输入一个字符串");
            string s = Console.ReadLine();//读取一行
            Console.WriteLine("读取一行字符串为：{0}", s);
            
        }
    }
}


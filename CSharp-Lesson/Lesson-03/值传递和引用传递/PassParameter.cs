using System;

// static void fun()
// {
//     Console.WriteLine("Hello, World!");
// }
// int a = 10;
namespace Lesson03.值传递和引用传递
{
    class Student{
        public int score;//分数
    }
    class PassParameter
    {
        public static void Swap(int a, int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        public static void Swap(Student s1){
            s1.score = 10086;
        }
        public static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            int x = 20, y = 30;
            Console.WriteLine("值类型传递交换前x={0}, y={1}", x, y);
            Swap(x, y);
            Console.WriteLine("值值类型传递交换后x={0}, y={1}", x, y);

            Student s = new Student();
            s.score = 20000;
            Console.WriteLine("引用类型传递交换前Student s.score={0}", s.score);
            Swap(s);
            Console.WriteLine("引用类型传递交换后Student s.score={0}", s.score);

            Console.WriteLine("值类型ref传递交换前ref x={0}, ref y={1}", x, y);
            Swap(ref x, ref y); //ref 必须初始化实参
            Console.WriteLine("值类型ref传递交换后ref x={0}, ref y={1}", x, y);
        }
    }
}
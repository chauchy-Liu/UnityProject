using System;

namespace Lesson04.接口
{
    class Interface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("接口的使用");
            //接口的使用
            ICooker cooker = new Student();
            IPerson person = new Student();
            cooker.Cooking();
            person.Eat();
            person.Work();
            person.Sleep();
            cooker = new Teacher();
            person = new Teacher();
            cooker.Cooking();
            person.Eat();
            person.Work();
            person.Sleep();
        }
    }
}
using System;

namespace Lesson04.接口
{
    class Student: ICooker, IPerson
    {
        public void Cooking()
        {
            Console.WriteLine("学生在做饭");
        }
        void IPerson.Eat()
        {
            Console.WriteLine("学生在吃饭");
        }
        public void Work()
        {
            Console.WriteLine("学生在学习");
        }
        public void Sleep()
        {
            Console.WriteLine("学生在睡觉");
        }
    }

    class Teacher: ICooker, IPerson
    {
        public void Cooking()
        {
            Console.WriteLine("老师在做饭");
        }
        public void Eat()
        {
            Console.WriteLine("老师在吃饭");
        }
        public void Work()
        {
            Console.WriteLine("老师在工作");
        }
        public void Sleep()
        {
            Console.WriteLine("老师在睡觉");
        }
    }
}
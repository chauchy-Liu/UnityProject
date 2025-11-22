using System;

namespace Lesson04.属性和字段
{
    class Student
    {
        public class Book //Book是Student的成员类（内置类），可以访问Student的私有成员, 这里使用的访问修饰是public, 因为外部类可以访问成员类
        {
            static void Fun()
            {
                Student s = new Student("李四");
                s.name = "王五"; //成员类可以访问外部类的私有成员
            }
        }
        private int money;
        private string name;
        public int Money
        {
            set
            {
                if (value < 0)
                {
                    money = 0;
                }
                else
                {
                    money = value;
                }
            }
            get
            {
                return money;
            }

        }

        public Student(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
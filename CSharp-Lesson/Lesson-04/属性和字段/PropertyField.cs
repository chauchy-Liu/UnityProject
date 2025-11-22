using System;

namespace Lesson04.属性和字段
{
    class PropertyField
    {
        static void Fun(ref int x)
        {
            x = 250;
        }
        static void Main(string[] args)
        {
            Hero h = new Hero();
            h.Money = 1000;
            Console.WriteLine("c#风格 h.Money: " + h.Money);
            Console.WriteLine("c++风格 h.GetMoney(): " + h.GetMoney());

            h.Hp = 100;
            Console.WriteLine("h.Hp: " + h.Hp);

            //测试属性是否可以引用传递
            // Fun(ref h.Hp);//属性不能作为out或ref参数进行引用传递。
            h.hp = 10;
            Fun(ref h.hp); 
            Console.WriteLine("字段可以引用传递： h.hp = {0}", h.hp);

            //只读， 属性
            Console.WriteLine("只读型属性h.Atk "+h.Atk); //public int Atk { get; }
            // h.Atk = 240;

            Student s = new Student("张三");
            s.Money = 500;
            Console.WriteLine("学生姓名：{0}， 金钱：{1}", s.Name, s.Money);

            //内置类
            Student.Book b = new Student.Book();//内置类使用，C++风格为Student::Book b = new Student::Book();
        }
    }
}
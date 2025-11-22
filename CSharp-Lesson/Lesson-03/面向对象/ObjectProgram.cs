using System;
using Lesson03.类型转换; // 引用类型转换的命名空间，自动引用的命名空间

namespace Lesson03.面向对象
{
    class ObjectProgram
    {
        static void Main(string[] args)
        {
            // Hero hero = new Hero("未命名");
            Lesson03.类型转换.Hero hero = new Lesson03.类型转换.Hero("未命名");
            Anni anni = new Anni();
            Console.WriteLine(anni.name);
            anni.Atk();
            //多态
            hero = new Anni();
            hero.Say(); //调用Anni重写的Say方法
            hero = new Jax();
            hero.Say(); //调用Jax重写的Say方法
            //覆盖
            Jax jax = new Jax();
            Console.WriteLine("hero类名：" + hero.CLASSNAME);
            Console.WriteLine("jax类名：" + jax.CLASSNAME);
        }
    }
}
using System;

namespace Lesson03.类型转换
{
    class Hero
    {
        public string name;
        public Hero()
        {
            
        }
        public Hero(string name)
        {
            this.name = name;
        }
        public static void Speak()
        {
            // Console.WriteLine("Hero Speak: 我乃" + name);//静态成员（static）无法访问非静态成员
            // this.name = "Hero"; //静态成员函数没有this引用
        }
        public void Atk()
        {
            Console.WriteLine(name + " 发起了攻击！");//name是类的成员变量，也可用this.name
        }
        public virtual void Say()
        {
            //虚函数 可由派生类重写。
        }
        public string CLASSNAME = "Hero";
    }
    class Anni: Hero //派生类
    {
        public Anni(): base("Anni")
        {
            
        }
        public void Atk()
        {
            base.Atk();//使用base调用基类的成员
            Console.WriteLine("Anni 发起了攻击：熊之咆哮。。。。。");
        }
        // public new void Say() //new关键字隐藏基类的同名方法
        // {
        //     Console.WriteLine("Anni Say new: 我是" + this.name);
        // }
        public override void Say() //override 重写基类的虚方法
        {
            Console.WriteLine("Anni Say Override: 熊霸天下");
        }
    }
    class Jax: Hero
    {
        public Jax(): base("Jax")
        {
            
        }
        // public override void Say() //override 重写基类的虚方法
        // {
        //     Console.WriteLine("Jax Say Override: 没想到吧，我又回来了！");
        // }
        public new void Say() //new关键字隐藏基类的同名方法
        {
            Console.WriteLine("Jax Say new: 没想到吧，我又回来了！");
        }
        public new string CLASSNAME = "Jax";
    }
    
}
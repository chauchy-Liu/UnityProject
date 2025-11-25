using System;
using System.Net;

namespace Lesson05.泛型编程 {
    class GenericProgramming {
        static void Swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Swap2<T>(ref T a, ref T b) where T: struct{
            T temp = a;
            a = b;
            b = temp;
        }
        static void Swap3<T>(ref T a, ref T b) where T: class {
            T temp = a;
            a = b;
            b = temp;
        }
        //T  必须有无参数的构造函数否则报错
        static void Funtest<T>() where T:new() {
            T obj = new T();
        }
        static void Funtest2<T>(T obj) where T: IPerson {
            obj.Eat();
        }
        static T GetMax<T>(T a, T b) where T : IComparable {
            return a.CompareTo(b) > 0 ? a : b;
        }
        static void Main() {
            //泛型函数
            int a=25, b=36;
            float a1=2.5f, b1=3.6f;
            Console.WriteLine($"a={a}, b={b}");
            Console.WriteLine($"a={a1}, b={b1}");
            Swap<int>(ref a, ref b);
            Swap<float>(ref a1, ref b1);
            Console.WriteLine($"a={a}, b={b}");
            Console.WriteLine($"a={a1}, b={b1}");


            //泛型kkk
            CList<int> list = new CList<int>(10);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.ShowAll();
            CList<string> strList = new CList<string>(10);
            strList.Add("古力娜扎");
            strList.Add("迪丽热巴");
            strList.Add("热依扎");
            strList.ShowAll();

            //泛型约束
            //值类型约束
            Swap2<int>(ref a, ref b);
            Hero h1 = new Hero();
            h1.name = "盖伦";
            Hero h2 = new Hero();
            h2.name = "提莫";
            Student s = new Student("张三");
            // Swap2<Hero>(ref h1, ref h2);//报错：使用了引用类型  值类型的约束
            //无约束
            Swap<Hero>(ref h1, ref h2);
            Console.WriteLine($"h1={h1.name}, h2={h2.name}");
            //引用约束
            Swap3<Hero>(ref h1, ref h2);
            Console.WriteLine($"h1={h1.name}, h2={h2.name}");
            // Swap3<int>(ref a, ref b);//报错：使用了值类型  引用类型的约束
            //泛型必须是无参构造类型
            Funtest<Hero>();
            // Funtest<Student>();// Funtest<int>();//报错：int没有无参构造函数
            //泛型继承指定接口或类
            Funtest2<Hero>(h1);
            // Funtest2<Student>(s);//报错 Student没有实现IPerson接口

            //比较大小
            int maxInt = GetMax<int>(a, b);
            Console.WriteLine($"maxInt={maxInt}");
            Console.WriteLine("GetMax<Student>: {0}", GetMax(new Student("张三"), new Student("李四")).mName);
        }
    }
   
}
using System;

namespace Lesson03.类型转换
{
    class TypeConversion
    {
        enum MapType {
          Road,
          Wall,
          Grass
        }
        static void Main(string[] args)
        {
            int x = 25;
            //装箱
            Object obj = (Object)x;
            //拆箱
            int y = (int)obj;
            Console.WriteLine("y = {0}", y);
            // 精度转换
            float f = 3.14f;
            int n = 0;
            n = (int) f;
            f = n;

            double df = 0.0;
            f = (float)df;
            df = f;
          
            n = (int)MapType.Grass;
            Console.WriteLine("枚举强制转换为int n={0}", n);
            Console.WriteLine("int强制转换为枚举类型 MapType={0}", (MapType)n);

            //引用类型转换
            Anni anni = new Anni();
            //子转父 --自动转换
            Hero h = anni;
            if (h is Anni)
            {
                Console.WriteLine("父对象引用子对象，h是Anni类型对象");
            }
            //父转子 --强制转换
            h = new Hero();
            // anni = (Anni)h;//不安全转换，运行时可能报错， anni是个空值，假设h指向的内存不是Anni类型则转换不成功，报异常
            //is关键字
            if (h is Hero)
            {
                Console.WriteLine("h是Hero类型对象");
            }
            if (h is Anni)
            {
                Console.WriteLine("h是Anni类型对象");
            }
            else
            {
                Console.WriteLine("h不是Anni类型对象");
                Anni anni3 = h as Anni;
                Console.WriteLine("使用as关键字转换，anni3={0}", anni3);//anni3=null
                h = new Anni();
            }
            anni = (Anni)h;
            if (anni is Anni)
            {
                Console.WriteLine("父对象（引用子对象）强转子对象，anni是Anni类型对象");
            }
            //as关键字
            anni = h as Anni;
            if (anni is Anni)
            {
                Console.WriteLine("父对象（引用子对象）as转为子对象，anni是Anni类型对象");
            }

            //字符串与数字转换
            string s = "10086";
            // int num = (int)s;//强转
            int num = int.Parse(s);//字符串转数字
            Console.WriteLine("字符串转数字 num={0}", num);
            //数字转字符串
            num = 250;
            s = num.ToString();//方法一：ToString继承于Object类
            s = num + "";//方法二：数字与字符串相加,做字符串拼接，自动转换为字符串
            Console.WriteLine("数字转字符串 s={0}", s);
        }
    }
}
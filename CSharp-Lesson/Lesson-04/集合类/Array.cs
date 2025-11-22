using System;

namespace Lesson04.集合类
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];//定义一个长度为10的整型数组 arr是数组地址
            arr[0] = 250;
            arr[1] = 360;
            Console.WriteLine(arr[0]);
            int[] arr2 = {1,2,3,4,5,6,7,8,9};//定义并初始化数组 长度由初始化个数决定。
            for (int i=0; i<arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            int[,] arr3 = new int[3,3];//定义一个3x3的二维数组
            arr3[0,0] = 1;
            arr3[0,1] = 2;
            Console.WriteLine("二维数组【3，3】数据长度：{0}", arr3.Length);
            int[,] arr4 = {{1,3,4},{3,4,5},{9,10,8}};
            foreach (var item in arr4)//序列for循环
            {
                Console.WriteLine(item);
            }
            //打印地图
            GameMap map = new GameMap(10, 15);
            map.Init();
            map.PrintMap();
        }
    }
}
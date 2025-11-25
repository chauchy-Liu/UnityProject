using System;

namespace Lesson05.泛型编程 {
    /// <summary>
    /// 设计一个容器类型 可以保存多个数据
    /// 思想：使用泛型编程 将存储的数据类型提取出来 让一个容器存储逻辑 不关注数据类型只关注数据的存储逻辑 数据类型参数化 让类适应多种不同的数据类型存储
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class CList<T> {
        T[] arr;
        int size;//存储数据的个数
        int maxSize;//最大的容量
        public CList(int _maxSize) {
            maxSize = _maxSize;
            arr = new T[maxSize];
            size = 0;
        }
        public void Add(T _data) {
            if (size >= maxSize) {
                Console.WriteLine("容量已满，无法添加数据");
                return;
            }
            arr[size++] = _data;
        }
        public void ShowAll() {
            for (int i = 0; i < size; i++) {
                Console.Write("{0},",arr[i]);
            }
            Console.WriteLine();
        }
    }
}
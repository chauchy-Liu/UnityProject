using System;

namespace Lesson04.接口
{
    interface ICooker{
        // public string name; //接口是行为的提取，不能定义字段
        // public void Cooking(){}; //接口中只能定义方法，不能有方法体
        void Cooking(); //接口中只能定义方法，不能有方法体, 谁继承谁实现, 可以不写public默认是public, 而且只能是public修饰。
    }
}
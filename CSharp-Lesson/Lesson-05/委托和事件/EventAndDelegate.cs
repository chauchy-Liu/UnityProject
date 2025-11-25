using System;

namespace Lesson05.事件和委托 {
    delegate void Action();
    
    class EventAndDelegate {
        static Action buttonClicked;//普通委托对象
        static event Action btnOnEnter;//事件对象
        static void FunTest(){
            Console.WriteLine("FunTest is called ....!");
        }
        static void FunTest2(){
            Console.WriteLine("FunTest2 is called ....!");
        }
        static void FunTest3(){
            Console.WriteLine("FunTest3 is called ....!");
        }
        static void Move() {
            Console.WriteLine("移动物体");
        }
        static void Rotate() {
            Console.WriteLine("旋转物体");
        }
        static void Scale() {
            Console.WriteLine("放缩物体");
        }
        //点击一个按钮执行一系列函数，n个函数不确定
        static void OnButtonClicked() {
            Console.WriteLine("鼠标点击执行逻辑: ");
            buttonClicked();//调用委托对象
        }
        static void OnButtonEnter() {
            Console.WriteLine("鼠标悬浮执行逻辑: ");
            btnOnEnter();//调用事件对象
        }
        static void Main() {
            Action fun;
            fun = FunTest;
            fun();
            //批量调多个函数
            fun += FunTest;
            fun += FunTest2;
            fun += FunTest3;
            fun();
            //
            buttonClicked += Move;
            buttonClicked += Rotate;
            buttonClicked += Scale;
            //鼠标点击
            OnButtonClicked();
            //悬浮
            btnOnEnter += Move;
            btnOnEnter += Rotate;
            btnOnEnter += Scale;
            btnOnEnter = Scale;
            OnButtonEnter();
            //事件不支持=
            Boss.dead = Move;
            // Boss.deadEvent = Move;//报错：事件“Boss.deadEvent”只能出现在 += 或 -= 的左边(从类型“Boss”中使用时除外)

            //事件谁绑定谁触发
            Boss.dead += Rotate;
            Boss.deadEvent += Rotate;
            //触发即调用
            Boss.dead();
            // Boss.deadEvent();//只能在定义的源头类触发，报错：事件“Boss.deadEvent”只能出现在 += 或 -= 的左边(从类型“Boss”中使用时除外)CS0070
            Boss boss = new Boss();
            //在Boss类中触发
            boss.BossDeadDispatch();
        }
    }
}
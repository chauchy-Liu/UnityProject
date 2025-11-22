using System;

/* 
1. 怪物链设计
普通道具：基类普通怪, 派生类毒蛇和皮卡丘
根据属性划分到不同类中编辑
 */

namespace Lesson04.作业练习
{
    class Monster
    {
        public int atk;
        public int def;
        public string name;
        public virtual void Atk()
        {
            Console.WriteLine("Monster 怪物攻击： ");
        }
    }

    class Snake: Monster
    {
        public override void Atk()
        {
            // base.Atk();
            Console.WriteLine("Snake "+name+" 毒死你AXB");
        }
    }
    class Pika: Monster
    {
        public override void Atk()
        {
            // base.Atk();
            Console.WriteLine("Pika "+name+" 电死你");
        }
    }
}
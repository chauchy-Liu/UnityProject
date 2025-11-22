using System;

namespace Lesson04.属性和字段
{
    class Hero
    {
        private int money;//字段
        public int hp;

        #region C++访问成员属性做法
        public void SetMoney(int money) //c++设置属性
        {
            this.money = money;
        }
        public int GetMoney() //c++获取属性
        {
            return money;
        }
        #endregion

        //关联属性
        public int Money //称为属性  -------money字段的访问器
        {
            get //用于获取一个字段
            {
                return money;
            }
            set //用于设置字段
            {
                if (value < 0)//value为设置的实际值
                {
                    money = 0;
                }
                money = value;
            }
        }
    
        //自动属性
        public int Hp { get; set; } //可读可改
        public int Atk { get; }//只读
        // public int Def { set; }//只写
    }

}
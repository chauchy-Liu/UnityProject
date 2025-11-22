using System;

namespace Lesson04.作业练习
{
    class CEquipment: CItem
    {
        public int atk;
        public int def;
        
        public CEquipment(CEquipment equip): base(equip)
        {
            atk = equip.atk;
            def = equip.def;
        }
        public CEquipment()
        {

        }
        public override void Use()
        {
            // base.Use();
            Console.WriteLine("CEquipment 装备 "+name+" 使用了" + " +atk "+atk+" +def "+def);
        }
    }
}
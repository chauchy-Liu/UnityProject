using System;

namespace Lesson04.作业练习
{
    class Main1
    {
        static void Main(string[] args)
        {
            //装备练习
            CItem item = new CItem();
            item.name = "普通道具";
            item.Use();
            CItem drug = new CDrugs();
            // drug.name = "药瓶";
            CDrugs d = drug as CDrugs;
            d.name = "小药瓶";
            d.hp = 100;
            d.mp = 0;
            drug.Use();

            CItem equip = new CEquipment();
            equip.name = "大宝剑";
            // CEquipment e = equip as CEquipment;
            // e.name = "青钢剑";
            // e.atk
            ((CEquipment)equip).atk = 26;
            ((CEquipment)equip).def = 5;
            equip.Use();

            //妖怪练习
            Monster mon = new Monster();
            mon.name = "普通妖怪";
            mon.atk = 2;
            mon.def = 1;
            mon.Atk();

            Monster snake = new Snake();
            snake.name = "阿伯怪";
            snake.atk = 30;
            snake.def = 10;
            snake.Atk();

            Monster pika = new Pika();
            pika.name = "皮卡丘";
            pika.atk = 40;
            pika.def = 23;
            pika.Atk();

        }
    }
}
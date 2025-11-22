using System;

namespace Lesson04.作业练习
{
    class CDrugs: CItem
    {
        public int hp;
        public int mp;

        public CDrugs(CDrugs drugs): base(drugs)
        {
            hp = drugs.hp;
            mp = drugs.mp;
        }
        public CDrugs()
        {

        }
        public override void Use()
        {
            // base.Use();
            Console.WriteLine("CDrugs 药品 "+name+" 使用了" + " +mp "+mp+" +hp "+hp);
        }
    }
}
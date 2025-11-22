using System;

/* 
1. 道具链设计
普通道具：基类CItem, 派生类CDrug和CEquipment
道具属性： atk def count  id  name descript mp  hp price isOverlay
根据属性划分到不同类中编辑
道具共有函数： 道具拷贝函数 道具使用函数（多态）
 */
 
namespace Lesson04.作业练习
{
    class CItem
    {
        public int id;
        public int count;
        public string name;
        public string descript;
        public int price;
        public bool isOverlay;

        public CItem Clone(CItem item)
        {
            return null;
        }
        public CItem(CItem item)
        {
            id = item.id;
            name = item.name;
            count = item.count;
            isOverlay = item.isOverlay;
            descript = item.descript;
            price = item.price;
        }
        public CItem()
        {

        }
        public virtual void Use()
        {
            Console.WriteLine("CItem 道具 "+name+" 使用");
        }
    }
}
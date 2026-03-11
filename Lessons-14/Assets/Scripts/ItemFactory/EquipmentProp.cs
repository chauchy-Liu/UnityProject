/*
    *Author: #Name#
    *CreateTime: #CreateTime#
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;

public class EquipmentProp : ItemProp
{
    public int hp {get; set;} //增加血量
    public int mp {get; set;} //增加蓝量
    public int atk {get; set;} //增加攻击力
    public int def {get; set;} //增加防御力
    //默认构造+拷贝构造+重写基类Clone虚函数
    public EquipmentProp() : base()
    {
        this.hp = 0;
        this.mp = 0;
        this.atk = 0;
        this.def = 0;
        this.type = ItemType.IT_Equipment;
    }
    public EquipmentProp(EquipmentProp equipment): base(equipment)
    {
        this.hp = equipment.hp;
        this.mp = equipment.mp;
        this.atk = equipment.atk;
        this.def = equipment.def;
        // this.type = ItemType.IT_Equipment; 基类已经做过这个赋值了
    }
    public override ItemProp Clone()
    {
        EquipmentProp equipment = new EquipmentProp(this);
        Debug.Log("克隆装备: "+equipment.name);
        return equipment;
    }
}
    

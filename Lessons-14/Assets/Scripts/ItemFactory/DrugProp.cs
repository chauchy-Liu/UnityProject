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

public class DrugProp : ItemProp
{
    public int hp {get; set;} //回血量
    public int mp {get; set;} //回蓝量
    //默认构造+拷贝构造+重写基类Clone虚函数
    public DrugProp() : base()//调基类无参构造
    {
        this.hp = 0;
        this.mp = 0;
        this.type = ItemType.IT_Drug;
    }
    public DrugProp(DrugProp drug): base(drug)
    {
        this.hp = drug.hp;
        this.mp = drug.mp;
        // this.type = ItemType.IT_Drug; 基类已经做过这个赋值了
    }
    public override ItemProp Clone()
    {
        DrugProp drug = new DrugProp(this);
        Debug.Log("克隆药品: "+drug.name);
        return drug;
    }
}

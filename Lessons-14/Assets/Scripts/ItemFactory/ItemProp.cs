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

//物品ID
/* public enum ItemID//ID不适合做枚举
{
    IT_None = 0,
    ID_HP = 10,
    ID_MP = 11,
    ID_IronySword = 21, //剑
    ID_IronyBow = 31, //弓
    ID_IronyAxe = 41, //斧
    ID_IronyJacket = 51, //胸甲
    ID_IronyHelmet = 61, //头盔
}; */

public enum ItemType
{
    IT_None,
    IT_Normal = 1, //普通物品
    IT_Drug = 2, //药品
    IT_Equipment = 3, //装备
    IT_Material = 4, //材料
}


public class ItemProp
{
    //属性：不能引用
    public int id {get; set;} //物品ID
    public string name {get; set;} //物品名称
    public ItemType type {get; set;} //物品类型
    public string desc {get; set;} //物品描述
    public string iconPath {get; set;} //图标路径
    public int buyPrice {get; set;} //购买价格
    public int sellPrice {get; set;} //出售价格
    public int maxNum {get; set;} //最大堆叠数量, 物品栏道具数量
    public int curNum = 0; //当前数量
    //默认构造
    public ItemProp()
    {
        this.id = 0;
        this.name = "";
        this.type = ItemType.IT_None;
        this.desc = "";
        this.iconPath = "";
        this.buyPrice = 0;
        this.sellPrice = 0;
        this.maxNum = 0;
    }
    //拷贝构造 为了在工厂中使用, 防止引用对象被修改
    public ItemProp(ItemProp itemProp)
    {
        if (itemProp != null)
        {
            this.id = itemProp.id;
            this.name = itemProp.name;
            this.type = itemProp.type;
            this.desc = itemProp.desc;
            this.iconPath = itemProp.iconPath;
            this.buyPrice = itemProp.buyPrice;
            this.sellPrice = itemProp.sellPrice;
            this.maxNum = itemProp.maxNum;
        }
    }
    //克隆该对象的一个新对象
    public virtual ItemProp Clone()//虚函数实现多态
    {
        ItemProp itemProp = new ItemProp(this);
        Debug.Log("克隆物品: "+itemProp.name);
        return itemProp;
    }
}

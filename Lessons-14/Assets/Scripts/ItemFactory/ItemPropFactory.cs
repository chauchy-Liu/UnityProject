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
using System.Xml;

//道具工厂单例
public class ItemPropFactory
{
    //道具库
    Dictionary<int, ItemProp> itemLib = new Dictionary<int, ItemProp>();
    //初始化，从XML加载道具数据
    public void LoadItems(string xmlUrl)
    {
        // 文档对象
        var doc = new System.Xml.XmlDocument();
        doc.Load(xmlUrl);
        // 根节点
        var root = doc.SelectSingleNode("root") as XmlElement;
        // 遍历子节点
        foreach (XmlElement itemNode in root.ChildNodes)
        {
            // 创建道具
            ItemProp item = null;
            ItemType type = (ItemType) int.Parse(itemNode.GetAttribute("type"));
            switch (type)
            {
                case ItemType.IT_Drug: //药品
                    DrugProp drug = new DrugProp();
                    drug.hp = int.Parse(itemNode.GetAttribute("hp"));
                    drug.mp = int.Parse(itemNode.GetAttribute("mp"));
                    item = drug;
                    break;
                case ItemType.IT_Equipment: //装备
                    EquipmentProp equipment = new EquipmentProp();
                    equipment.hp = int.Parse(itemNode.GetAttribute("hp"));
                    equipment.mp = int.Parse(itemNode.GetAttribute("mp"));
                    equipment.atk = int.Parse(itemNode.GetAttribute("atk"));
                    equipment.def = int.Parse(itemNode.GetAttribute("def"));
                    item = equipment;
                    break;
                case ItemType.IT_Normal: //普通物品
                    break;
                case ItemType.IT_Material: //材料
                    break;
                case ItemType.IT_None:
                    item = new ItemProp();
                    break;
                default:
                    item = new ItemProp();
                    break;
            }
            //读取通用属性
            item.buyPrice = int.Parse(itemNode.GetAttribute("buyPrice"));
            item.sellPrice = int.Parse(itemNode.GetAttribute("sellPrice"));
            item.desc = itemNode.GetAttribute("desc");
            item.iconPath = itemNode.GetAttribute("iconPath");
            item.id = int.Parse(itemNode.GetAttribute("id"));
            item.name = itemNode.GetAttribute("name");
            item.maxNum = int.Parse(itemNode.GetAttribute("maxNum"));
            item.type = type;
            item.curNum = 1;
            //加入道具库
            itemLib.Add(item.id, item);
        }
    }
    // 生成道具函数
    public ItemProp CreateItemById(int id)
    {
        if (itemLib.ContainsKey(id))
        {
            // 克隆副本
            return itemLib[id].Clone();
        }
        return null;
    }



    #region 单例
    ItemPropFactory()
    {
        //单例创建道具库
        LoadItems(Application.dataPath + "/Xml/ItemConfig.xml");
    }
    public static readonly ItemPropFactory Instance = new ItemPropFactory();
    #endregion
    
}

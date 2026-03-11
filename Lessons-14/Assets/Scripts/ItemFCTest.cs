/*
    *Author: #Name#
    *CreateTime: #CreateTime#
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFCTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            //按键测试工场创建道具
            var drug = ItemPropFactory.Instance.CreateItemById(10) as DrugProp;
            Debug.Log(" hp = " + drug.hp + " mp = " + drug.mp);
            var equip = ItemPropFactory.Instance.CreateItemById(21) as EquipmentProp;
            Debug.Log("atk = " + equip.atk + " def = " + equip.def + " hp = " + equip.hp + " mp = " + equip.mp);

        }
    }
}

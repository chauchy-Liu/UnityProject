/*
    *Author: 刘传玺
    *CreateTime: 2026-01-06 16:49:15
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemCreate : MonoBehaviour
{
    public Item[] items;//预置体
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in items)
        {
            item.transform.position = transform.position + Vector3.up*3 + Random.insideUnitSphere  * 2; //在一个球内随机给出装备位置 * Random.value
            //y坐标非负
            item.transform.position =  new Vector3(item.transform.position.x, Mathf.Abs(item.transform.position.y), item.transform.position.z);
            //实例化预置体
            GameObject.Instantiate<Item>(item);
        }
        //删除调用组件的游戏对象
        GameObject.Destroy(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

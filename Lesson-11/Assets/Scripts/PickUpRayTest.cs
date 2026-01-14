/*
    *Author: 刘传玺
    *CreateTime: 2026-01-06 22:31:29
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRayTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //创建射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //创建碰撞物信息
            RaycastHit hitInfo;
            //发射射线
            bool isHit = Physics.Raycast(ray, out hitInfo);
            if (isHit)
            {
                GameObject gameObject = hitInfo.collider.gameObject;
                Item itemComponent = gameObject.GetComponent<Item>();
                Debug.Log("拾取到"+itemComponent.item.name);
                GameObject.Destroy(gameObject);
            }
        }
        
    }
}

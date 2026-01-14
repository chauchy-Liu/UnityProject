/*
    *Author: 刘传玺
    *CreateTime: 2026-01-06 14:59:28
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRayCastTest : MonoBehaviour
{
    public float power;
    Vector3 drawPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("鼠标点击位置:"+Input.mousePosition);//2D屏幕坐标系
            //从主摄像机（源点）向屏幕坐标点创建一条射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//向屏幕点发射射线
            //创建射线碰撞目标信息对象
            RaycastHit hitInfo;
            //发射射线
            bool isHit = Physics.Raycast(ray, out hitInfo);
            if (isHit)
            {
                if (hitInfo.rigidbody)//刚体不为空
                {
                    //获取被击目标的刚体组件, 并给刚体添加一个射线方向的力
                    hitInfo.rigidbody.AddForce(ray.direction * power);
                }
                drawPos = hitInfo.point;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(Camera.main.transform.position, drawPos);
    }
}

/*
    *Author: 刘传玺
    *CreateTime: 2026-01-05 20:14:07
    *Title: 射线检测
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour
{
    public Transform firePos;
    bool isDraw = false;
    Vector3 hitPos;//碰撞点
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //创建射线
            Ray ray = new Ray(firePos.position, firePos.forward);
            //创建射线碰撞信息
            RaycastHit hitInfo;
            //物理类发射射线
            bool isHit = Physics.Raycast(ray, out hitInfo);
            //如果碰撞
            if (isHit)
            {
                Debug.Log("碰撞到了"+ hitInfo.transform.name);
                Debug.Log("距离目标"+ hitInfo.distance+"米");
                isDraw = true;
                hitPos = hitInfo.point;//碰撞点

                //击中部位变红
                hitInfo.transform.GetComponent<MeshRenderer>().material.color = Color.red;
            } else
            {
                isDraw = false;
                //恢复颜色
                var meshRD = hitInfo.transform.GetComponent<MeshRenderer>();
                if (meshRD)
                {
                    meshRD.material.color = Color.white;
                }
                
            }

        }
    }

    //射线辅助显示工具,OnDrawGizmos 会在程序启动之前就开始调用
    private void OnDrawGizmos()
    {
        Debug.Log("OnDrawGizmos is call...");
        if (isDraw)
        {
            Gizmos.DrawLine(firePos.position, hitPos);
        }
    }
}

/*
    *Author: #Name#
    *CreateTime: #CreateTime#
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 要跟随的目标人物
    public float smoothTime = 0.3f; // 平滑跟随的时间系数
    public Vector3 offset; // 摄像机相对于人物的偏移量（如：保持一定高度）

    private Vector3 velocity = Vector3.zero; // 平滑速度
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // 计算相机位置：人物位置 + 偏移量
        Vector3 cameraPosition = target.position + offset;
        
        // 使用平滑插值，让摄像机移动更自然
        transform.position = Vector3.SmoothDamp(transform.position, cameraPosition, ref velocity, smoothTime);
    }
}

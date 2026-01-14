using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    摄像机控制脚本:  摄像机跟随球平动
*/

public class CameraControl : MonoBehaviour
{
    public Transform target;
    //偏移量
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //初始时相机相对目标位置
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //通过目标新位置更新相机位置
        transform.position = target.position + offset;
    }
}

/*
    *Author: #Name#
    *CreateTime: #CreateTime#
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //已知一个欧拉角度(60,0,0) 需要赋给一个游戏物体
        //解决方法：通过Unity提供的四元数类的静态成员函数将一个欧拉角转换为四元数
        transform.rotation = Quaternion.Euler(new Vector3(60, 0, 0)); //出现问题无法将类型“UnityEngine.Vector3”隐式转换为“UnityEngine.Quaternion”
        //已知物体的旋转（四元数）希望通过欧拉角描述进行观察角度变化
        Debug.Log("四元数："+transform.rotation);
        //解决方案：任何一个四元数转成欧拉角度
        Debug.Log("欧拉角："+transform.rotation.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

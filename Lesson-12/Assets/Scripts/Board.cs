/*
    *Author: 刘传玺
    *CreateTime: 2026-01-19 10:53:04
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public float moveSpeed;
    public Vector2 boundary;//边界， x最小，y最大
    public Rigidbody ballRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") , 0, 0)* moveSpeed* Time.deltaTime);
        //限制移动范围
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, boundary.x, boundary.y),
            transform.position.y,
            transform.position.z
        );
        //按空格键 发射球
        // 刚体内部使用世界坐标
        Debug.Log("小球刚体的全局坐标：" + ballRigidbody.transform.position + ", 局部坐标：" + ballRigidbody.transform.localPosition);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ballRigidbody.isKinematic = false;
            ballRigidbody.velocity = new Vector3(5, 5, 0); //45度发射球
            // 防止板子控制球的运动 脱离父子关系
            ballRigidbody.transform.parent = null;
        }
    }
}

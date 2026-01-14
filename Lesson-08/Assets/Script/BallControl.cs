/*
    Title: Roll a ball 小球控制
    Description:
    使用刚体模拟小球滚动 通过键盘输入键控制小球滚动方向
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //获取刚体组件
        rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //获取水平方向、垂直方向的输入
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        //使用刚体模拟小球移动
        rigidbody.AddForce(new Vector3(hor,0,ver) * speed);
        
    }
    #region 检测碰撞器函数测试调用
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("进入碰撞："+collision.gameObject.name);
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("离开碰撞："+collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("持续碰撞："+collision.gameObject.name);
    }

    #endregion
    #region 检测触发器函数测试调用
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("进入触发："+collision.gameObject.name);
        switch (collision.gameObject.tag)
        {
            case "Coin":
                //销毁金币
                GameObject.Destroy(collision.gameObject);//删除游戏对象而不是collision组件，一个游戏对象可以有许多组件
                break;
            default:
                break;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        // Debug.Log("离开触发："+collision.gameObject.name);
    }
    private void OnTriggerStay(Collider collision)
    {
        // Debug.Log("持续触发："+collision.gameObject.name);
    }

    #endregion
}

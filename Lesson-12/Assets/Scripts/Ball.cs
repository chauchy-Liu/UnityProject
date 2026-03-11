/*
    *Author: 刘传玺
    *CreateTime: 2026-01-19 22:17:27
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject explosion;//爆炸特效预制体
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("小球碰到了：" + collision.gameObject.name);
        if (collision.transform.tag == "Block")
        {
            var exp = GameObject.Instantiate(explosion);
            exp.transform.position = collision.transform.position;//在方块的位置产生爆炸
            //删除方块
            GameObject.Destroy(collision.gameObject);
            //删除爆炸特效预置体生成的游戏对象
            GameObject.Destroy(exp, 1f);//2秒后删除爆炸特效
        }
    }
}

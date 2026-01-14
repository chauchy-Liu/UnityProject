/*
    *Author: 刘传玺
    *CreateTime: 2025-12-11 17:14:07
    *Title:  爆炸删除
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float deleteTime;
    // Start is called before the first frame update
    void Awake()
    {
        GameObject.Destroy(this.gameObject, deleteTime); //2秒后销毁爆炸特效
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

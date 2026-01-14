/*
    *Author: 刘传玺
    *CreateTime: 2025-12-11 15:08:50
    *Title: 陨石
    *Description:
        控制陨石的 旋转 移动
*/

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float moveSpeed;
    public float angularSpeed;
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Awake()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.back * moveSpeed;
        //模拟旋转
        rigidbody.angularVelocity = Random.insideUnitSphere * Random.Range(0.5f, 2f)*angularSpeed;//单位球内的向量*随机数,模拟旋转轴
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        //Some objects were not cleaned up when closing the scene
        if (gameObject.scene.isLoaded)//确保不是场景切换销毁的
        {
            GameObject.Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }
    }
}

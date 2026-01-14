/*
    *Author: 刘传玺
    *CreateTime: 2025-12-11 19:37:33
    *Title: 敌机类
    *Description:
        控制敌机 子弹发射 移动
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public GameObject explosionPrefab;//自己暴躁特效
    public GameObject bulletPrefab;//子弹预制体
    public Transform firePoint;//发射点
    public float fireFreq;//发射频率
    float fireTime;

    // Start is called before the first frame update
    void Awake()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.back * moveSpeed;
        // transform.forward
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - fireTime > fireFreq)
        {
            GameObject bullet = Instantiate(bulletPrefab); //, firePoint.position, Quaternion.identity 添加后game界面看不到敌方子弹
            bullet.transform.position = firePoint.position;
            fireTime = Time.time;
        }
    }
    private void OnDestroy()
    {
        if (gameObject.scene.isLoaded)//确保不是场景切换销毁的
        {
            GameObject.Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }
        
    }
}

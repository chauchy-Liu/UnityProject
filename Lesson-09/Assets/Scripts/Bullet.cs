/*
    *Author: #Name#
    *CreateTime: #CreateTime#
    *Title:
    *Description:
        子弹移动和碰撞检测
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSpace;
using Unity.VisualScripting;
using GameManageSpace;

public enum BulletType
{
    PlayerBullet,
    EnemyBullet
}
public class Bullet : MonoBehaviour
{
    Rigidbody rigidbody;
    public float speed;
    public BulletType type;
    //优化不要在子弹中添加暴炸预置体
    // public GameObject asteroidExplosionPrefab; //爆炸特效预制体
    // public GameObject enemy1ExplosionPrefab; //爆炸特效预制体
    // public GameObject enemy2ExplosionPrefab; //爆炸特效预制体

    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            switch (type)
            {
                case BulletType.EnemyBullet:
                    rigidbody.velocity = Vector3.back * speed; //子弹发射速度
                    break;
                case BulletType.PlayerBullet:
                    rigidbody.velocity = Vector3.forward * speed; //子弹发射速度
                    break;
                default:
                    break;
            }
            // rigidbody.velocity = Vector3.forward * speed; //子弹发射速度
        }
    }

    // Update is called once per frame
    void Update()
    {
        //用触发器实现了，不用下面的方法
        // Boundary boundary = GameObject.Find("Player").GetComponent<Player>().boundary;
        // if (transform.position.z > boundary.zMax)
        // {
        //     Destroy(gameObject); //超出边界销毁子弹
        // }
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject explosion;
        switch (type)
        {
            case BulletType.PlayerBullet:
                switch (other.tag)
                {
                    // case "Background":
                    //     return;
                    case "Asteroid":
                        // explosion = GameObject.Instantiate(asteroidExplosionPrefab, other.transform.position, Quaternion.identity); //实例化爆炸特效
                        GameObject.Destroy(other.gameObject); //销毁陨石
                        GameObject.Destroy(gameObject); //销毁子弹
                        // GameObject.Destroy(explosion, 2f); //2秒后销毁爆炸特效
                        GameManage.Instance.ScoreUpdate(10);
                        break;
                    case "Enemy1":
                        // explosion = GameObject.Instantiate(enemy1ExplosionPrefab, other.transform.position, Quaternion.identity); //实例化爆炸特效
                        GameObject.Destroy(other.gameObject); //销毁陨石
                        GameObject.Destroy(gameObject); //销毁子弹
                        // GameObject.Destroy(explosion, 2f); //2秒后销毁爆炸特效
                        GameManage.Instance.ScoreUpdate(40);
                        // GameManage.score += 40;
                        break;
                    case "Enemy2":
                        // explosion = GameObject.Instantiate(enemy2ExplosionPrefab, other.transform.position, Quaternion.identity); //实例化爆炸特效
                        GameObject.Destroy(other.gameObject); //销毁陨石
                        GameObject.Destroy(gameObject); //销毁子弹
                        // GameObject.Destroy(explosion, 2f); //2秒后销毁爆炸特效
                        GameManage.Instance.ScoreUpdate(60);
                        // GameManage.score += 60;
                        break;
                    default:
                        break;
                }
                break;
            case BulletType.EnemyBullet:
                
                break;
            default:
                break;
        }
        
        // GameObject.Destroy(other.gameObject); //销毁陨石
        // GameObject.Destroy(gameObject); //销毁子弹
    }
    private void OnDestroy()
    {
        if (type == BulletType.EnemyBullet)
        {
            print("子弹销毁");
        }
        }
        
}

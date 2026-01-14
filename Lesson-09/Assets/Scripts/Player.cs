/*
    Title: 玩家控制
    Description: 
        玩家控制移动
        玩家发射子弹
        玩家碰撞处理
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameManageSpace;

namespace PlayerSpace
{
    
    public class Player : MonoBehaviour
    {
        public float moveSpeed;//移动速度
        Rigidbody rigidbody;
        // Boundary boundary;//边界, 这样使用不管用不是Hierarchy中GameManage组件的boundary
        
        //子弹发射
        public GameObject bulletPrefab;//子弹预制体 
        public float fireFreq; //发射频率
        float fireTimer; //发射计时器
        // public Transform firePos; //发射位置
        

        // Start is called before the first frame update
        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            if (rigidbody != null)
            {
                //移动
                var hor = Input.GetAxis("Horizontal");
                var ver = Input.GetAxis("Vertical");
                Vector3 moveDir = new Vector3(hor, 0, ver);
                rigidbody.velocity = moveDir * moveSpeed;
            }
            //边界控制
            var posX = Mathf.Clamp(transform.position.x, GameManage.Instance.boundary.xMin, GameManage.Instance.boundary.xMax);
            var posZ = Mathf.Clamp(transform.position.z, GameManage.Instance.boundary.zMin, GameManage.Instance.boundary.zMax);
            var posY = transform.position.y;
            transform.position = new Vector3(posX, posY, posZ); //限制位置在边界内

            //发射子弹
            if (Time.time - fireTimer > fireFreq)
            {
                // if (Input.GetKey(KeyCode.Space))
                // {

                    //通过添加一个空物体设置子弹发射位置，调整子弹生成位置，避免与玩家重合
                    var firePos = GameObject.Find("fire_position");
                    var bullet = GameObject.Instantiate(bulletPrefab);
                    bullet.transform.position = firePos.transform.position;
                    fireTimer = Time.time;
                // }
            }

        }

        public GameObject explosionPrefab; //玩家飞机爆炸特效
        private void OnTriggerEnter(Collider other)
        {
            switch (other.tag)
            {
                case "Enemy1":
                    // break;
                case "Enemy2":
                    // break;
                case "Asteroid":
                    // break;
                case "EnemyBullet":
                    //创建爆炸对象
                    GameObject.Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                    //删除玩家
                    GameObject.Destroy(this.gameObject);
                    //删除碰撞物
                    GameObject.Destroy(other.gameObject);
                    //游戏结束界面
                    GameManage.Instance.GameOver();
                    break;
                default:
                    break;
            }

        }
    }
}


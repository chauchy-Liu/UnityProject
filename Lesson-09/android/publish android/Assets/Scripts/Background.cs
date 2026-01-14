using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Title: 背景滚动
/// Description: 通过材质属性偏移实现背景滚动效果
/// </summary>
public class Background : MonoBehaviour
{
    MeshRenderer meshRD;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        meshRD = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //更新偏移量
        meshRD.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
    }
    //触发器，子弹离开背景触发器的空间范围删除子弹
    private void OnTriggerExit(Collider collider)
    {
        switch (collider.tag)
        {
            case "Bullet":
                GameObject.Destroy(collider.gameObject);
                break;
            case "EnemyBullet":
                GameObject.Destroy(collider.gameObject);
                break;
            case "Asteroid":
                GameObject.Destroy(collider.gameObject, 2);
                break;
            case "Enemy1":
                GameObject.Destroy(collider.gameObject, 2);
                break;
            case "Enemy2":
                GameObject.Destroy(collider.gameObject, 2);
                break;
            default:
                return;
        }
        
    }
}

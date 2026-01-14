/*
	Title:
	玩家控制
	
	Description:
		控制玩家移动
		玩家子弹发射
		玩家碰撞处理
	
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]//编辑器扩展命令 指定类型 可在编辑器中可视化编辑  （序列化类型）
public struct Boundary//边界类型
{
	public float xMin;
	public float xMax;
	public float zMin;
	public float zMax;
}

public class Player : MonoBehaviour
{
	public float moveSpeed;//移动速度
	Rigidbody rigidbody;//刚体组件
	public Boundary boundary;//场景边界

	//子弹发射
	public GameObject bulletPrefab;//子弹预制体
	public float fireSpeed;//发射频率  （每隔多长时间发射一个子弹）
	public Transform firePos;
	float fireTime;//发射时间  用于控制发射频率
	

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		if (rigidbody)
		{
			//通过输入 给刚体速度 模拟 3D物体移动
			var hor = Input.GetAxis("Horizontal");
			var ver = Input.GetAxis("Vertical");
			rigidbody.velocity = new Vector3(hor, 0, ver) * moveSpeed;


		}

		//移动限制  出边界则置回
		var posX = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
		var posZ = Mathf.Clamp(transform.position.z, boundary.zMin, boundary.zMax);
		transform.position = new Vector3(posX, transform.position.y, posZ);//重置位置

		//子弹发射
		if (Time.time - fireTime > fireSpeed)
		{
			//注意：Instantiate实例化一个资源预制体对象  会同时调用Awake唤醒函数  不会调用Start函数
			var bullet = GameObject.Instantiate(bulletPrefab);//通过子弹预制体创建子弹
			bullet.transform.position = firePos.position;//赋值位置
			fireTime = Time.time;
		}
	}
}


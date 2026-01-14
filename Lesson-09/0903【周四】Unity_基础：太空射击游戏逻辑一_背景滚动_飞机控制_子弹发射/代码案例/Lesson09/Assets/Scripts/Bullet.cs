/*
	Title:
	子弹
	
	Description:
	子弹移动及碰撞检测
	
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullet : MonoBehaviour
{
	Rigidbody rigidbody;
	public float moveSpeed;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
		if (rigidbody)
		{
			rigidbody.velocity = Vector3.forward * moveSpeed;
		}
	}
}


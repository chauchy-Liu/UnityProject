using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyTest : MonoBehaviour
{
    Rigidbody rigidbody;
    public float power;
    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// 点击物体施加一个力
    /// </summary>
    private void OnMouseUpAsButton()
    {
        //添加力
        rigidbody.AddForce( Vector3.forward * power);//transform.forward自己的正方向，
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //按空格跳跃
            // rigidbody.AddForce(Vector3.up*power);
            rigidbody.velocity += Vector3.up * 9;
        }
    }
}

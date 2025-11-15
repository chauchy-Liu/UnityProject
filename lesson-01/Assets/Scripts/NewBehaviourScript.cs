using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;//定义一个速度属性
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");//获取水平方向的输入量 AD键 左右箭头 -1～1
        float ver = Input.GetAxis("Vertical"); //获取水平方向的输入量 WS键 上下箭头 -1～1
        //让物体移动平移
        transform.Translate(new Vector3(hor, 0, ver) * speed * Time.deltaTime);
    }
}

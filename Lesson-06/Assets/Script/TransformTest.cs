using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    //public字段可以显示在unity的transform组件中的
    public Vector3 pos;
    public Vector3 rotate;
    public Vector3 scale;
    //属性不可以显示在unity的transform组件中
    public Vector3 cut {get; set;}

    // Start is called before the first frame update
    void Start()
    {
        print("游戏运行了 Start函数在第一帧更新前调用一次");
        print("Hello Unity!");
        var thisTransform = this.GetComponent<Transform>();
        GameObject sun = GameObject.Find("Sun");
        Transform sunTransform = sun.GetComponent<Transform>();

        //移动两对象的位置
        // thisTransform.position = new Vector3(-10,0,0);
        // sunTransform.position = new Vector3(0, 5, 0);

        //向量类
        //2d
        var v1 = new Vector2(10,20);
        var v2 = new Vector2(11,5);
        print(v1-v2);
        print(v1+v2);
        print(v1*2f);
        print(Vector2.Distance(new Vector2(0,10), new Vector2(0,30)));
        //3d
        var v3 = new Vector3(10,0,0);
        var v4 = new Vector3(5, 20);
        print(v3+v4);
        print(v3-v4);
        print(v3*0.5f);
        print(Vector3.Distance(v3,v4));

        //平移、旋转、缩放
        transform.position = pos;
        //欧拉角
        transform.eulerAngles = rotate;
        transform.localScale = scale;

    }

    public float translateSpeed;
    public float rotateSpeed;
    public Transform sun;//可视化赋值

    // Update is called once per frame
    void Update()
    {
        print("unity游戏运行 每帧更新  都调用一次Update");
        //让物体向上平移，速度依赖计算刷帧速度
        // transform.Translate(new Vector3(0,1,0)*speed, Space.World);
        //时间差值： 上一桢到当前桢花费的时间，速度不依赖刷帧速度
        transform.Translate(new Vector3(0,1,0)*translateSpeed*Time.deltaTime, Space.World);
        //旋转
        //传矢量
        transform.Rotate(new Vector3(0, 1, 0)*rotateSpeed*Time.deltaTime, Space.World);
        //传轴
        // transform.Rotate(Vector3.up*rotateSpeed*Time.deltaTime, Space.World);
        //围绕物体旋转
        transform.RotateAround(sun.position, sun.up, rotateSpeed*Time.deltaTime);

        //缩放
        transform.localScale += Vector3.one * 0.0002f;


    }
}

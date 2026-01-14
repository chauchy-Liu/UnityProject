using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NormalClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //找对象
        GameObject dog = GameObject.Find("Dog");
        Vector3 scale = dog.transform.localScale;
        //找到后放大
        float scaleValue = 2f;
        scale.x *=  scaleValue;
        scale.y *=  scaleValue;
        scale.z *=  scaleValue;
        dog.transform.localScale = scale;
        //10后删除
        // GameObject.Destroy(dog, 10);
        //通过标签找对象
        // var cat = GameObject.FindGameObjectWithTag("cat");
        // cat.transform.Rotate(new Vector3(0,0,1), 1, Space.Self);
        //找多只猫
        GameObject[] cats = GameObject.FindGameObjectsWithTag("cat");
        foreach (GameObject cat in cats)
        {
            cat.AddComponent<RotatSelf>();
            cat.AddComponent<RotateAround>();//对象添加组件
            var rotateAround = cat.GetComponent<RotateAround>();
            rotateAround.target = dog.transform;
            rotateAround.speedAround = 20;
            // GameObject.Destroy(cat, 10);
        }
        

    }

    public float time;
    public int s;
    public GameObject prefab;//预置游戏对象
    // Update is called once per frame
    void Update()
    {
        // print("deltaTime:"+Time.deltaTime);
        // print("time:"+Time.time);
        //制作秒表
        if (Time.time - time >= 1)
        {
            s++;
            print("秒表："+s);
            time = Time.time;
            //创建对象
            GameObject go = GameObject.Instantiate(prefab);
            //删除对象
            GameObject.Destroy(go, 10);
            

        }
        Debug.LogError("错误");
        Debug.Log("信息");
        Debug.LogWarning("警告");

        Mathf.Abs(-255);
        float ms = Mathf.Clamp(s, 10.0f, 20);
        Debug.Log("限定后的测试："+ms);
        Mathf.Pow(2,3);
        var i = Mathf.Repeat(s, 10);
        Debug.LogWarning(i);
        var r = Random.Range(0,3);
        Debug.LogError(r);


    }
        
}

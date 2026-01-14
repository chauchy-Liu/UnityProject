using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEventTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "狗":
                Debug.Log("汪汪。。。变大");
                //这是狗的tranform, MouseEventTest组件挂到哪个游戏对象transform就是谁的组件
                transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
                break;
            case "猫":
                Debug.Log("喵喵。。。旋转");
                // gameObject.AddComponent<RotatSelf>();
                transform.Rotate(new Vector3(0, 0, 1), 30, Space.Self);
                break;
            case "鸭":
                Debug.Log("嘎嘎嘎... 变色");
                GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;

        }       
    }
    private void OnMouseEnter()
    {
        Debug.Log("进入"+gameObject.name);
    }
}

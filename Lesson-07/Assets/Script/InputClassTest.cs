using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//通过键盘输入，控制红色cube移动
public class InputClassTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //通过按键输入移动一个物体
        float hor = Input.GetAxis("Horizontal"); //返回-1到1
        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hor, 0, ver)*speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.P))
        {
            // print("按下键调用");
            transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            // print("释放键调用");
            transform.localScale -= new Vector3(0.02f, 0.02f, 0.02f);
        }
        if (Input.GetKey(KeyCode.P))
        {
            // print("按下后持续调用");
            transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
        }
        if (Input.GetKey(KeyCode.O))
        {
            // print("按下后持续调用");
            transform.localScale -= new Vector3(0.02f, 0.02f, 0.02f);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("开火");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("左键按下");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("右键按下");
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("中键按下");
        }
    }
}

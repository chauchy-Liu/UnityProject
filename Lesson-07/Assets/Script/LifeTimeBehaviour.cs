using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeBehaviour : MonoBehaviour
{
    private void Awake()
    {
        print("对象被实例化 Awake函数调用。。。");
    }
    // Start is called before the first frame update
    private void Start()
    {
        print("对象被实例化 Start函数调用。。。");
    }

    // Update is called once per frame
    private void Update()
    {
        print("Update函数调用。。。");
    }
    private void FixedUpdate()
    {
        print("执行时间"+Time.time+" FixedUpdate函数调用。。。");
    }
    private void LateUpdate()
    {
        print("LateUpdate函数调用。。。");
    }
    private void OnEnable()
    {
        print("对象被激活调用OnEnable");
    }
    private void OnDisable()
    {
        print("对象被禁用调用OnDisable");
    }
    private void OnDestroy()
    {
        print("对象被销毁调用OnDestroy");
    }
    private void Reset()
    {
        print("对象重制调用Reset");
    }
}

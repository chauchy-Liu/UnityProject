/*
    *Author: 刘传玺
    *CreateTime: 2025-12-29 17:15:22
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    int s;
    UnityEngine.Coroutine coroutineTime;
    UnityEngine.Coroutine coroutineParam;
    // Start is called before the first frame update
    void Start()
    {
        coroutineTime = StartCoroutine("Func");
        coroutineParam = StartCoroutine(TestParam(5));
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log( "主程序正在执行");
        if (s == 10)
        {
            StopCoroutine(coroutineTime);
            StopCoroutine(coroutineParam);
            StopAllCoroutines();
        }
    }
    IEnumerator Func()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            s++;
            Debug.Log("协同程序执行： "+s);

            yield return StartCoroutine("Test");
            Debug.Log("等待Test协程完毕。。。");
        }
    }
    IEnumerator Test()
    {
        for (int i=0; i<5; i++)
        {
            Debug.Log("Test协程等待中");
        }
        yield return null;
    }
    IEnumerator TestParam(float t)
    {
        Debug.Log("TestParam带参协程等待中，参数："+t);
        yield return null;
    }
}

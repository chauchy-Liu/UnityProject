using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEventFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("鼠标按下");
    }
    private void OnMouseUp()
    {
        Debug.Log("鼠标抬起");
    }
    private void OnMouseEnter()
    {
        Debug.Log("鼠标进入");
    }
    private void OnMouseExit()
    {
        Debug.Log("鼠标离开");
    }
    private void OnMouseOver()
    {
        Debug.Log("鼠标掠过");
    }
    private void OnMouseUpAsButton()
    {
        Debug.Log("鼠标抬起并按下 --点击");
    }
    private void OnMouseDrag()
    {
        Debug.Log("鼠标拖拽");
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    //可视化字段
    public float speedAround;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.RotateAround(target.position, target.up, speedAround*Time.deltaTime);
    }
}

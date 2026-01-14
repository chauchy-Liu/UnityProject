/*
    *Author: 刘传玺
    *CreateTime: 2025-12-18 21:47:43
    *Title:
    *Description:
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClicked : MonoBehaviour
{
    public void OnClickedStartGame()
    {
        //切换游戏场景
        SceneManager.LoadScene("MainGame");

    }
    public void OnClickedReturn()
    {
        //切换到开始菜单
        SceneManager.LoadScene("BeginUI");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

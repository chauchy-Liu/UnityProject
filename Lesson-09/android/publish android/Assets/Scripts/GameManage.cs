/*
    *Author: 刘传玺
    *CreateTime: 2025-12-11 15:33:03
    *Title: 游戏控制单例
    *Description:
        控制游戏逻辑
*/

using System.Collections;
using System.Collections.Generic;
using PlayerSpace;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
namespace GameManageSpace
{
    [System.Serializable] //编辑器扩展命令，使得结构体对象可以在Inspector面板中显示
    public struct Boundary //边界
    {
        public float xMin, xMax, zMin, zMax;
    }
    public class GameManage : MonoBehaviour
    {
        public GameObject[] gameObjPrefabs;//游戏对象预置体 用于创建怪物
        //创建频率
        public float createSpeed;
        float createTime;
        public Boundary boundary;//边界
        //统计分数
        public static int score;
        public Text scoreText;//分数文本
        //游戏界面
        public GameObject gameOverPanel;
        //标记游戏结束
        private bool isGameOver = false;

        // Start is called before the first frame update
        void Awake()
        {
            instance = this;//单例模式赋值,获取Hierarchy中的挂载组件GameManage的GameManage对象
            //初始化挂载对象的内容
            scoreText.text = "Score: " + score.ToString();//scoreText.text是挂载Text UI对象的 text组件中的字段
        }

        public void ScoreUpdate(int scoreIncrease)//更新挂载对像的分数显示
        {
            score += scoreIncrease;
            scoreText.text = "Score: " + score.ToString();
        } 

        public void GameOver()
        {
            //激活游戏结束界面
            gameOverPanel.SetActive(true);
            //设置标志位
            isGameOver = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (Time.time - createTime > createSpeed && isGameOver == false)
            {
                //随机创建敌人
                int index = Random.Range(0, gameObjPrefabs.Length);
                var obj = GameObject.Instantiate(gameObjPrefabs[index]);
                float randomX = Random.Range(boundary.xMin, boundary.xMax);
                obj.transform.position = new Vector3(randomX,1.6f,9.53f);
                createTime = Time.time;
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();//退出程序（只用于发布版本的应用程序）
            }
        }
        #region 单例模式
        GameManage(){}
        static private GameManage instance;//静态私有字段
        public static GameManage Instance{//静态公有属性
            get
            {
                return instance;
            }
        }
        #endregion
    }
}

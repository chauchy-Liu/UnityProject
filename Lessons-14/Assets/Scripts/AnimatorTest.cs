/*
    *Author: #Name#
    *CreateTime: #CreateTime#
    *Title:
    *Description:
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;

public enum AnimationState
{
    Idel,
    Run,
    Death,
    Attack,
    Skill,
}

public class AnimatorTest : MonoBehaviour
{
    Animator animator;//动画控制器组件
    //动画状o
    AnimationState curRoleState;//当前状态
    AnimationState nextRoleState;//下一个状态
    SpriteRenderer spriteRenderer;//精灵渲染组件
    public float speed;//角色移动速度
    public float yLimitMin;
    public float yLimitMax;
    public float xLimitMin;
    public float xLimitMax;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        curRoleState = AnimationState.Idel;//初始待机状态
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //获取水平和垂直方向的输入
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        if (hor != 0 || ver != 0)
        {
            nextRoleState = AnimationState.Run;//如果有输入，设置状态为行走
            //如果有输入，设置动画参数为true，播放行走动画, 通过Animator组件找到触发条件为"ToRun"的Trigger参数，并触发它
            // animator.SetTrigger("ToRun");
            if (hor < 0)
            {
                spriteRenderer.flipX = true;//向左移动，水平翻转精灵
            }
            else if (hor > 0)
            {
                spriteRenderer.flipX = false;//向右移动，不翻转精灵
            }
            //角色移动
            UnityEngine.Vector3 displacement = new UnityEngine.Vector3(hor, ver, 0) * Time.deltaTime * speed;
            
            // displacement.y = math.clamp(displacement.y, yLimitMin, yLimitMax);
            
            // displacement.x = math.clamp(displacement.x, xLimitMin, xLimitMax);
            UnityEngine.Vector3 nextPosition = transform.position + displacement;
            //x方向限制, y方向限制
            nextPosition.x = math.clamp(nextPosition.x, xLimitMin, xLimitMax);
            nextPosition.y = math.clamp(nextPosition.y, yLimitMin, yLimitMax);
            transform.position = nextPosition;
        }
        else
        {
            nextRoleState = AnimationState.Idel;//如果没有输入，设置状态为待机
            //如果有输入，设置动画参数为true，播放行走动画, 通过Animator组件找到触发条件为"ToRun"的Trigger参数，并触发它
            //如果没有输入，设置动画参数为false，播放待机动画
            // animator.SetTrigger("ToIdel");
        }
        //判断当前状态和下一个状态是否变o
        if (curRoleState != nextRoleState)
        {
            //如果状态变o，更新当前状态
            curRoleState = nextRoleState;
            //根据当前状态，设置动画参数，播放对应动画
            switch (curRoleState)
            {
                case AnimationState.Idel:
                    animator.SetTrigger("ToIdel");
                    break;
                case AnimationState.Run:
                    animator.SetTrigger("ToRun");
                    break;
                case AnimationState.Death:
                    animator.SetTrigger("ToDeath");
                    break;
                case AnimationState.Attack:
                    animator.SetTrigger("ToAttack");
                    break;
                case AnimationState.Skill:
                    animator.SetTrigger("ToSkill");
                    break;
            }
            
        }
    }
}

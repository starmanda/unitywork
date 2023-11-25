using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Door2 : MonoBehaviour
{
    private Animator ani;

    void Start()
    {
        //获取子组件下的第一个组件，再获取子组件animation，
        //如果是获取自身组件，直接GetComponent<XXX>()
        ani = transform.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //当物体接触到时则播放animation中的km动画
        ani.Play("door2");
    }



    void Update()
    {

    }
}
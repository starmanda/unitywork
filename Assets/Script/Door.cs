using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Door : MonoBehaviour
{
    private Animator ani;
    void Start()
    {
        //获取子组件下的第一个组件，再获取子组件animation，
        
        ani = transform.GetComponent<Animator>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ani.Play("door");
    }
    private void OnTriggerExit(Collider other)
    {
        ani.Play("gm");
    }



    void Update()
    {

    }
}
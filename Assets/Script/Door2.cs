using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Door2 : MonoBehaviour
{
    private Animator ani;

    void Start()
    {
        //��ȡ������µĵ�һ��������ٻ�ȡ�����animation��
        //����ǻ�ȡ���������ֱ��GetComponent<XXX>()
        ani = transform.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //������Ӵ���ʱ�򲥷�animation�е�km����
        ani.Play("door2");
    }



    void Update()
    {

    }
}
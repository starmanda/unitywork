using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faceto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //��ǰ����ʼ�������������
        this.transform.LookAt(Camera.main.transform.position);
        this.transform.Rotate(90, 0, 0);
    }
}


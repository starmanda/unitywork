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
        //当前对象始终面向摄像机。
        this.transform.LookAt(Camera.main.transform.position);
        this.transform.Rotate(90, 0, 0);
    }
}


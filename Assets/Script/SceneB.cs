using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SceneBScripts : MonoBehaviour
{

    public TMP_Text NameShow;

    void Start()
    {
        DataShow2();
    }
    void Update()
    {

    }

    public void DataShow2()
    {
        //将SceneAScripts单例数据赋值给局部变量
        string name = sceneA.Instance.name1;
        NameShow.text = "昵称：" + name;

    }
}
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
        //��SceneAScripts�������ݸ�ֵ���ֲ�����
        string name = sceneA.Instance.name1;
        NameShow.text = "�ǳƣ�" + name;

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneA : MonoBehaviour
{
    public InputField Account;
    public InputField Password;
    public Button button;

    // �������൥��
    public static sceneA Instance;
    //�������������ڴ洢������Ҫ�����ݣ����˺�������
    public string name1;
    public string password1;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
        button.onClick.AddListener(Login2);

    }

    public void Login2()
    {
        if (Account.text != null && Password.text != null)
        {
            sceneA.Instance.name1 = Account.text;
            SceneManager.LoadScene(1);
        }
    }


}
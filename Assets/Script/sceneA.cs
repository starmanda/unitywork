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

    // 创建该类单例
    public static sceneA Instance;
    //该两个变量用于存储我们需要的数据，即账号与密码
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
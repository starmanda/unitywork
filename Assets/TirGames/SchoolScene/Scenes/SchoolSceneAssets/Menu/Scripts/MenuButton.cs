using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {
	public Button button;

	public void ButtonClick() {
		SceneManager.LoadScene(1);	
	}

	// Use this for initialization
	void Start () {
		button.onClick.AddListener(ButtonClick);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

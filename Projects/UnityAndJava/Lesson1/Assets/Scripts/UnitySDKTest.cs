﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lib.Unity;
using UnityEngine.UI;
using System;

public class UnitySDKTest : MonoBehaviour {

    public Button btn;
    public Button loginBtn;
    // Use this for initialization
	void Start () {
        UnitySDK.Instance().Init();
        btn.onClick.AddListener(OnClick);
        loginBtn.onClick.AddListener(OnLogin);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnClick() {
        UnitySDK.Instance().Log("UnitySDK", String.Format("current time is {0}", DateTime.Now.ToLongTimeString()));
    }

    void OnLogin()
    {
        UnitySDK.Instance().StartLogin();
    }
}

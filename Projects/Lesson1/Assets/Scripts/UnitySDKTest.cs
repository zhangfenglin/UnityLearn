using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lib.Unity;
using UnityEngine.UI;
using System;

public class UnitySDKTest : MonoBehaviour {

    public Button btn;
    // Use this for initialization
	void Start () {
        UnitySDK.Instance().Init();
        btn.onClick.AddListener(OnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnClick() {
        Debug.Log("------------------------");

        AndroidJavaClass activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaClass>("currentActivity");
        activity.Call("runOnUiThread", new AndroidJavaRunnable(() => {
            new AndroidJavaObject("android.app.DatePickerDialog", activity, new DateCallback(), selectedDate.Year, selectedDate.Month - 1, selectedDate.Day).Call("show");
        }));
    }

    private static DateTime selectedDate = DateTime.Now;

    class DateCallback : AndroidJavaProxy {

        public DateCallback() : base("android.app.DatePickerDialog$OnDataSetListener") {}

        void onDateSet(AndroidJavaObject view, int year, int monthOfYear, int dayOfMonth) {
            selectedDate = new DateTime(year, monthOfYear + 1, dayOfMonth);
        }
    }
}

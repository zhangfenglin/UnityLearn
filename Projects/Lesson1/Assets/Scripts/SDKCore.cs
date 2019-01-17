using System;
using UnityEngine;

namespace Lib.Unity
{
    public class SDKCore
    {
        AndroidJavaObject mObj;
        public void Init() {
            mObj = new AndroidJavaObject("com.fl.unity.NormalUnitySDK");
            mObj.Call("setLogEvent", new IEventLog());
        }

        public void Log(string tag, string msg) {
            mObj.Call("log", tag, msg);
        }

        public void StartLogin()
        {
            AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");

            mObj.Call("startLogin", jo, new LoginCallback());

            //AndroidJavaObject intent = new AndroidJavaObject("android.content.Intent", jo, new AndroidJavaClass("com.fl.activity.LoginActivity").GetRawClass());
            //jo.Call("startActivity", intent);
        }
    }
}

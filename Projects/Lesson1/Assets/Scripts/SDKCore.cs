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
    }
}

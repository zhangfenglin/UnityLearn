using System;
using UnityEngine;

namespace Lib.Unity
{
    public class LoginCallback : AndroidJavaProxy
    {
        public LoginCallback() : base("com.fl.unity.ILoginCallback") { }

        void onSuccess(string username)
        {
            Debug.Log(String.Format("Login Success: {0}", username));
        }

        void onFailure()
        {
            Debug.Log("Login failure");
        }
    }
}

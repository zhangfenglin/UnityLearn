using System;
using UnityEngine;

namespace Lib.Unity
{
    public class IEventLog : AndroidJavaProxy
    {
        public IEventLog() : base("com.fl.unity.IEventLog") {}
        void log(string tag, string msg) {
            Debug.Log(String.Format("tag:{0} => {1}", tag, msg));
        }
    }
}

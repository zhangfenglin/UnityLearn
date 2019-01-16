using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lib.Unity {
    public class UnitySDK
    {
        private static UnitySDK instance = new UnitySDK();
        private SDKCore mCore;

        public static UnitySDK Instance()
        {
            return instance;
        }

        public void Init()
        {
            mCore = new SDKCore();
            mCore.Init();
        }

        public void Log(string tag, string msg) {
            mCore.Log(tag, msg);
        }
    }
}

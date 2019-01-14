package com.fl.unity;

import android.util.Log;

public class NormalUnitySDK {
    private static final String TAG = "com.lib.unity";

    public void init() {
        Log.d(TAG, "Normal Unity SDK Init Function");
    }

    public void setClientId(String clientId) {
        Log.d(TAG, "Normal Unity SDK setClientId = " + clientId);
    }
}
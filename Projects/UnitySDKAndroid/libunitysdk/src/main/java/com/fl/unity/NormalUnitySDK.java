package com.fl.unity;

import android.util.Log;

public class NormalUnitySDK {
    private static final String TAG = "com.lib.unity";
    private IEventLog eventLog;

    public void init() {
        Log.d(TAG, "Normal Unity SDK Init Function");
    }

    public void setClientId(String clientId) {
        Log.d(TAG, "Normal Unity SDK setClientId = " + clientId);
    }

    public void setLogEvent(IEventLog logEvent) {
        this.eventLog = logEvent;
    }

    public void log(String tag, String msg) {
        if (this.eventLog != null) {
            this.eventLog.log(tag, msg);
        }
    }
}

package com.fl.activity;

import android.app.Activity;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.view.View;
import android.widget.EditText;

import com.fl.unity.ILoginCallback;
import com.fl.unity.R;

public class LoginActivity extends Activity implements View.OnClickListener {

    private static ILoginCallback loginCallback;

    public static void setCallback(ILoginCallback callback) {
        loginCallback = callback;
    }

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_login_activity);
        findViewById(R.id.btn_login).setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        int i = v.getId();
        if (i == R.id.btn_login) {
            String username = ((EditText) findViewById(R.id.et_username)).getText().toString();
            String password = ((EditText) findViewById(R.id.et_password)).getText().toString();

            if (password != null && password.equals("123456")) {
                loginCallback.onSuccess(username);
                finish();
            } else {
                loginCallback.onFailure();
            }
        }
    }
}

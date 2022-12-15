package com.example.myapplicationsalesave.Activity;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.example.myapplicationsalesave.R;

public class MainActivity extends AppCompatActivity {
    private Button btnVer;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnVer = (Button) findViewById(R.id.btnVer);

        btnVer.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Intent b = new Intent(MainActivity.this, Categoryys.class);
                startActivity(b);
                finish();
            }
        });
    }
}
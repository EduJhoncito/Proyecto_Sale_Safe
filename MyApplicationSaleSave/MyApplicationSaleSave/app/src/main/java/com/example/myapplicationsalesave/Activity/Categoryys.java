package com.example.myapplicationsalesave.Activity;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;


import com.example.myapplicationsalesave.R;

public class Categoryys extends AppCompatActivity {

    private Button button, btan, btn2, btn3, btn4, btn5, btn6;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_categoryys);

        button=(Button)findViewById(R.id.button);
        btan=(Button)findViewById(R.id.btan);
        btn2=(Button)findViewById(R.id.btn2);
        btn3=(Button)findViewById(R.id.btn3);
        btn4=(Button)findViewById(R.id.btn4);
        btn5=(Button)findViewById(R.id.btn5);
        btn6=(Button)findViewById(R.id.btn6);


        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(Categoryys.this, Cocinas.class);
                startActivity(i);
                finish();
            }
        });

        btan.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent d = new Intent(Categoryys.this, MainActivity.class);
                startActivity(d);
                finish();
            }
        });

        btn2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent g = new Intent(Categoryys.this, Refrigeradores.class);
                startActivity(g);
                finish();
            }
        });

        btn3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent h = new Intent(Categoryys.this, Climatizacion.class);
                startActivity(h);
                finish();
            }
        });

        btn4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent j = new Intent(Categoryys.this, Microondas.class);
                startActivity(j);
                finish();
            }
        });

        btn5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent l = new Intent(Categoryys.this, Televisores.class);
                startActivity(l);
                finish();
            }
        });

        btn6.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent m = new Intent(Categoryys.this, CuidadoPersonal.class);
                startActivity(m);
                finish();
            }
        });
    }
}

package com.example.myapplicationsalesave.Activity;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.myapplicationsalesave.Api.ServiceAPI;
import com.example.myapplicationsalesave.Model.Producto;
import com.example.myapplicationsalesave.R;
import com.example.myapplicationsalesave.Util.ConnectionREST;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class Televisores extends AppCompatActivity {

    private EditText _etResultado;
    private EditText _IdProducto;
    private EditText _IdCategoria;
    private EditText _Nombre;
    private EditText _Descripcion;
    private EditText _Precio;
    private EditText _Stock;
    private EditText _IdMarca;
    private Button button6, _btnGrabar, _btnModificar, _btnEliminar;

    private ServiceAPI serviceAPI;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_televisores);

        button6=(Button)findViewById(R.id.button6);

        _IdProducto = (EditText) findViewById(R.id.IdProducto);
        _IdCategoria = (EditText) findViewById(R.id.IdCategoria);
        _Nombre = (EditText) findViewById(R.id.Nombre);
        _Descripcion = (EditText) findViewById(R.id.Descripcion);
        _Precio = (EditText) findViewById(R.id.Precio);
        _Stock = (EditText) findViewById(R.id.Stock);
        _IdMarca = (EditText) findViewById(R.id.IdMarca);
        _etResultado = (EditText) findViewById(R.id.etResultado);
        _btnGrabar = (Button) findViewById(R.id.btnProcesar);
        _btnModificar = (Button) findViewById(R.id.btnModificar);
        _btnEliminar = (Button) findViewById(R.id.btnEliminar);

        serviceAPI = ConnectionREST.getConnection().create(ServiceAPI.class);

        load();

        button6.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent n = new Intent(Televisores.this, Categoryys.class);
                startActivity(n);
                finish();
            }
        });
        _btnGrabar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Producto pObj = new Producto(Integer.parseInt(_IdProducto.getText().toString()),
                        Integer.parseInt(_IdCategoria.getText().toString()),
                        _Nombre.getText().toString(),
                        _Descripcion.getText().toString(),
                        Double.parseDouble(_Precio.getText().toString()),
                        Integer.parseInt(_Stock.getText().toString()),
                        Integer.parseInt(_IdMarca.getText().toString())
                );
                addProducto(pObj);
            }
        });


        _btnEliminar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                eliminarProducto(Integer.parseInt(_IdProducto.getText().toString()));
            }
        });


        _btnModificar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Producto pObj = new Producto(Integer.parseInt(_IdProducto.getText().toString()),
                        Integer.parseInt(_IdCategoria.getText().toString()),
                        _Nombre.getText().toString(),
                        _Descripcion.getText().toString(),
                        Double.parseDouble(_Precio.getText().toString()),
                        Integer.parseInt(_Stock.getText().toString()),
                        Integer.parseInt(_IdMarca.getText().toString())
                );
                modifyProducto(pObj);
            }
        });
    }




    private void addProducto(Producto pObj)
    {
        Call<Producto> call = serviceAPI.addProducto(pObj);
        call.enqueue(new Callback<Producto>() {
            @Override
            public void onResponse(Call<Producto> call, Response<Producto> response){
                if (response.isSuccessful())
                {
                    Producto pro = response.body();
                    mensaje("Registro grabado satisfactoriamente");
                }
                else
                {
                    mensaje("Ocurrio un error al grabar los datos");
                }
            }
            @Override
            public void onFailure(Call<Producto> call, Throwable t){
                mensaje("Ocurrio un error desconocido" + t.getMessage());
            }
        });
    }




    private void eliminarProducto(int parseInt){
        Call<Producto> call = serviceAPI.removeProducto(parseInt);
        call.enqueue(new Callback<Producto>() {
            @Override
            public void onResponse(Call<Producto> call, Response<Producto> response) {
                if (response.isSuccessful())
                {
                    mensaje("Los datos se eliminaron satisfactoriamente");
                }
                else
                {
                    mensaje("Ocurrio un error desconocido");
                }
            }

            @Override
            public void onFailure(Call<Producto> call, Throwable t) {
                mensaje("Ocurrio un error" +t.getMessage());
            }
        });
    }




    private void modifyProducto(Producto pObj){
        Call<Producto> call = serviceAPI.modifyProducto(pObj);
        call.enqueue(new Callback<Producto>() {
            @Override
            public void onResponse(Call<Producto> call, Response<Producto> response) {
                if(response.isSuccessful())
                {
                    Producto pro = response.body();

                    mensaje("Los datos se modificaron satisfactoriamente");
                }
                else
                {
                    mensaje("Ocurrio un error desconocido");
                }
            }

            @Override
            public void onFailure(Call<Producto> call, Throwable t) {
                mensaje("Ocurrio un error" +t.getMessage());
            }
        });
    }





    private void load() {
        Call<List<Producto>> call = serviceAPI.listProduct();
        call.enqueue(new Callback<List<Producto>>() {
            @Override
            public void onResponse(Call<List<Producto>> call, Response<List<Producto>> response) {
                if(response.isSuccessful())
                {
                    List<Producto> lstProducto = response.body();
                    _etResultado.setText("\n\n\n\n");
                    for(Producto x:lstProducto)
                    {
                        _etResultado.append("IdProducto" + x.getIdproducto() + "IdCategoria" + x.getIdcategoria() + "Nombre" + x.getNombre()
                                + "Descripcion" + x.getDescripcion() + "Precio" + x.getDescripcion() + "Stock" + x.getStock() + "IdMarca" + x.getIdmarca() + "\n");
                        Toast.makeText(getApplicationContext(), "" + x.getNombre(), Toast.LENGTH_LONG).show();
                        mensaje(x.getIdproducto() + "-" + x.getNombre());
                    }
                }
                else
                {
                    Toast.makeText(null, "Error", Toast.LENGTH_LONG).show();
                }
            }

            @Override
            public void onFailure(Call<List<Producto>> call, Throwable t) {
                Toast.makeText(null, "Ocurrio un error", Toast.LENGTH_LONG).show();
            }
        });
    }




    public void mensaje(String msg)
    {
        AlertDialog.Builder alerta = new AlertDialog.Builder(this);
        alerta.setMessage(msg);
        alerta.show();
    }
}
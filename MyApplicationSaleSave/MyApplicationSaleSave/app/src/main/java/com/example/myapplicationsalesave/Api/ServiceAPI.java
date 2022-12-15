package com.example.myapplicationsalesave.Api;

import com.example.myapplicationsalesave.Model.Producto;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.DELETE;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.PUT;
import retrofit2.http.Path;

public interface ServiceAPI {
    @GET("producto")
    public abstract Call<List<Producto>> listProduct();
    @POST("producto/agregar")
    public abstract Call<Producto> addProducto(@Body Producto obj);
    @PUT("producto/modificar")
    public abstract Call<Producto> modifyProducto(@Body Producto obj);
    @DELETE("producto/eliminar/{idproducto}")
    public abstract Call<Producto> removeProducto(@Path("idproducto") int idproducto);
}

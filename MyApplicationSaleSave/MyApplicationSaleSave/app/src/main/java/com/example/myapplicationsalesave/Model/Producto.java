package com.example.myapplicationsalesave.Model;

import android.widget.EditText;

public class Producto {

    private int idproducto;
    private int idcategoria;
    private String nombre;
    private String descripcion;
    private double precio;
    private int stock;
    private int idmarca;

    public Producto() {
    }

    public Producto(int idproducto, int idcategoria, String nombre, String descripcion, double precio, int stock, int idmarca) {
        this.idproducto = idproducto;
        this.idcategoria = idcategoria;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.precio = precio;
        this.stock = stock;
        this.idmarca = idmarca;
    }

    public int getIdproducto() {
        return idproducto;
    }

    public void setIdproducto(int idproducto) {
        this.idproducto = idproducto;
    }

    public int getIdcategoria() {
        return idcategoria;
    }

    public void setIdcategoria(int idcategoria) {
        this.idcategoria = idcategoria;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public int getStock() {
        return stock;
    }

    public void setStock(int stock) {
        this.stock = stock;
    }

    public int getIdmarca() {
        return idmarca;
    }

    public void setIdmarca(int idmarca) {
        this.idmarca = idmarca;
    }
}

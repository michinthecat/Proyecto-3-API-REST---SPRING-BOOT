package com.lyjstore.apilyjstore.model;

import lombok.*;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;
import java.io.Serializable;

@Data
@Entity
@Table(name = "productos")
public class Producto implements Serializable {
    @Id
    private Long id;

    private String nombre;

    private Double precioVenta;

    private Long upc;

    public Producto(Long id, String nombre, Double precioVenta, Long upc) {
        this.id = id;
        this.nombre = nombre;
        this.precioVenta = precioVenta;
        this.upc = upc;
    }

    public Producto() {
    }

}

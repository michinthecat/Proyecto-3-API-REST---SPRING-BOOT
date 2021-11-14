package com.lyjstore.apilyjstore.model;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.*;

import javax.persistence.*;
import java.io.Serializable;
import java.time.LocalDate;

@Data
@Entity
@Table(name = "productos_pedidos")
public class ProductosPedidos implements Serializable {

    @EmbeddedId
    @JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
    private ProductosPedidosPK productosPedidosPK;

    @Column(name = "id_producto",updatable = false,insertable = false)
    private Long idProducto;

    @Column(name = "id_pedido",updatable = false,insertable = false)
    private Long idPedido;

    private short cantidad;

    private Double precio;

    private LocalDate fecha;

    @JoinColumn(name = "id_producto",referencedColumnName = "id",insertable = false,updatable = false)
    @ManyToOne
    @JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
    private Producto producto;

    @JoinColumn(name = "id_pedido",referencedColumnName = "id",insertable = false,updatable = false)
    @ManyToOne
    @JsonProperty(access = JsonProperty.Access.WRITE_ONLY)
    private Pedido pedido;


    public ProductosPedidos(ProductosPedidosPK productosPedidosPK, short cantidad, Double precio, LocalDate fecha) {
        this.productosPedidosPK = productosPedidosPK;
        this.cantidad = cantidad;
        this.precio = precio;
        this.fecha = fecha;
    }

    public ProductosPedidos() {
    }

}

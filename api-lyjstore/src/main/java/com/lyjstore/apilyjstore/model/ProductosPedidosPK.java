package com.lyjstore.apilyjstore.model;

import lombok.*;

import javax.persistence.Column;
import javax.persistence.Embeddable;
import java.io.Serializable;


@Data
@Embeddable
public class ProductosPedidosPK implements Serializable {

    @Column(name = "id_producto")
    private Long idProducto;

    @Column(name = "id_pedido")
    private Long idPedido;

    public ProductosPedidosPK() {
    }

    public ProductosPedidosPK(Long idProducto, Long idPedido) {
        this.idProducto = idProducto;
        this.idPedido = idPedido;
    }

}

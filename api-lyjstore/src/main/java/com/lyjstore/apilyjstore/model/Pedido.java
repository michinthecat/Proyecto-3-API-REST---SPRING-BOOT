package com.lyjstore.apilyjstore.model;

import lombok.*;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;
import java.io.Serializable;
import java.time.LocalDate;

@Data
@Entity
@Table(name = "pedidos")
public class Pedido implements Serializable {
    @Id
    private Long id;

    private LocalDate fecha;

    private Double precioEnvio;

    private Double precioImpuestos;

    private String guia;


}

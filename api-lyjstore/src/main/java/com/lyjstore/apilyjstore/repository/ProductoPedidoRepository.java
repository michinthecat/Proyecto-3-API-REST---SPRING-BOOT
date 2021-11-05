package com.lyjstore.apilyjstore.repository;

import com.lyjstore.apilyjstore.model.ProductosPedidos;
import com.lyjstore.apilyjstore.model.ProductosPedidosPK;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import java.util.List;
import java.util.Optional;

public interface ProductoPedidoRepository extends JpaRepository<ProductosPedidos, ProductosPedidosPK> {

    Optional<ProductosPedidos> findByProductosPedidosPKIdProductoAndProductosPedidosPKIdPedido(Long idProducto, Long idPedido);


    @Query(value = "SELECT p.precio, COUNT(p) FROM productos_pedidos p GROUP BY p.precio",nativeQuery = true)
    List<Object> listarPreciosAGraficar();

    List<ProductosPedidos> findAllByIdProducto(Long idProducto);
}

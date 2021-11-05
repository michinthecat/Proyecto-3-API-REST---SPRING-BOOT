using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI1.entity
{
    class ProductosPedidosPK
    {

        private Int64 idProducto;
                
        private Int64 idPedido;


        public Int64 IdProducto { get => idProducto; set => idProducto = value; }
        public Int64 IdPedido { get => idPedido; set => idPedido = value; }


    }
}

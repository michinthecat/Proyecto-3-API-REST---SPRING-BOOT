using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI1.entity
{
    class ProductosPedidos
    {
       

        private int cantidad;

        private Double precio;

        private DateTime fecha;

        private int idProducto;
        
        private int idPedido;


        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Double Precio { get => precio; set => precio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }





    }
}

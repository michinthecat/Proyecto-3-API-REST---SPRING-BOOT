using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI1.entity
{
    class Producto
    {
        
        private Double id;
        private String nombre;
        private Int64 precioVenta;
        private Double upc;

        public Double Id { get => id; set => id = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public Int64 PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public Double Upc { get => upc; set => upc = value; }


    }
}

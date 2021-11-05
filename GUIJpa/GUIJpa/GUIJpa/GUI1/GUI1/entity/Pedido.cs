using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI1.entity
{
    class Pedido
    {
        private Int64 id;

        private DateTime fecha;

        private Double precioEnvio;

        private Double precioImpuestos;

        private String guia;


        public Int64 getId()
        {
            return this.id;
        }

        public DateTime getFecha()
        {
            return this.fecha;
        }

        public Double getPrecioEnvio()
        {
            return this.precioEnvio;
        }

        public Double getPrecioImpuestos()
        {
            return this.precioImpuestos;
        }

        public String getGuia()
        {
            return this.guia;
        }

        public void setId(Int64 id)
        {
            this.id = id;
        }

        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void setPrecioEnvio(Double precioEnvio)
        {
            this.precioEnvio = precioEnvio;
        }

        public void setPrecioImpuestos(Double precioImpuestos)
        {
            this.precioImpuestos = precioImpuestos;
        }

        public void setGuia(String guia)
        {
            this.guia = guia;
        }
    }
}


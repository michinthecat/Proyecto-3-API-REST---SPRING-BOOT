using GUI1.entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI1.GUI.Detalle
{
    public partial class GUI_ConsultarD : Form
    {
        public GUI_ConsultarD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            WebClient webClient = new WebClient();
            String respuesta = "";
            String idProducto, idPedido;
            ProductosPedidos productosPedidos;



            idProducto = textBoxIDPro.Text;
            idPedido = textBoxIDPedido.Text;

            try
            {
                String uri = "http://localhost:8080/productos-pedidos/buscarProductosPedidosPorID/" + idProducto + "/" + idPedido;
                respuesta = webClient.DownloadString(uri);
                productosPedidos = JsonConvert.DeserializeObject<ProductosPedidos>(respuesta);

                textBoxCantidad.Text = productosPedidos.Cantidad.ToString();
                textBoxPrecio.Text = productosPedidos.Precio.ToString();
                textBoxFecha.Text = productosPedidos.Fecha.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "verificar la integridad de la info");
            }
            


        }
    }
}

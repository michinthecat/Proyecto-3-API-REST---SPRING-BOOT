using GUI1.entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI1.GUI.Detalle
{
    public partial class GUI_EliminarD : Form
    {
        public GUI_EliminarD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();
            //Sw_Pro.productosPedidos ordenObtenida = servicio.buscarProductoPedido(Convert.ToInt64(textBoxIDPedido.Text),Convert.ToInt64(textBoxIDPro.Text));
            //if (ordenObtenida == null)
            //{
            //    MessageBox.Show("No se encontro la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    textBoxCantidad.Text = ordenObtenida.cantidad.ToString();
            //    textBoxPrecio.Text = ordenObtenida.precio;
            //    textBoxFecha.Text = ordenObtenida.fecha.ToString();
            //}





            WebClient webClient = new WebClient();
            String respuesta = "";
            String idProducto, idPedido;
            ProductosPedidos productosPedidos;



            idProducto = textBoxIDPro.Text;
            idPedido = textBoxIDPedido.Text;


            String uri = "http://localhost:8080/productos-pedidos/buscarProductosPedidosPorID/" + idProducto + "/" + idPedido;
            respuesta = webClient.DownloadString(uri);
            productosPedidos = JsonConvert.DeserializeObject<ProductosPedidos>(respuesta);

            textBoxCantidad.Text = productosPedidos.Cantidad.ToString();
            textBoxPrecio.Text = productosPedidos.Precio.ToString();
            textBoxFecha.Text = productosPedidos.Fecha.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            //Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();
            //if (servicio.eliminarOrdenPorId(Convert.ToInt32(textBoxIDPedido.Text), Convert.ToInt32(textBoxIDPro.Text)))
            //{
            //    MessageBox.Show("Se ha eliminado exitosamente el detalle", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Hubo un error al eliminar el detalle, verifica la integridad de la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}



            WebClient webClient = new WebClient();
            String respuesta;
            String idProducto, idPedido;

            idProducto = textBoxIDPro.Text;
            idPedido = textBoxIDPedido.Text;
            String uri = "http://localhost:8080/productos-pedidos/eliminarProductosPedidos/" + idProducto+ "/"+idPedido;

            HttpClient cliente = new HttpClient();

            try
            {
                cliente.DeleteAsync(uri);
                MessageBox.Show("Se elimino correctamente", "Eliminado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en el servidor", "Error");

            }

        }
    }
    }


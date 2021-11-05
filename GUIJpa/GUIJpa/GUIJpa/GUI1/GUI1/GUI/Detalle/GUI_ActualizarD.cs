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
    public partial class GUI_ActualizarD : Form
    {
        public GUI_ActualizarD()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            



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



            labelEdit.Visible = true;
            buttonActualizar.Enabled = true;
            textBoxNewCantidad.ReadOnly = false;
            textBoxIDPro.ReadOnly = true;
            textBoxIDPedido.ReadOnly = true;
            buttonConsultar.Enabled = false;


        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            String uri;
            HttpClient cliente;
            HttpContent contenido;
            HttpResponseMessage respuesta;

            uri = "http://localhost:8080/productos-pedidos/actualizarProductosPedidosPorID/" + textBoxIDPro.Text + "/" + textBoxIDPedido.Text + "/" + textBoxNewCantidad.Text;
            cliente = new HttpClient();
            cliente.BaseAddress = new Uri(uri);
            cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            contenido = new StringContent("", UTF8Encoding.UTF8, "application/json");
            respuesta = cliente.PutAsync(uri, contenido).Result;

            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Detalle actualizado");
            }
            else
            {
                MessageBox.Show("Error");
            }


        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            textBoxIDPro.Text = "";
            textBoxIDPedido.Text = "";           
            buttonActualizar.Enabled = false;
            buttonConsultar.Enabled = true;
            textBoxCantidad.Text = "";
            textBoxPrecio.Text = "";
            textBoxIDPro.ReadOnly = false;
            textBoxIDPedido.ReadOnly = false;
            labelEdit.Visible = false;
            textBoxNewCantidad.Text = "";
            textBoxNewCantidad.ReadOnly = true;

        }
    }
}

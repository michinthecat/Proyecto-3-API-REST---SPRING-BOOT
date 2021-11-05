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
    public partial class GUI_AdicionarD : Form
    {
        public GUI_AdicionarD()
        {
            InitializeComponent();
        }

        private void GUI_AdicionarD_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {

           
            String uri;
            HttpClient cliente;
            HttpContent contenido;
            HttpResponseMessage respuesta;

            String productoPedidosJson = "";


            string theDate = fechaTool.Value.ToString("yyyy-MM-dd");


            productoPedidosJson = "{'productosPedidosPK':{'idProducto': "+textBoxIDPro.Text+",'idPedido': " + textBoxIDPedido.Text + " },'cantidad': " + textBoxCantidad.Text + ",'precio': " + textBoxPrecio.Text + ",'fecha':'" + theDate + "'}";
            productoPedidosJson = productoPedidosJson.Replace((char)39, (char)34);

            uri = "http://localhost:8080/productos-pedidos/guardarProductoPedido";
            cliente = new HttpClient();
            cliente.BaseAddress = new Uri(uri);
            cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            contenido = new StringContent(productoPedidosJson, UTF8Encoding.UTF8, "application/json");
            respuesta = cliente.PostAsync(uri, contenido).Result;

            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Detalle adicionado");
            }
            else
            {
                MessageBox.Show("Error Verifique La Info jiji");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {



            WebClient webClient = new WebClient();
            String respuesta = "";
            String idProducto;
            Producto producto;

            idProducto = textBoxIDPro.Text;
            String uri = "http://localhost:8080/productos/buscarPorId/" + idProducto;
            respuesta = webClient.DownloadString(uri);
            producto = JsonConvert.DeserializeObject<Producto>(respuesta);

            textBoxNombre.Text = producto.Nombre;
            textBoxUPC.Text = producto.Upc.ToString();




            textBoxIDPro.ReadOnly = true;
            textBoxCantidad.ReadOnly = false;
            textBoxIDPedido.ReadOnly = false;
            textBoxPrecio.ReadOnly = false;
            buttonAdicionar.Enabled = true;
            buttonConsultar.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonConsultar.Enabled = true;
            textBoxIDPro.ReadOnly = false;
            textBoxCantidad.Text = "";
            textBoxIDPedido.Text = "";
            textBoxPrecio.Text = "";
            textBoxCantidad.ReadOnly = true;
            textBoxIDPedido.ReadOnly = true;
            textBoxPrecio.ReadOnly = true;
            buttonAdicionar.Enabled = false;

            textBoxIDPro.Text = "";
            textBoxNombre.Text = "";
            textBoxUPC.Text = "";
              

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

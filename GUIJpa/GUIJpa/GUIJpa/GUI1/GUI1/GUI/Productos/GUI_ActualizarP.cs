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

namespace GUI1.GUI.Productos
{
    public partial class GUI_ActualizarP : Form
    {
        public GUI_ActualizarP()
        {
            InitializeComponent();
        }

        private void GUI_ActualizarP_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();

            //Sw_Pro.producto productoObtenido = servicio.obtenerProducto(Convert.ToInt64(textBoxID.Text));

            //if (productoObtenido == null)
            //{
            //    MessageBox.Show("No se encontro el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //textBoxNombre.Text = productoObtenido.nombre;
            //textBoxUPC.Text = Convert.ToString(productoObtenido.upc);
            //textBoxPrecio.Text = Convert.ToString(productoObtenido.precioVenta);

            WebClient webClient = new WebClient();
            String respuesta = "";
            String idProducto;
            Producto producto;

            idProducto = textBoxID.Text;
            String uri = "http://localhost:8080/productos/buscarPorId/" + idProducto;
            
            try
            {
                respuesta = webClient.DownloadString(uri);
                producto = JsonConvert.DeserializeObject<Producto>(respuesta);

                textBoxNombre.Text = producto.Nombre;
                textBoxPrecio.Text = producto.PrecioVenta.ToString();
                textBoxUPC.Text = producto.Upc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("verifique la integridad de la info", "Error");
            }
           

            textBoxID.ReadOnly = true;
            labelEdit.Text = "Indica El Nuevo Precio";
            textBoxPrecioNew.ReadOnly = false;
            buttonActualizar.Enabled = true;
            buttonConsultar.Enabled = false;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            textBoxID.ReadOnly = false;
            textBoxPrecioNew.ReadOnly = true;
            textBoxID.Text = "";
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
            textBoxUPC.Text = "";
            textBoxPrecioNew.Text = "";
            buttonActualizar.Enabled = false;
            labelEdit.Text = "";
            buttonConsultar.Enabled = true;


        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
           

            String uri;
            HttpClient cliente;
            HttpContent contenido;
            HttpResponseMessage respuesta;

            uri = "http://localhost:8080/productos/actualizarProducto/"+textBoxID.Text+"/"+textBoxPrecioNew.Text+"";
            cliente = new HttpClient();
            cliente.BaseAddress = new Uri(uri);
            cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            contenido = new StringContent("", UTF8Encoding.UTF8, "application/json");
            respuesta = cliente.PutAsync(uri,contenido).Result;

            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Producto actualizado");
            }
            else
            {
                MessageBox.Show("Error","verifique la interidad de la info");
            }

        }
    }
}

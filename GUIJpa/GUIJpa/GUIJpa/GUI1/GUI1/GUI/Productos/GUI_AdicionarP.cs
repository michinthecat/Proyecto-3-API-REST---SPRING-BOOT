using GUI1.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI1.GUI.Productos
{
    public partial class GUI_AdicionarP : Form
    {
        public GUI_AdicionarP()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            
            Producto producto;
            String uri;
            HttpClient cliente;
            HttpContent contenido;
            HttpResponseMessage respuesta;

            String productoJson = "";

            producto = new Producto();
            producto.Id = Convert.ToInt64(textBoxID.Text);
            producto.Nombre = textBoxNom.Text;
            producto.PrecioVenta = Convert.ToInt64(textBoxPVenta.Text);
            producto.Upc = Convert.ToInt64(textBoxUPC.Text);

            productoJson = "{'id': "+textBoxID.Text+", 'nombre': '"+textBoxNom.Text+"' , 'precioVenta': "+textBoxPVenta.Text+", 'upc': "+textBoxUPC.Text+"}";
            productoJson = productoJson.Replace((char)39, (char)34);

            uri = "http://localhost:8080/productos/guardarProducto";
            cliente = new HttpClient();
            cliente.BaseAddress = new Uri(uri);
            cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            contenido = new StringContent(productoJson, UTF8Encoding.UTF8, "application/json");
            respuesta = cliente.PostAsync(uri, contenido).Result;

            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Producto adicionado");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void GUI_AdicionarP_Load(object sender, EventArgs e)
        {

        }
    }
}

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

namespace GUI1.GUI.Productos
{
    public partial class GUI_ConsultarP : Form
    {
        public GUI_ConsultarP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            WebClient webClient = new WebClient();
            String respuesta = "";
            String idProducto;
            Producto producto;

            idProducto = textBoxID.Text;
            String uri = "http://localhost:8080/productos/buscarPorId/" + idProducto;
            respuesta = webClient.DownloadString(uri);
            producto = JsonConvert.DeserializeObject<Producto>(respuesta);

            textBoxNombre.Text = producto.Nombre;
            textBoxPrecio.Text = producto.PrecioVenta.ToString();
            textBoxUPC.Text = producto.Upc.ToString();


        }

        private void GUI_ConsultarP_Load(object sender, EventArgs e)
        {

        }
    }
}

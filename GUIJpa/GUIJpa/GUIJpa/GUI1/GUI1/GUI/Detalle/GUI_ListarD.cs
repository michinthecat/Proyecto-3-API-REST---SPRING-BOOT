using GUI1.entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class GUI_ListarD : Form
    {
        public GUI_ListarD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
          



        }

        private void GUI_ListarD_Load(object sender, EventArgs e)
        {

            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            ProductosPedidos[] productosPedidos;

            WebClient webClient = new WebClient();
            String respuesta = "";
            String uri;

            if (textBoxIDPro.Text.Equals("") || textBoxIDPro.Text.Equals(" "))
            {
                uri = "http://localhost:8080/productos-pedidos/listarProductosPedidos";
            }
            else
            {
                uri = "http://localhost:8080/productos-pedidos/listarProductosPedidos/" + textBoxIDPro.Text;
            }


            respuesta = webClient.DownloadString(uri);

            productosPedidos = JsonConvert.DeserializeObject<ProductosPedidos[]>(respuesta);


            dataGridListar.AutoGenerateColumns = true;

            dataGridListar.DataSource = productosPedidos;

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using GUI1.entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI1.GUI.Productos
{
    public partial class GUI_ListarP : Form
    {
        public GUI_ListarP()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listarProductosPorNombreResponseBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ButtonMostrar_Click(object sender, EventArgs e)
        {



            Producto[] producto;

            WebClient webClient = new WebClient();
            String respuesta = "";
            String uri ;

            if (textBoxNombreP.Text.Equals("") || textBoxNombreP.Text.Equals(" "))
            {
                uri = "http://localhost:8080/productos/listarProductos";
            }
            else
            {
                uri = "http://localhost:8080/productos/listarProductos/"+textBoxNombreP.Text;
            }

            respuesta = webClient.DownloadString(uri);

            producto = JsonConvert.DeserializeObject<Producto[]>(respuesta);

            dataGridProductos.AutoGenerateColumns = true;
            dataGridProductos.DataSource = producto;

        }
    }
}

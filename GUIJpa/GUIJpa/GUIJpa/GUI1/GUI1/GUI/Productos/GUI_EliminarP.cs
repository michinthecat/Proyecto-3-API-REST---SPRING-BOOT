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
    public partial class GUI_EliminarP : Form
    {
        public GUI_EliminarP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Sw_Pro.SWControladorClient client = new Sw_Pro.SWControladorClient();

            //Sw_Pro.producto producto = client.obtenerProducto(Convert.ToInt64(textBoxID.Text));

            //if (producto == null)
            //{
            //    MessageBox.Show("No se encontro el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    textBoxNombre.Text = producto.nombre;

            //}

            WebClient webClient = new WebClient();
            String respuesta = "";
            String idProducto;
            Producto producto;

            idProducto = textBoxID.Text;
            String uri = "http://localhost:8080/productos/buscarPorId/" + idProducto;
            respuesta = webClient.DownloadString(uri);
            producto = JsonConvert.DeserializeObject<Producto>(respuesta);

            if (producto == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                textBoxNombre.Text = producto.Nombre;

            }





        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Sw_Pro.SWControladorClient client = new Sw_Pro.SWControladorClient();

            //Boolean resultado = client.eliminarProductoPorId(Convert.ToInt64(textBoxIDPro2.Text));
            //if (resultado == true)
            //{
            //    MessageBox.Show("Se elimino correctamente el producto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    MessageBox.Show("Problema en el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}

            WebClient webClient = new WebClient();
            String respuesta;
            String idProducto;

            idProducto = textBoxID.Text;
            String uri = "http://localhost:8080/productos/eliminarProductoPorId/" + idProducto;

            HttpClient cliente = new HttpClient();

            try
            {
                cliente.DeleteAsync(uri);
                MessageBox.Show("Se elimino correctamente", "Eliminado");

            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error en el servidor", "Error");

            }





        }
    }
}

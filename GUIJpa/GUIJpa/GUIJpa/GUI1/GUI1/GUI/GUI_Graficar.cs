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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI1.GUI
{
    public partial class GUI_Graficar : Form
    {
        public GUI_Graficar()
        {
            InitializeComponent();
        }

        private void GUI_Graficar_Load(object sender, EventArgs e)
        {

            List<Double[]> objectsito ;

            WebClient webClient = new WebClient();
            String respuesta = "";
            String uri;

          
            
                uri = "http://localhost:8080/productos-pedidos/preciosAGraficar";
           

            respuesta = webClient.DownloadString(uri);

            objectsito = JsonConvert.DeserializeObject<List<Double[]>>(respuesta);



            List<Double[]> listaDetalle = objectsito;




            chartTortita.Series.Clear();
            chartTortita.Palette = ChartColorPalette.Pastel;       


            Series graficaMain = new Series();


            foreach (var pto in listaDetalle)
            {                
                graficaMain = chartTortita.Series.Add(pto[0].ToString());
                graficaMain.Label = pto[1].ToString();
                graficaMain.Points.Add(Convert.ToInt32(pto[0]));
            }




        }

        private void chartTortita_Click(object sender, EventArgs e)
        {

        }
    }
}

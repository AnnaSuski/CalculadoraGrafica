using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula2202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbArea.Checked == true)
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double area = Math.PI * Math.Pow(raio, 2);
                lbResultado.Text = "Area = " + area.ToString("N3");
            }
            if (rbPerimetro.Checked == true)
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double perimetro = 2 * Math.PI * raio;
                lbResultado.Text = "Perimetro = " + perimetro.ToString("N3");
            }
            if (rbVolume.Checked == true)
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double volume = 3f / 4f * Math.PI * Math.Pow(raio, 3);
                lbResultado.Text = "Volume = " + raio.ToString("N3");
            }
            PlotarCirculo();

        }

        private void PlotarCirculo()
        {
            Graphics tela = pnDesenho.CreateGraphics();
            Pen caneta = new Pen(Color.Indigo, 3);
            double raio = Convert.ToDouble(txtRaio.Text);
            tela.Clear(Color.White);
            tela.DrawEllipse(caneta, 10, 10, (int)raio, (int)raio);
            caneta.Color = Color.Tomato;
            tela.DrawRectangle(caneta, 10, 10, (int)raio, (int)raio);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoja1IPC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double n1;
        Double n2;
        Double n3;
        Double n4;
        Double n5;
        Double n6;
        Double sumatoria;
        static System.Globalization.NumberFormatInfo ni = null;

        double[] numeros;
        private void btnMedia_Click(object sender, EventArgs e)
        {
            Double media;
            n1 = Convert.ToDouble(txt1.Text);
            n2 = Convert.ToDouble(txt2.Text);
            n3 = Convert.ToDouble(txt3.Text);
            n4 = Convert.ToDouble(txt4.Text);
            n5 = Convert.ToDouble(txt5.Text);
            n6 = Convert.ToDouble(txt6.Text);
            sumatoria = n1 + n2 + n3 + n4 + n5 + n6;
            media = sumatoria / 6;
            label10.Text = "Respuesta: " + media;
            label10.Visible = true;

        }

        private void btnMediana_Click(object sender, EventArgs e)
        {
            Double mediana;
            n3 = Convert.ToDouble(txt3.Text);
            n4 = Convert.ToDouble(txt4.Text);
            sumatoria = n3 + n4;
            mediana = sumatoria / 2;
            label11.Text = "Respuesta: " + mediana;
            label11.Visible = true;

        }

        private void btnModa_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txt1.Text);
            n2 = Convert.ToDouble(txt2.Text);
            n3 = Convert.ToDouble(txt3.Text);
            n4 = Convert.ToDouble(txt4.Text);
            n5 = Convert.ToDouble(txt5.Text);
            n6 = Convert.ToDouble(txt6.Text);
            numeros = new double[6];
            numeros[0] = n1;
            numeros[1] = n2;
            numeros[2] = n3;
            numeros[3] = n4;
            numeros[4] = n5;
            numeros[5] = n6;
            double valorModal = 0;
            double existencia = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                int contador = 0;
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[j] == numeros[i])
                    {
                        contador++;
                    }
                }
                if (contador > existencia)
                {
                    existencia = contador;
                    valorModal = numeros[i];
                }
            }
            if (existencia == 1)
            {
                label12.Text = "Respuesta: No hay moda";
                label12.Visible = true;
            }
            else
            {
                label12.Text = "Respuesta: Moda= " + valorModal;
                label12.Visible = true;
            }

        }

        private void btnDesviacion_Click(object sender, EventArgs e)
        {
        }
    }


}

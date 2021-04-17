using ARREGLOS.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARREGLOS
{
    public partial class Form1 : Form
    {
        public string[,] matriz;
        ClsArreglos arreglo = new ClsArreglos(); 
        ClsPromedio promedio = new ClsPromedio();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click_1(object sender, EventArgs e)
        {
            ClsArchivo archivo = new ClsArchivo(); 
            string[] filas = archivo.obtenerFilas(); 

            textBoxResultado.Text = "Listo, el archivo está cargado";
            this.matriz = arreglo.arregloDosDimensiones(filas, 7); 
        }
        private void buttonNombres_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            string[] datos = arreglo.MetodoBurbujaCadena(this.matriz, 1); 
            for (int i = 0; i < datos.Length; i++)
            {
                listBoxResultado.Items.Add(datos[i]); 
            }
        }

        private void buttonNota1_Click_1(object sender, EventArgs e)
        {
            int[] datos = arreglo.MetodoBurbuja(this.matriz, 2);
            for (int i = 0; i < datos.Length; i++)
            {
                listBoxNota1.Items.Add(datos[i]);
            }
            int datosProm = promedio.promedios_por_parcial(matriz, 2);
            MessageBox.Show($"El promedio del parcial 1 es: {datosProm} ");
        }

        private void buttonNota2_Click(object sender, EventArgs e)
        {
            int[] datos = arreglo.MetodoBurbuja(this.matriz, 2);
            for (int i = 0; i < datos.Length; i++)
            {
                listBoxNota2.Items.Add(datos[i]);
            }
            int datosProm = promedio.promedios_por_parcial(matriz, 3);
            MessageBox.Show($"El promedio del parcial 1 es: {datosProm} ");
        }

        private void buttonNota3_Click(object sender, EventArgs e)
        {
            int[] datos = arreglo.MetodoBurbuja(this.matriz, 2);
            for (int i = 0; i < datos.Length; i++)
            {
                listBoxNota3.Items.Add(datos[i]);
            }
            int datosProm = promedio.promedios_por_parcial(matriz, 3);
            MessageBox.Show($"El promedio del parcial 1 es: {datosProm} ");

        }

        private void buttonPromedio_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                listBox1.Items.Add($"Alumno {matriz[i, 1]} promedio: {matriz[i, 6]}");
            }                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            listBoxProm1.Items.Clear();
            listBoxProm2.Items.Clear();
            listBoxProm3.Items.Clear();
            listBoxPG.Items.Clear();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            string seccion = comboBox1.Text;
            int datos = promedio.promedios_general_seccion(matriz, 6, seccion);
            listBoxPG.Items.Add(datos);
        }

        private void buttonP1_Click(object sender, EventArgs e)
        {
            string seccion = comboBox1.Text;
            int datos = promedio.promedios_por_seccion(matriz, 2, seccion);
            listBoxProm1.Items.Add(datos);
        }

        private void buttonP2_Click(object sender, EventArgs e)
        {
            string seccion = comboBox1.Text;
            int datos = promedio.promedios_por_seccion(matriz, 3, seccion);
            listBoxProm2.Items.Add(datos);
        }

        private void buttonP3_Click(object sender, EventArgs e)
        {
            string seccion = comboBox1.Text;
            int datos = promedio.promedios_por_seccion(matriz, 4, seccion);
            listBoxProm3.Items.Add(datos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string seccion = comboBox2.Text;
            string[,] datos = promedio.Clasificar_Alumnos(matriz, seccion);
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                listBox2.Items.Add(datos[i, 0] + "; " + datos[i, 1] + "; " + datos[i, 2] + "; " + datos[i, 3] + "; " + datos[i, 4] + "; " + datos[i, 5] + "; " + datos[i, 6] + "; ");
            } 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}

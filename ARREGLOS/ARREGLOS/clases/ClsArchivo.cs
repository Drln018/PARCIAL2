using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARREGLOS.clases
{
    class ClsArchivo
    {
        public string ruta { get; private set; }
        public string[] filas { get; private set; }
        public ClsArchivo() //se crea el constructor y dentro de el abrir archivo
        {
            abrirArchivo();
        }
        private string abrirArchivo()
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Title = "Seleccionar archivo";
            archivo.InitialDirectory = @"C:\Users\13237\OneDrive\Desktop";
            archivo.Filter = "Archivos CSV|*.csv";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                ruta = archivo.FileName;
            }
            return ruta;
        }
        public string[] obtenerFilas() // obtenemos las filas del archivo
        {
            string[] filas = File.ReadAllLines(ruta); //fila va hacer igual todas las lineas que estan en la ruta
            this.filas = filas;
            return filas; //retorna las filas
        }
    }
}



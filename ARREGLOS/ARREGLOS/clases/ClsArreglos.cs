using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARREGLOS.clases
{
    class ClsArreglos
    {
        private int[] datos;
        private int i, j;
        private int tamanoArreglo = 0;


        public ClsArreglos(int[] arreglo) //constructor tiene un parametro de tipo entero
        {
            datos = arreglo; //int datos = arreglo
            tamanoArreglo = datos.Length; //el tamaño = numero de datos
        }

        public ClsArreglos()
        {
        }

        public string[,] arregloDosDimensiones(string[] arreglo, int numColumnas) //parametro string y entero
        {
            string[,] matriz = new string[arreglo.Length - 1, numColumnas]; //creamos nueva variable de dos dimensiones
                                                                            //-1 por porque no queremos el encabezado
                                                                            //numColumas es igual a 6
            int contador = 0;
            foreach (string filas in arreglo) //con la variable filas recorremos el arreglo
            {
                if (contador > 0)
                {
                    string[] columnas = filas.Split(';'); // dividimos con ;
                    matriz[contador - 1, 0] = columnas[0];
                    matriz[contador - 1, 1] = columnas[1];
                    matriz[contador - 1, 2] = columnas[2];
                    matriz[contador - 1, 3] = columnas[3];
                    matriz[contador - 1, 4] = columnas[4];
                    matriz[contador - 1, 5] = columnas[5];
                    int suma = Convert.ToInt32(columnas[2]) +Convert.ToInt32(columnas[3]) + Convert.ToInt32(columnas[4]);
                    int promedio = suma / 3; //sumamos las 3 posiciones de los parciales
                    matriz[contador - 1, 6] = Convert.ToString(promedio); 
                }
                contador++;
            }
            return matriz;
        }
        public string[] MetodoBurbujaCadena(string[,] matriz, int columna)
        {
            string[] arreglo = new string[matriz.GetLength(0) - 1]; //el tamaño filas de la matriz -1
            for(int i=0; i < arreglo.Length; i++)
            {
                arreglo[i] = matriz[i, columna];
            }
         
            string[] ordenarNombres = arreglo;
            string datoTemporalCadena;

            for (int i = 0; i <arreglo.Length; i++)
            {
                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    if (ordenarNombres[i].CompareTo(ordenarNombres[j]) > 0)
                    {
                        datoTemporalCadena = ordenarNombres[i];
                        ordenarNombres[i] = ordenarNombres[j];
                        ordenarNombres[j] = datoTemporalCadena;
                    }
                }
            }
            return ordenarNombres;
        }

        public int[] MetodoBurbuja(string[,] matriz, int columna)
        {
            //crear un arreglo nuevo
            int[] arregloNew = new int[matriz.GetLength(0) - 1];
            for(int i=0; i < arregloNew.Length; i++)
            {
                arregloNew[i] = Convert.ToInt32(matriz[i, columna]);
            }

            //ordenar
            int[] ordenarNum = arregloNew;
    
            int datoTemporal;
            for (i = 0; i < arregloNew.Length; i++)
            {
                for (j = i + 1; j < arregloNew.Length; j++)
                {
                    if (ordenarNum[i] > ordenarNum[j])
                    {
                        datoTemporal = ordenarNum[i];
                        ordenarNum[i] = ordenarNum[j];
                        ordenarNum[j] = datoTemporal;
                    }
                }
            }
            return ordenarNum;
        }
    }
}

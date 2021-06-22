using System;
using System.Collections.Generic;
using System.Text;

namespace App2Arreglos
{
    class Palabras
    {
        //Método para escribir la cadena al revéz
        //Se recibirá por parámetro la palabra que se va a invertir
        public string Cadena_inversa(string palabra)
        {
            string palabra_inversa = "";
            for (int i = palabra.Length -1; i>=0; i--)
            {
                palabra_inversa += palabra[i];
            }
            return palabra_inversa;
        }
        //Método para convertir la palabra a mayúscula
        public string Palabra_mayuscula(string palabra)
        {
            string palabramayuscula = "";
            palabramayuscula = palabra.ToUpper();
            return palabramayuscula;
        }
        //Método para modificar la palabra
        //Se recibira por parametro la cadena en mayúscula
        public string PalabraModificada(string palabramayuscula)
        {
            string palabraM="";
            //Se calculará la cantidad de caracteres de la palabra
            int caracter = palabramayuscula.Length;
            //Se usa un array de tipo char con los espacios para cada caracter de la palabra
            char[] caracteres = new char[caracter];
            int j = 0;
            //Se usa un ciclo foreach para recorrer la palabra y guardar cada caracter en el array
            foreach (var i in palabramayuscula)
            {
                caracteres[j] = (i);
                j++;
            }
            //El ciclo for va a recorrer y analizar cada uno de los espacios del array
            //Se harán los cambios establecidos según sea necesario
            for(int i = 0; i < caracteres.Length; i++)
            {
                if (caracteres[i] == 'A')
                {
                    caracteres[i] = '4';
                }
                if (caracteres[i] == 'I')
                {
                    caracteres[i] = '1';
                }
                if (caracteres[i] == 'S')
                {
                    caracteres[i] = '5';
                }
                if (caracteres[i] == 'B')
                {
                    caracteres[i] = '8';
                }
                if (caracteres[i] == 'E')
                {
                    caracteres[i] = '3';
                }
                if (caracteres[i] == 'T')
                {
                    caracteres[i] = '7';
                }

            }
            //Se recorre de nuevo el array y se crea la cadena modificada
            foreach (var m in caracteres)
            {
                palabraM += m;
            }

            return palabraM;
        }
    }
}

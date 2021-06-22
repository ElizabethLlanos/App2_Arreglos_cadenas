using System;

namespace App2Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia
            Palabras objpalabra = new Palabras();
            Console.WriteLine("♦♦♦♦♦♦♦♦♦ PALABRAS ♦♦♦♦♦♦♦♦♦\n");
            Console.Write("►Introduce una palabra:");
            string palabra = Console.ReadLine();
            Console.WriteLine();
            //Llamada al método para invertir la palabra 
            string inversa = objpalabra.Cadena_inversa(palabra);
            //Mostrar la palabra invertida
            Console.WriteLine("►►►►► PALABRA ESCRITA AL REVÉZ ◄◄◄◄◄\n");
            Console.WriteLine($"♦>>{inversa}\n");
            //Llamada al método para convertir la palabra a mayusculas
            string palabraMay =objpalabra.Palabra_mayuscula(palabra);
            //Mostrar la palabra en mayusculas
            Console.WriteLine("►►►►► PALABRA EN MAYUSCULAS ◄◄◄◄◄\n");
            Console.WriteLine($"♦>>{palabraMay}\n");
            //Llamada al método para modificar la palabra 
            string palabraMod = objpalabra.PalabraModificada(palabraMay);
            //Mostrar la palabra modificada
            Console.WriteLine("►►►►► PALABRA MODIFICADA ◄◄◄◄◄\n");
            Console.WriteLine($"♦>>{palabraMod}\n");
           
        }
    }
}

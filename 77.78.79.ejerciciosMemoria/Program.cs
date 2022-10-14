    using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77._78._79.ejerciciosMemoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sortedList

            SortedList diccio = new SortedList();
            string frase;

            diccio.Add("hello", "hola");
            diccio.Add("good bye", "chau");
            diccio.Add("good morring", "buenos dias");
            diccio.Add("brother", "hermano");

            Console.WriteLine(diccio.Count);

            Console.WriteLine("ingrese una frase en ingles a traducir: ");
            frase = Console.ReadLine();
            string[] arreglo = frase.Split();

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }

            #endregion

            #region tabla hash 

            //Hashtable diccio = new Hashtable();

            //diccio.Add("hello", "hola");
            //diccio.Add("good bye", "chau");
            //diccio.Add("good morring", "buenos dias");
            //diccio.Add("brother", "hermano");

            //foreach (DictionaryEntry elemento in diccio)
            //{
            //    Console.WriteLine("{0} = {1}", elemento.Key, elemento.Value);
            //}

            //Console.ReadKey(); 

            #endregion

            #region sortedset y hasset

            //SortedSet<string> diccio = new SortedSet<string>();
            //string frase; 

            //Console.WriteLine("Ingrese una frase: ");
            //frase = Console.ReadLine();



            //diccio.Add("hola");
            //diccio.Add("adios");
            //diccio.Add("bueno");


            //if (diccio.Contains("adios"))
            //    Console.WriteLine("adios si esta"); 
            #endregion

            Console.ReadKey();

        }
    }
}

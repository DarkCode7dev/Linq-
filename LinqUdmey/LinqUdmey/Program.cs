using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqUdmey
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I love cats";

            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Loki", "Oscar", "Toby" };

            int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

            //"from" ke baad variable name phir "in" phir collection name phir "select" phir variable name 

            var simpleLinq = from s in sentence
                             select s;     
                            


           
            


            Console.WriteLine(string.Join("  , ", simpleLinq));

           
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valor1 = "Este es el valor 1";
            int valor2 = 5;
            string valor3 = valor1;
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}

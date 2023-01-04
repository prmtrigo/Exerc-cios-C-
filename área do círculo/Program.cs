// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
    class Program{
        static void Main(string[] args){
            double raio;
            double pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }

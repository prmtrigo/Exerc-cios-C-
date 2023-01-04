// See https://aka.ms/new-console-template for more information
using System.Globalization;
class Program{
    static void Main (string[] args){
        int rodadas = int.Parse(Console.ReadLine());

        for(int i = 0; i< rodadas; i++){

            string[] line = Console.ReadLine().Split(' ');
            double a = double.Parse(line[0], CultureInfo.InvariantCulture);
            double b = double.Parse(line[1], CultureInfo.InvariantCulture);
            double c = double.Parse(line[2], CultureInfo.InvariantCulture);

            double notas = (a * 2.0 + b * 3.0 + c * 5.0)/ 10.0;

            Console.WriteLine(notas.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}

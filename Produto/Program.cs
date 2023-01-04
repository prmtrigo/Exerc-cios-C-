// See https://aka.ms/new-console-template for more information
class Projeto{
    static void Main(string[] args){
        int a,b,c,d;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());

        int produto = (a*b) - (c*d);

        Console.WriteLine("Produto = " + produto);
    }
}

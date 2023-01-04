// See https://aka.ms/new-console-template for more information
class Program{
    static void Main(string[] args){

        int numero = int.Parse(Console.ReadLine());

        if(numero < 0){
            Console.WriteLine(numero + " É NEGATIVO");   
        }
        else
        {
            Console.WriteLine(numero + " NÃO É NEGATIVO");   
        }
    }
}

// See https://aka.ms/new-console-template for more information
class Program{
    static void Main(string[] args){
        int numero;
        int armazena = 1;

        numero = int.Parse(Console.ReadLine());

        for(int i = numero; i> 0; i--){
            armazena = armazena * i;
        }

        Console.WriteLine(armazena);
    }
}

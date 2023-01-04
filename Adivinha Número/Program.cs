// See https://aka.ms/new-console-template for more information

class Program {
    static void Main (string[] args){

        Random rnd = new Random();

        int rand_number = rnd.Next(1,10);

        int contador = 1;

        int chute = int.Parse(Console.ReadLine());

        while(rand_number != chute){
            
            Console.WriteLine("Tente Novamente");
            if (rand_number > chute){
                Console.WriteLine("O Número é Maior!");
            }
            else{
                Console.WriteLine("O Número é Menor!");
            }

            chute = int.Parse(Console.ReadLine());

            contador++;
        }

        Console.WriteLine("Você Acertou, o número é: " + chute);
        Console.WriteLine("Tentativas: " + contador);
    }
}

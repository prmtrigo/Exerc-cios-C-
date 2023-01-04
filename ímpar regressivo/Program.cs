// See https://aka.ms/new-console-template for more information
class Program{
    static void Main(string[] args){
        int número = int.Parse(Console.ReadLine());

        for(int i = 1; i <= número; i++){
            if(i%2 != 0){
                Console.WriteLine(i);
            }
        }
    }
}

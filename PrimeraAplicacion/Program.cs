
namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce un valor númerico");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un segundo valor númerico");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: " + (num1 + num2));
                    
        }
    }
}
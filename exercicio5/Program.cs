namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        { //exercicio5
            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("numero par:" + numero);
                }
                else
                {
                    Console.WriteLine("numero impar:" + numero);
                }
                Console.ReadKey();
            }
        }
    }
}
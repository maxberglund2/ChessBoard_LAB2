namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en siffra:");

            int userNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < userNumber; i++)
            {
                for (int j = 0; j < userNumber; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

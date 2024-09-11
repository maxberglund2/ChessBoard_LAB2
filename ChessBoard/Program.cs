namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string chessPiece = "🙂 ";

            Console.WriteLine("Mata in en siffra:");
            int userNumber = int.Parse(Console.ReadLine());

            // Console ask user to place a piece
            Console.WriteLine("Vilken rad vill du placera pjäsen på?");

            // A variable to store chessPiece position (A1)
            string chessPiecePosition = Console.ReadLine();

            // array for alphabet
            string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
            string currentLetter;

            // for loop to print the chess board
            for (int i = 0; i < userNumber; i++)
            {
                currentLetter = alphabet[i];
                for (int j = 0; j < userNumber; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("◼︎");
                    }
                    else if (currentLetter == chessPiecePosition.Substring(0, 1) && j == int.Parse(chessPiecePosition.Substring(1, 1)) - 1)
                    {
                        Console.Write(chessPiece);
                    }
                    else
                    {
                        Console.Write("◻︎");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

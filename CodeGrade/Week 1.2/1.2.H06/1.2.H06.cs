using System;

namespace CodeGrade
{
    class ChessboardGen
    {
        static void Main()
        {
            int boardSize;
            do
            {
            Console.WriteLine("How big should the board be?");
            boardSize = Convert.ToInt32(Console.ReadLine());
            } while (boardSize < 2);
            for (int i = 0; i < boardSize; i++)
            {
                for (int tiles = 0; tiles < boardSize; tiles++)
                {
                    switch (boardSize % 2)
                    {
                        case 0:
                            switch (i % 2)
                            {
                                case 0:
                                    Console.Write(tiles % 2 == 0 ? "W" : "B");
                                    break;
                                case 1:
                                    Console.Write(tiles % 2 == 0 ? "B" : "W");
                                    break;
                            }
                            break;
                        case 1:
                            switch (i % 2)
                            {
                                case 0:
                                    Console.Write(tiles % 2 == 0 ? "B" : "W");
                                    break;
                                case 1:
                                    Console.Write(tiles % 2 == 0 ? "W" : "B");
                                    break;
                            }
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
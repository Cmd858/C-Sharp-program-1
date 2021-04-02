using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3,3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            bool won = false;
            char turn = 'o';
            while (won == false)
            {
                for (int i = 0; i < 3; i++) 
                {
                    Console.WriteLine($"{board[i, 0]}|{board[i, 1]}|{board[i, 2]}");
                    if (i < 2)
                    {
                        Console.WriteLine("-----");
                    }
                }
                char pos = Console.ReadLine().ToCharArray()[0];
                int x = (pos - '1')/3; // lol
                int y = (pos - '1') % 3;
                board[x, y] = turn;
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] == turn && board[i, 1] == turn && board[i, 2] == turn)
                    {
                        won = true;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    if (board[0, i] == turn && board[1, i] == turn && board[2, i] == turn)
                    {
                        won = true;
                    }
                }
                if (board[0, 0] == turn && board[1, 1] == turn && board[2, 2] == turn)
                {
                    won = true;
                }
                if (board[0, 2] == turn && board[1, 1] == turn && board[2, 0] == turn)
                {
                    won = true;
                }
                if (won == true)
                {
                    continue;
                }

                if (turn == 'o')
                {
                    turn = 'x';
                }
                else
                {
                    turn = 'o';
                }
            }
            Console.WriteLine($"{turn} won!");
            Console.Read();
        }
    }
}
  
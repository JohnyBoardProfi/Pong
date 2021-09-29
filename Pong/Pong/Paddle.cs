using System;

namespace Pong
{
    public class Paddle
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Length { get; set; }

        int boardHeight;
        Printer p = new Printer();

        public Paddle(int x, int boardHeight)
        {
            this.boardHeight = boardHeight;
            X = x;
            Y = boardHeight / 2;
            Length = boardHeight / 3;
        }

        public void Up()
        {
            if (Y - 1 - (Length / 2) != 0)
            {
                p.Print(X, Y + (Length / 2) - 1, "\0");
                Y--;
                Print();
            }
        }

        public void Down()
        {
            if (Y + 1 + (Length / 2) != boardHeight + 2)
            {
                p.Print(X, Y - (Length / 2), "\0");
                Y++;
                Print();
            }
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = Y - (Length / 2); i < Y + (Length / 2); i++)
            {
                p.Print(X, i, "|");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
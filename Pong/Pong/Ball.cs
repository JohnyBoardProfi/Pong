using System;

namespace Pong
{
    class Ball
    {
        public int X { get; set; }

        public int Y { get; set; }

        int rX, rY, boardHeight, boardWidth;
        Printer p = new Printer();

        public int Direction { get; set; }

        public Ball(int x, int y, int boardHeight, int boardWidth)
        {
            X = x;
            Y = y;
            this.boardHeight = boardHeight;
            this.boardWidth = boardWidth;
            rX = -1;
            rY = 1;
        }

        public void Rules(Paddle p1, Paddle p2)
        {
            p.Print(X, Y, "\0");
            if (Y <= 1 || Y >= boardHeight)
            {
                rY *= -1;
            }
            if (((X == 3 || X == boardWidth - 3) && (p1.Y - (p1.Length / 2)) <= Y && (p1.Y + (p1.Length / 2)) > Y))
            {
                rX *= -1;
                if (Y == p1.Y)
                {
                    Direction = 0;
                }
                if ((Y >= (p1.Y - (p1.Length / 2)) && Y < p1.Y) || (Y > p1.Y && Y < (p1.Y + (p1.Length / 2))))
                {
                    Direction = 1;
                }
            }
            switch(Direction)
            {
                case 0:
                    X += rX;
                    break;
                case 1:
                    X += rX;
                    Y += rY;
                    break;
            }
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            p.Print(X, Y, "■");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
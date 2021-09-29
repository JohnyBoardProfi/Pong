using System;
using System.Threading;

namespace Pong
{
    public class Pong
    {
        int width, height;
        Board board;
        Paddle p1, p2;
        ConsoleKeyInfo keyInfo;
        ConsoleKey consoleKey;
        Ball ball;

        public Pong(int width, int height)
        {
            this.width = width;
            this.height = height;
            board = new Board(width, height);
            ball = new Ball(width / 2, height / 2, height, width);
        }

        public void Setup()
        {
            p1 = new Paddle(2, height);
            p2 = new Paddle(width - 2, height);
            keyInfo = new ConsoleKeyInfo();
            consoleKey = new ConsoleKey();
            ball.X = width / 2;
            ball.Y = height / 2;
            ball.Direction = 0;

        }

        void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;
            }
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Setup();
                board.Print();
                p1.Print();
                p2.Print();
                ball.Print();
                while (ball.X != 1 && ball.X != width - 1)
                {
                    Input();
                    switch(consoleKey)
                    {
                        case ConsoleKey.W:
                            p1.Up();
                            p2.Up();
                            break;
                        case ConsoleKey.S:
                            p1.Down();
                            p2.Down();
                            break;
                    }
                    consoleKey = ConsoleKey.A;
                    ball.Rules(p1, p2);
                    ball.Print();
                    Thread.Sleep(100);
                }
            }
        }
    }
}
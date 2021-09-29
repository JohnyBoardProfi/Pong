using System;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Pong pong = new Pong(60, 20);
            pong.Run();
            Console.ReadKey();
        }
    }
}
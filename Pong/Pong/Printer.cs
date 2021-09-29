using System;

namespace Pong
{
    public class Printer
    {
        public void Print(int a, int b, string c)
        {
            Console.SetCursorPosition(a, b);
            Console.Write(c);            
        }
    }
}
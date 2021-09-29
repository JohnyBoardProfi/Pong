namespace Pong
{
    public class Board
    {
        Printer p = new Printer();

        public int Height { get; set; }

        public int Width { get; set; }

        public Board()
        {
            Height = 20;
            Width = 60;
        }

        public Board(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Print()
        {
            for (int i = 1; i <= Width; i++)
            {
                p.Print(i, 0, "-");
            }
            for (int i = 1; i <= Width; i++)
            {
                p.Print(i, Height + 1, "-");
            }
            for (int i = 1; i <= Height; i++)
            {
                p.Print(0, i, "|");
            }
            for (int i = 1; i <= Height; i++)
            {
                p.Print(Width + 1, i, "|");
            }
            p.Print(0, 0, "┌");
            p.Print(Width + 1, 0, "┐");
            p.Print(0, Height + 1, "└");
            p.Print(Width + 1, Height + 1, "┘");
        }
    }
}
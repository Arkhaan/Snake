using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 20;
            int height = 20;
            Console.WriteLine("Ssssssnake");
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == 0 || x == width - 1)
                    {
                        Console.Write("#");
                    }
                    else if (y == 0 || y == height - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}

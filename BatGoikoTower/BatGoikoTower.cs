using System;

class BatGoikoTower
{
    static void Main()
    {
        int H = int.Parse(Console.ReadLine());
        int width = H * 2;
        for (int i = 1; i <= H; i++)
        {
            Console.Write(new string('.', H - i));
            Console.Write('/');
            if (i == 2 || i == 4 || i == 7 || i == 11 || i == 16 || i == 22 || i == 29 || i == 37)
            {
                Console.Write(new string('-', (width - 2 * (H - i) - 2)));
            }
            else
            {
                Console.Write(new string('.', (width - 2 * (H - i) - 2)));
            }
            Console.Write('\\');
            Console.Write(new string('.', H - i));
            Console.WriteLine();
        }
    }
}

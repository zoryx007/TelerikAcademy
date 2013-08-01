using System;

class Garden
{
    static void Main()
    {
        int tomatoAmount = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberAmount = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoAmount = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotAmount = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageAmount = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansAmount = int.Parse(Console.ReadLine());

        int totalArea = 250;
        int beansArea = totalArea - tomatoArea - cucumberArea - potatoArea - carrotArea - cabbageArea;
        decimal totalCosts = (tomatoAmount * 0.5m) + (cucumberAmount * 0.4m) + (potatoAmount * 0.25m) + (carrotAmount * 0.6m) + (cabbageAmount * 0.3m) + (beansAmount * 0.4m);
        Console.WriteLine("Total costs: {0:F2}", totalCosts);

        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (beansArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else if (beansArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}

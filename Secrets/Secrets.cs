using System;

class Secrets
{
    static void Main()
    {
        string number = Console.ReadLine();
        int specialSum = 0;
        for (int i = (number.Length - 1); i >= 0; i = i - 2)
        {
            char odd = number[i];
            int oddInt = (int)Char.GetNumericValue(odd);
            int positionOdd = number.Length - i;
            specialSum += oddInt * (positionOdd * positionOdd);
        }
        for (int j = (number.Length - 2); j >= 0; j = j - 2)
		{
			char even = number[j];
            int evenInt = (int)Char.GetNumericValue(even);
            int positionEven = number.Length - j;
            specialSum += (evenInt * evenInt) * positionEven;
		}
        Console.WriteLine(specialSum);

        int alphaLength = specialSum % 10;
        if (alphaLength == 0)
        {
            Console.WriteLine(number + " has no secret alpha-sequence");
        }
        else
        {
            int R = specialSum % 26;

            for (int k = R + 1; k <= alphaLength + R; k++)
            {
                int unicode = k + 64;

                if (unicode > 90)
                {
                    unicode = unicode - 26;
                }
                char symbol = (char)unicode;
                string text = symbol.ToString();
                Console.Write(symbol);
            }
        }
        Console.WriteLine();
    }
}

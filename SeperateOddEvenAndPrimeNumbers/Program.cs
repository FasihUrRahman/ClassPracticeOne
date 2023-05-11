using System;

int primeValue, i, j, k, intialValue;
Console.WriteLine("Here are Odd | Even | Prime Numbers");
primeValue = i = k = intialValue =0;
while (i <= 10)
{
    j = 2;
    k = 0;
    while (j <= i / 2)
    {

        if (i % j == 0)
        {
            k = 1;
        }
        j++;
    }
    if (k == 0)
        primeValue = i;

    if (i % 2 == 0)
    {
        Console.WriteLine($"Value Is   {i} |      | {primeValue}");
    }
    else
    {
        Console.WriteLine($"Value Is     |   {i}  | {primeValue}");
    }
    i++;
}
Console.ReadLine();
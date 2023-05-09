float inputValueOne, inputValueTwo, actionPerform;
Console.WriteLine("\tCalculator");
Console.Write("Enter First Input: ");
inputValueOne = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter Second Input: ");
inputValueTwo = Convert.ToSingle(Console.ReadLine());
Console.Write("Select Action You Willing To Perform:\n 1 - Plus\n 2 - Minus\n 3 - Multiply\n 4 - Divide\n 5 - Remainder\n>>");
actionPerform = Convert.ToSingle(Console.ReadLine());
switch (actionPerform)
{
    case 1:
        Console.WriteLine($"{inputValueOne} + {inputValueTwo} = {inputValueOne + inputValueTwo}");
        break;
    case 2:
        Console.WriteLine($"{inputValueOne} - {inputValueTwo} = {inputValueOne - inputValueTwo}");
        break;
    case 3:
        Console.WriteLine($"{inputValueOne} x {inputValueTwo} = {inputValueOne * inputValueTwo}");
        break;
    case 4:
        Console.WriteLine($"{inputValueOne} / {inputValueTwo} = {inputValueOne / inputValueTwo}");
        break;
    case 5:
        Console.WriteLine($"{inputValueOne} % {inputValueTwo} = {inputValueOne % inputValueTwo}");
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}
Console.ReadLine();

Console.WriteLine("\"Hello World\"");
Console.ReadLine();
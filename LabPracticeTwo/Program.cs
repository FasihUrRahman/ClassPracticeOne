int inputValue, i = 1; //Variables
Console.WriteLine("\tTable Generator"); //Title Message
Console.Write("Enter a Number To Generate Table: ");    //Input Message
inputValue = Convert.ToInt32(Console.ReadLine());   //Input
//Loop Start
while (i <= 10)
{
    Console.WriteLine($"{inputValue} x {i} = {inputValue * i}");    //Result
    i++;    //Increment
}
//Loop End
Console.ReadLine();
//Variables
int inputValue;
string? startingValue;
//Do While Start
do {
    Console.Write("Enter a Number: ");  //Input Message
    inputValue = Convert.ToInt32(Console.ReadLine());   //Int Input
    if (inputValue % 2 == 0)    //Condition Check
    {
        Console.WriteLine($"This {inputValue} is Even");
    }
    else
        Console.WriteLine($"This {inputValue} is Odd");
    Console.Write("You Have Any Other Input to Check(Y/N): ");  //Message For ReStart Loop
    startingValue = Console.ReadLine().ToUpper() ?? "N";    //Input For Restart Loop
}
while (startingValue == "Y");   //While Condition
//Variables
string? msg;
int operationSelection;
bool isCountinue = true;

//Loop To Start Again And Again
while (isCountinue)
{
    Console.WriteLine("What Action You Willing To Perform\n1 - Count Charecters in String\n2 - Reverse String\n3 - Count Vowels\n4 - Exit");
    Console.Write(">>");
    operationSelection = Convert.ToInt32(Console.ReadLine());   //Input To Action Perform
    if (operationSelection == 1 || operationSelection == 2 || operationSelection == 3)
    {
        Console.WriteLine("Write String or Message");
        Console.Write(">>");
        msg = Console.ReadLine();   //Input Message
        if (msg != "")
        {
            switch (operationSelection)
            {
                case 1:
                    CountChar(msg); //Count Characters In String
                    Console.Clear();
                    break;
                case 2:
                    ReverseString(msg); //Reverse The String
                    Console.Clear();
                    break;
                case 3:
                    CountStringVowels(msg); //Count Vowels in String
                    Console.Clear();
                    break;
            }
        }
        else
            continue;
    }
    else if (operationSelection == 4)
    {
        isCountinue = false;
    }
    else
    {
        Console.WriteLine("Invalid Selection");
        Console.ReadLine();
        Console.Clear();
    }
}

//Count Numbers
static void CountChar(string stringValue)
{
    int digitValue = 0, alphabatValue = 0, specialCharValue = 0;
    foreach (char item in stringValue)
    {
        if (char.IsDigit(item))
        {
            digitValue++;
        }
        else if(char.IsLetter(item))
        {
            alphabatValue++;
        }
        else
        {
            specialCharValue++;
        }
    }
    Console.WriteLine($"Special Charters in This String Is/Are \"{specialCharValue}\"\nAlphabetic Charters in This String Is/Are \"{alphabatValue}\"\nDigit Charters in This String Is/Are \"{digitValue}\"");
    Console.ReadLine();
}



//Functions
//Reverse String
static void ReverseString(string stringValue)
{
    string[] newString = new string[stringValue.Length]; ;
    int j = 0;
    for (int i = stringValue.Length - 1; i >= 0; i--)
    {
        newString[j] = Convert.ToString(stringValue[i]);
        j++;
    }
    for (int i = 0; i < stringValue.Length; i++)
    {
        Console.Write(newString[i]);
    }
    Console.ReadLine();
}
//Count Vowels
static void CountStringVowels(string stringValue)
{
    int stringLen = stringValue.Length;
    int vowelAInString = 0, vowelEInString = 0, vowelIInString = 0, vowelOInString = 0, vowelUInString = 0, nonVowels = 0;
    for (int i = 0; i < stringLen; i++)
    {
        if (stringValue[i] == 'a' || stringValue[i] == 'A')
            vowelAInString++;
        else if (stringValue[i] == 'e' || stringValue[i] == 'E')
            vowelEInString++;
        else if (stringValue[i] == 'i' || stringValue[i] == 'I')
            vowelIInString++;
        else if (stringValue[i] == 'o' || stringValue[i] == 'O')
            vowelOInString++;
        else if (stringValue[i] == 'u' || stringValue[i] == 'U')
            vowelUInString++;
        else
            nonVowels++;
    }
    Console.WriteLine($"In This String \"{stringValue}\"\nVowel A is Used \"{vowelAInString}\"\nVowel E is Used \"{vowelEInString}\"\nVowel I is Used \"{vowelIInString}\"\nVowel O is Used \"{vowelOInString}\"\nVowel U is Used \"{vowelUInString}\"\nNonVowels Are Used \"{nonVowels}\"");
    Console.ReadLine();
}
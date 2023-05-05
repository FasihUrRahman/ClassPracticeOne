using System.Xml.Linq;
//Variables
float weightInput, weightOutputInPond, weightOutputInMiligram, weightOutputInGram, weightOutputInKilogram, weightOutputInTonne;
decimal weightOutputInTonneDecimal;
string weightSelectionValue, continueCode;
dynamic weightInputDynamic;
char weightSelection;
//Loop For Reuse
do
{
    Console.Write("Enter The Weight: ");    //getting input
    weightInputDynamic = Console.ReadLine();
    //Loop For Empty Input
    while (string.IsNullOrEmpty(weightInputDynamic)) {
        Console.WriteLine("Name can't be empty! Input your name once more: ");
        weightInputDynamic = Console.ReadLine();
    }
    bool parseSuccess = float.TryParse(weightInputDynamic, out weightInput);    //Check The Value is a Number or a Alphabatic Value and Assigning Value to weightInput
    //Condition For Check If the Value is Number
    if (parseSuccess)
    {
        Console.WriteLine("Select Unit");
        Console.WriteLine("A)Pond\t B)Miligram\t C)Gram\t D)Kilogaram\t E)Tonne");
        Console.Write("Select An Option: ");    //Input For Selecting an Option
        weightSelectionValue = Console.ReadLine();
        weightSelection = weightSelectionValue[0];

        //Cases According to Selection
        switch (char.ToLower(Convert.ToChar(weightSelection)))
        {
            case 'a':
                //Code
                weightOutputInPond = weightInput;
                weightOutputInMiligram = weightInput * 453592;
                weightOutputInGram = weightInput * 453.592f;
                weightOutputInKilogram = weightInput * 0.453592f;
                weightOutputInTonneDecimal = Convert.ToDecimal(weightInput) * 0.000453592m;
                Console.WriteLine($"The Weight You Entered is in Ponds {weightOutputInPond}");
                Console.WriteLine($"The Weight You Entered is in Miligram {weightOutputInMiligram}");
                Console.WriteLine($"The Weight You Entered is in Gram {weightOutputInGram}");
                Console.WriteLine($"The Weight You Entered is in Kilogram {weightOutputInKilogram}");
                Console.WriteLine($"The Weight You Entered is in Tonne {weightOutputInTonneDecimal}");
                break;
            case 'b':
                //Code
                weightOutputInPond = weightInput * 0.000002f;
                weightOutputInMiligram = weightInput;
                weightOutputInGram = weightInput * 0.001f;
                weightOutputInKilogram = weightInput * 0.000001f;
                weightOutputInTonneDecimal = Convert.ToDecimal(weightInput) * 0.0000000001m;
                Console.WriteLine($"The Weight You Entered is in Ponds {weightOutputInPond}");
                Console.WriteLine($"The Weight You Entered is in Miligram {weightOutputInMiligram}");
                Console.WriteLine($"The Weight You Entered is in Gram {weightOutputInGram}");
                Console.WriteLine($"The Weight You Entered is in Kilogram {weightOutputInKilogram}");
                Console.WriteLine($"The Weight You Entered is in Tonne {weightOutputInTonneDecimal}");
                break;
            case 'c':
                //Code
                weightOutputInPond = weightInput * 0.00220462f;
                weightOutputInMiligram = weightInput * 1000;
                weightOutputInGram = weightInput;
                weightOutputInKilogram = weightInput * 0.001f;
                weightOutputInTonneDecimal = Convert.ToDecimal(weightInput) * 0.000001m;
                Console.WriteLine($"The Weight You Entered is in Ponds {weightOutputInPond}");
                Console.WriteLine($"The Weight You Entered is in Miligram {weightOutputInMiligram}");
                Console.WriteLine($"The Weight You Entered is in Gram {weightOutputInGram}");
                Console.WriteLine($"The Weight You Entered is in Kilogram {weightOutputInKilogram}");
                Console.WriteLine($"The Weight You Entered is in Tonne {weightOutputInTonneDecimal}");
                break;
            case 'd':
                //Code
                weightOutputInPond = weightInput * 2.20462f;
                weightOutputInMiligram = weightInput * 100000;
                weightOutputInGram = weightInput * 1000;
                weightOutputInKilogram = weightInput;
                weightOutputInTonne = weightInput * 0.001f;
                Console.WriteLine($"The Weight You Entered is in Ponds {weightOutputInPond}");
                Console.WriteLine($"The Weight You Entered is in Miligram {weightOutputInMiligram}");
                Console.WriteLine($"The Weight You Entered is in Gram {weightOutputInGram}");
                Console.WriteLine($"The Weight You Entered is in Kilogram {weightOutputInKilogram}");
                Console.WriteLine($"The Weight You Entered is in Tonne {weightOutputInTonne}");
                break;
            case 'e':
                //Code
                weightOutputInPond = weightInput * 2204.62f;
                weightOutputInMiligram = weightInput * 100000000;
                weightOutputInGram = weightInput * 100000;
                weightOutputInKilogram = weightInput * 1000;
                weightOutputInTonne = weightInput;
                Console.WriteLine($"The Weight You Entered is in Ponds {weightOutputInPond}");
                Console.WriteLine($"The Weight You Entered is in Miligram {weightOutputInMiligram}");
                Console.WriteLine($"The Weight You Entered is in Gram {weightOutputInGram}");
                Console.WriteLine($"The Weight You Entered is in Kilogram {weightOutputInKilogram}");
                Console.WriteLine($"The Weight You Entered is in Tonne {weightOutputInTonne}");
                break;
            default:
                Console.WriteLine("Please Select From Given Options");
                break;
        }
    }
    else
    {
        Console.WriteLine("This is not a number!"); //Values If User Put An Elphabatic Value
    }

    Console.Write("For More Conversion Hit 'y' and Enter....");
    continueCode = Console.ReadLine();  //Value For ReStarting Code
}

while ((continueCode.ToLower()) == "y");
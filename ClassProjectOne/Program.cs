//Project No.1 (Get Day's Name by Number)
int inputForDayCheck;

Console.Write("Enter Number To Check Day Name(1-7): ");
inputForDayCheck = Convert.ToInt32(Console.ReadLine());
//Condition Check With If Else Statement
if (inputForDayCheck == 1)
{
    Console.WriteLine($"You Select {inputForDayCheck}. It Store's Monday. Answer Show's With IF Else");
}
else if (inputForDayCheck == 2)
{
    Console.WriteLine($"You Select {inputForDayCheck}. It Store's Tuesday. Answer Show's With IF Else");
}
else if (inputForDayCheck == 3)
{
    Console.WriteLine($"You Select {inputForDayCheck}. It Store's Wednesday. Answer Show's With IF Else");
}
else if (inputForDayCheck == 4)
{
    Console.WriteLine($"You Select {inputForDayCheck}. It Store's Thursday. Answer Show's With IF Else");
}
else if (inputForDayCheck == 5)
{
    Console.WriteLine($"You Select {inputForDayCheck}. It Store's Friday. Answer Show's With IF Else");
}
else if (inputForDayCheck == 6)
{
    Console.WriteLine($"You Select {inputForDayCheck}. It Store's Saturday. Answer Show's With IF Else");
}
else if (inputForDayCheck == 7)
{
    Console.WriteLine($"You Select {inputForDayCheck}. It Store's Sunday. Answer Show's With IF Else");
}
else
{
    Console.WriteLine("Invalid Input. Answer Show's With IF Else");
}
Console.WriteLine("----------------------------------------");
//Condition Check With Switch Case Statement
switch (inputForDayCheck)
{
    case 1:
        Console.WriteLine($"You Select {inputForDayCheck}. It Store's Monday. Answer Show's With Switch Case");
        break;
    case 2:
        Console.WriteLine($"You Select {inputForDayCheck}. It Store's Tuesday. Answer Show's With Switch Case");
        break;
    case 3:
        Console.WriteLine($"You Select {inputForDayCheck}. It Store's Wednesday. Answer Show's With Switch Case");
        break;
    case 4:
        Console.WriteLine($"You Select {inputForDayCheck}. It Store's Thursday. Answer Show's With Switch Case");
        break;
    case 5:
        Console.WriteLine($"You Select {inputForDayCheck}. It Store's Friday. Answer Show's With Switch Case");
        break;
    case 6:
        Console.WriteLine($"You Select {inputForDayCheck}. It Store's Saturday. Answer Show's With Switch Case");
        break;
    case 7:
        Console.WriteLine($"You Select {inputForDayCheck}. It Store's Sunday. Answer Show's With Switch Case");
        break;
    default:
        Console.WriteLine("Invalid Input. Answer Show's With Switch Case");
        break;
}
Console.WriteLine("----------------------------------------");

//Project No.2(Check The Menu Items)
int inputForItem;
Console.Write("Select A Number To Check Dish(1-4): ");
inputForItem = Convert.ToInt32(Console.ReadLine());
//Condition Check With If Else Statement
if (inputForItem == 1)
{
    Console.WriteLine("The First Item is Malai Boti Pizza. This Answer is From If Else");
}
else if (inputForItem == 2)
{
    Console.WriteLine("The First Item is Flamed Pizza. This Answer is From If Else");
}
else if (inputForItem == 3)
{
    Console.WriteLine("The First Item is Smoked Pizza. This Answer is From If Else");
}
else if (inputForItem == 4)
{
    Console.WriteLine("The First Item is Arabic Pizza. This Answer is From If Else");
}
else
{
    Console.WriteLine("Invalid Input. This Answer is From If Else");
}
Console.WriteLine("----------------------------------------");
//Condition Check With Switch Case Statement
switch (inputForItem)
{
    case 1:
        Console.WriteLine("The First Item is Malai Boti Pizza. This Answer is From Switch Case");
        break;
    case 2:
        Console.WriteLine("The First Item is Flamed Pizza. This Answer is From Switch Case");
        break;
    case 3:
        Console.WriteLine("The First Item is Smoked Pizza. This Answer is From Switch Case");
        break;
    case 4:
        Console.WriteLine("The First Item is Arabic Pizza. This Answer is From Switch Case");
        break;
    default:
        Console.WriteLine("Invalid Input. This Answer is From Switch Case");
        break;
}
Console.WriteLine("----------------------------------------");
//Example Program
int inputValueForDaySelection;
Console.WriteLine("Select A Day To Check Menu For That Day(1-7): ");
Console.WriteLine("1 - Monday\n2 - Tuesday\n3 - Wednesday\n4 - Thursday\n5 - Friday\n6 - Saturday\n7 - Sunday");
Console.Write(">>");
inputValueForDaySelection = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Today's Menu");
if (inputValueForDaySelection == 1)
{
    Console.WriteLine("1 - One Grapefruit\n2 - Two poached eggs\n3 - One slice wheat toast");
}
else if (inputValueForDaySelection == 2) {
    Console.WriteLine("1 - One wheat muffin with 2 tablespoons peanut butter\n2 - One orange");
}
else if(inputValueForDaySelection == 3)
{
    Console.WriteLine("1 - Oats\n2 - One fresh pear\n3 - One almonds");
}
else if (inputValueForDaySelection == 4)
{
    Console.WriteLine("1 - Two slices wheat toast with 2 tablespoons peanut butter\n2 - One banana");
}
else if(inputValueForDaySelection == 5)
{
    Console.WriteLine("1 - One wheat bagel\n2 - Three tablespoons cream cheese");
}
else if(inputValueForDaySelection == 6)
{
    Console.WriteLine("1 - One container Greek yogurt\n2 - One banana\n3 - One hard-boiled egg");
}
else if(inputValueForDaySelection == 7)
{
    Console.WriteLine("1 - One cup cooked oatmeal\n2 - Half cup blueberries\n3 - Half cup non-fat milk\n4 - Two tablespoons almond butter\n");
}
else
{
    Console.WriteLine("Invalid Input");
}
Console.ReadLine();
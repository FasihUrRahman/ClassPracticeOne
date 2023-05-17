//Find KeyWord In A Sentence
//Variables
string? inputValue, keywordToFind;
int[] keyWordsFound = new int[20];
int keywordPosition = 0, arrayIndexPosition = 0;
//Getting Values From User
Console.WriteLine("Enter Your Messages Here");
Console.Write(">>");
inputValue = Console.ReadLine();
Console.Write("Enter The Keyword You are Looking For: ");
keywordToFind = Console.ReadLine();


for (int i = 0; i < inputValue.Length; i++)
{
    if (inputValue.IndexOf(keywordToFind, i) == i)
    {
        Console.WriteLine($"{keywordToFind} is Available at {i}");
    }
}


//If The User Gives Both Values
//if (keywordToFind != "" && inputValue != "")
//{
//    for (int i = keywordPosition; i < inputValue.Length; i++)
//    {
//        if (inputValue[i] == keywordToFind[0])
//        {
//            keyWordsFound[arrayIndexPosition] = inputValue.IndexOf(keywordToFind, i);
//            keywordPosition = i++;
//            arrayIndexPosition++;
//        }
//    }
//}
//else
//{
//    Console.WriteLine("Please Input Value First");
//}


//for(int i = 0; i < keyWordsFound.Length; i++)
//{
//    if (keyWordsFound[i] == 0 && i !=0)
//    {
//        break;
//    }
//    else 
//    {
//        Console.WriteLine($"{keywordToFind} This Keyword is Found {keyWordsFound[i]}");
//    }
//}

Console.ReadLine();


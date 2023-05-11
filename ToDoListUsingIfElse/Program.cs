//Variables
string? inputValue,inputValue1 = null, inputValue2 = null, inputValue3 = null, inputValue4 = null;
bool isContinue = true;
int selectionToDo;

//Code Start
while (isContinue)
{
    Console.WriteLine("\tToDo List");   //Title Program
    Console.WriteLine("1 - Add Item in List\n2 - Delete Item in List\n3 - Display List\n4 - Exit"); //Options To Select
    Console.Write(">>");
    selectionToDo = Convert.ToInt32(Console.ReadLine());    //Input For Options
    switch (selectionToDo)
    {
        //Add Item
        case 1:
            int inputValueForGiveInput;
            bool isContinue1 = true;
            Console.WriteLine("Select an option:\n1 - Input Value\n2 - back");  //Options For Input
            Console.Write(">>");
            inputValueForGiveInput = Convert.ToInt32(Console.ReadLine());   //Input For Add Item Or Go Back
            //Loop For Add Multiple Messages
            while (isContinue1)
            {
                switch (inputValueForGiveInput)
                {
                    case 1:
                        Console.Write("Input a Message: ");
                        inputValue = Console.ReadLine();    //Message1
                        if (inputValue1 == " " || inputValue1 == null)
                        {
                            inputValue1 = inputValue;
                            Console.WriteLine("item is add successfully");
                            Console.Write("Enter Any Key To Continue...");
                            Console.ReadKey();
                        }
                        else if (inputValue2 == " " || inputValue2 == null) {
                            inputValue2 = inputValue;
                            Console.WriteLine("item is add successfully");
                            Console.Write("Enter Any Key To Continue...");
                            Console.ReadKey();
                        }
                        else if (inputValue3 == " " || inputValue3 == null) {
                            inputValue3 = inputValue;
                            Console.WriteLine("item is add successfully");
                            Console.Write("Enter Any Key To Continue...");
                            Console.ReadKey();
                        }
                        else if (inputValue4 == " " || inputValue4 == null) {
                            inputValue4 = inputValue;
                            Console.WriteLine("item is add successfully");
                            Console.Write("Enter Any Key To Continue...");
                            Console.ReadKey();
                        }
                        else { 
                            Console.WriteLine("Please Delete a Query");
                            Console.Write("Enter Any Key To Continue...");
                            Console.ReadKey();
                        }
                        isContinue1 = false;    //Loop End For Input
                        Console.Clear();
                        break;
                    default:
                        isContinue1 = false;
                        Console.Clear();
                        break;
                }
            }
            break;
        //Delete Input Values
        case 2:
            Console.WriteLine($"1 - {inputValue1}\n2 - {inputValue2}\n3 - {inputValue3}\n4 - {inputValue4}");
            Console.Write("Input a Number For Delete Query(1-4): ");
            inputValue = Console.ReadLine();    //Input For Delete Value
            switch (inputValue)
            {
                case "1":
                    inputValue1 = null;
                    Console.WriteLine("item is Delete successfully");
                    Console.Write("Enter Any Key To Continue...");
                    Console.ReadKey();
                    break;
                case "2":
                    inputValue2 = null;
                    Console.WriteLine("item is Delete successfully");
                    Console.Write("Enter Any Key To Continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    inputValue3 = null;
                    Console.WriteLine("item is Delete successfully");
                    Console.Write("Enter Any Key To Continue...");
                    Console.ReadKey();
                    break;
                case "4":
                    inputValue4 = null;
                    Console.WriteLine("item is Delete successfully");
                    Console.Write("Enter Any Key To Continue...");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Number");
                    Console.Write("Enter Any Key To Continue...");
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
            break;
        //Display Messages
        case 3:
            Console.WriteLine(inputValue1);
            Console.WriteLine(inputValue2);
            Console.WriteLine(inputValue3);
            Console.WriteLine(inputValue4);
            Console.Write("Enter Any Key To Continue...");
            Console.ReadKey();
            Console.Clear();
            break;
        //Quit Code
        case 4:
            isContinue = false; 
            break;
        default:
            Console.WriteLine("Please Enter A Valid Number");
            Console.Write("Enter Any Key To Continue...");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}
Console.ReadLine();

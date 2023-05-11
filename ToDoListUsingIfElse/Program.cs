string? inputValue,inputValue1 = null, inputValue2 = null, inputValue3 = null, inputValue4 = null;
bool isContinue = true, isFirst = true;
int selectionToDo;

while (isContinue)
{
    Console.WriteLine("\tToDo List");
    Console.WriteLine("1 - Add Item in List\n2 - Delete Item in List\n3 - Display List\n4 - Exit");
    Console.Write(">>");
    selectionToDo = Convert.ToInt32(Console.ReadLine());
    switch (selectionToDo)
    {
        case 1:
            int inputValueForGiveInput;
            bool isContinue1 = true;
            Console.WriteLine("Select an option:\n1 - Input Value\n2 - back");
            inputValueForGiveInput = Convert.ToInt32(Console.ReadLine());
            while (isContinue1)
            {
                switch (inputValueForGiveInput)
                {
                    case 1:
                        Console.Write("Input a Message: ");
                        inputValue = Console.ReadLine();
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
                        isContinue1 = false;
                        Console.Clear();
                        break;
                    default:
                        isContinue1 = false;
                        Console.Clear();
                        break;
                }
            }
            break;
        case 2:
            Console.Write("Input a Number For Delete Query(1-4): ");
            inputValue = Console.ReadLine();
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
        case 3:
            Console.WriteLine(inputValue1);
            Console.WriteLine(inputValue2);
            Console.WriteLine(inputValue3);
            Console.WriteLine(inputValue4);
            Console.Write("Enter Any Key To Continue...");
            Console.ReadKey();
            Console.Clear();
            break;
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

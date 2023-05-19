//Budling Time Table
//Variables
int year, month, day;
DateTime dt;
string dayName;
//Code
//Getting Input From User
//Start
Console.WriteLine("Enter Date To Check Time Table");
Console.Write("Year(yyyy)>>");
year = Convert.ToInt32(Console.ReadLine());
Console.Write("Months(mm)>>");
month = Convert.ToInt32(Console.ReadLine());
Console.Write("Day(dd)>>");
day = Convert.ToInt32(Console.ReadLine());
//End
//Giving Data To check The day
//Start
dt = new DateTime(year, month, day);
dayName = dt.ToString("dddd");
//End
Console.Clear();
//Check The Secdule According to Condition
//Start
if(dt !< DateTime.Now)
{
    if (dayName == "Sunday")
    {
        Console.WriteLine("Today's Menu is\nBreakFast\tAlo Bhujiya, Paratha With Tea\nLunch\tSabzi With Bread\nDinner\tDaal Chawal With Achar");
    }
    else if (dayName == "Monday")
    {
        Console.WriteLine("Today's Menu is\nBreakFast\tOmelet, Paratha with Tea\nLunch\tChicken Biryani\nDinner\tDaal Chana With Bread and Sweet");
    }
    else if (dayName == "Tuesday")
    {
        Console.WriteLine("Today's Menu is\nBreakFast\tAnda Chana, Paratha with Tea\nLunch\tSabzi, Bread with Achar\nDinner\tChicken With Bread");
    }
    else if (dayName == "Wednesday")
    {
        Console.WriteLine("Today's Menu is\nBreakFast\tAlo Bhujiya, Paratha with Tea\nLunch\tSabzi Palao\nDinner\tDaal Mash with Bread");
    }
    else if (dayName == "Thursday")
    {
        Console.WriteLine("Today's Menu is\nBreakFast\tChaany, Paratha with Tea\nLunch\tChicken Korma\nDinner\tSabzi With Bread");
    }
    else if (dayName == "Friday")
    {
        Console.WriteLine("Today's Menu is\nBreakFast\tDaal Chana, Paratha with Tea\nLunch\tChana Chawal\nDinner\tChicken Polao");
    }
    else
    {
        Console.WriteLine("Today's Menu is\nBreakFast\tHalwa Chana, Paratha with Tea\nLunch\tAlo Chawal\nDinner\tAlo Chicken Kima");
    }
}
else
{
    Console.WriteLine("Bro Seriously You Willing to Know Past Menu!");
}
//End
Console.ReadLine();
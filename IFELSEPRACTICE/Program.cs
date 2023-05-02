int english, urdu, islamicStudies, pakStudies, sumOfAllSubjects; //Variables for input values
string e, u, i, p,s; //Variables for pass or fail
Console.Write("Enter Marks of English(1-100):");
english = Convert.ToInt32(Console.ReadLine());  //Input for English Marks
Console.Write("Enter Marks of Urdu(1-100):");
urdu = Convert.ToInt32(Console.ReadLine()); //input for Urdu Marks
Console.Write("Enter Marks of Islamic Studies(1-100):");
islamicStudies = Convert.ToInt32(Console.ReadLine());   //input for Islamic Studies Marks
Console.Write("Enter Marks of Pak Studies(1-100):");
pakStudies = Convert.ToInt32(Console.ReadLine());   //input For Pak Studies Marks
sumOfAllSubjects = english+urdu+islamicStudies+pakStudies;  //sum of all marks
if (english < 30)   //Condition for English
{
    e = "F";
}
else
{
    e = "P";
}
if (urdu < 30)  //Condition for Urdu
{
    u = "F";
}
else
{
    u = "P";
}
if (islamicStudies < 30)    //Condition For Islamic Studies
{
    i = "F";
}
else
{
    i = "P";
}
if (pakStudies < 30)    //Condition For Pak Studies
{
    p = "F";
}
else
{
    p = "P";
}
if (english > 30 && urdu > 30 && islamicStudies > 30 && pakStudies > 30) // Condition for all subjects pass
{
    s = "P";
}
else{
    s = "F";
}
Console.WriteLine("Your Obtained Marks are Below"); //Result of Marks
Console.WriteLine(" English     |   Obtained Marks    |   Pass Or Fail");
Console.WriteLine(" English     |   " + english + "                |   " + e);
Console.WriteLine(" Urdu        |   " + urdu + "                |   " + u);
Console.WriteLine(" Islamic     |   " + islamicStudies + "                |   " + i);
Console.WriteLine(" PakStudies  |   " + pakStudies + "                |   " + p);
Console.WriteLine("__________________________________");
Console.WriteLine(" TotalMarks  |   " + sumOfAllSubjects + "               |   " + s);
Console.Write("Press Any Key To exit...."); //Ending Message
Console.ReadKey();
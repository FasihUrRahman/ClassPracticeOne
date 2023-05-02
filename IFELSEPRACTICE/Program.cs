int english, urdu, islamicStudies, pakStudies, sumOfAllSubjects;
string e, u, i, p,s;
Console.Write("Enter Marks of English(1-100):");
english = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Marks of Urdu(1-100):");
urdu = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Marks of Islamic Studies(1-100):");
islamicStudies = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Marks of Pak Studies(1-100):");
pakStudies = Convert.ToInt32(Console.ReadLine());
sumOfAllSubjects = english+urdu+islamicStudies+pakStudies;
if (english < 30)
{
    e = "F";
}
else
{
    e = "P";
}
if (urdu < 30)
{
    u = "F";
}
else
{
    u = "P";
}
if (islamicStudies < 30)
{
    i = "F";
}
else
{
    i = "P";
}
if (pakStudies < 30)
{
    p = "F";
}
else
{
    p = "P";
}
if (english > 30 && urdu > 30 && islamicStudies > 30 && pakStudies > 30) 
{
    s = "P";
}
else{
    s = "F";
}
Console.WriteLine("Your Obtained Marks are Below");
Console.WriteLine(" English     |   Obtained Marks    |   Pass Or Fail");
Console.WriteLine(" English     |   " + english + "                |   " + e);
Console.WriteLine(" Urdu        |   " + urdu + "                |   " + u);
Console.WriteLine(" Islamic     |   " + islamicStudies + "                |   " + i);
Console.WriteLine(" PakStudies  |   " + pakStudies + "                |   " + p);
Console.WriteLine("__________________________________");
Console.WriteLine(" TotalMarks  |   " + sumOfAllSubjects + "               |   " + s);
Console.WriteLine("Press Any Key To exit....");
Console.ReadKey();
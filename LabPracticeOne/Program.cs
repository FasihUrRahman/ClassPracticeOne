//Starting of Code
Console.WriteLine("Hello, Sir!");   //Syentex for the Text Writing
Console.Write("This is Fasih Ur Rahman.");
Console.WriteLine("This is Practice For the First Time For Assignment");
Console.WriteLine("Here are some easy math solutions.");
Console.Write("120 + 160 = ");
Console.WriteLine(120 + 160); //Syentex for Number Values
Console.Write("Hit Enter Key For Next Message.....");
Console.ReadLine();

//Arthmatic Operators
Console.Write("109 + 89 = ");
Console.WriteLine(109 + 89); //Plus Operator
Console.Write("109 - 89 = ");
Console.WriteLine(109 - 89); //Minus Operator
Console.Write("109 x 89 = ");
Console.WriteLine(109 * 89); //Multiply Operator
Console.Write("109 / 89 = ");
Console.WriteLine(109 / 89); //Devide Operator
Console.Write("109 % 89 = ");
Console.WriteLine(109 % 89); //Modules Operator
Console.Write("Hit Enter Key For Next Message.....");
Console.ReadLine();
//Comparison Operators
//This will Give's Answer in Boolean
Console.WriteLine(109 > 89); //Means: 109 Greater Than 89
Console.WriteLine(109 < 89); //Means: 109 Smaller Than 89
Console.WriteLine(109 == 89); //Means: 109 Equals To 89
Console.WriteLine(109 >= 89); //Means: 109 Greater Than Or Equal To 89
Console.WriteLine(109 <= 89); //Means: 109 Smaller Than Or Equal To 89
Console.WriteLine(109 != 89); //Means: 109 Not Equal To 89
Console.Write("Hit Enter Key For Next Message.....");
Console.ReadLine();
//Logical Operators
//These Operators use to build logics. This Will Give's Answer in Boolean.
Console.WriteLine((109 > 89) && (159 < 820)); //Means: 109 Greater Than 89 AND 159 Smaller Than 820.
Console.WriteLine((109 > 89) && (159 > 820)); //Means: 109 Greater Than 89 AND 159 Greater Than 820.
Console.WriteLine((109 > 89) || (159 < 820)); //Means: 109 Greater Than 89 OR 159 Smaller Than 820.
Console.WriteLine((109 > 89) || (159 > 820)); //Means: 109 Greater Than 89 OR 159 Smaller Than 820.
Console.WriteLine((109 < 89) || (159 < 820) && (159 < 810) || !(609 > 840)); //Means: 109 Smaller Than 89 OR 159 Smaller
                                                                     //Then 820 AND 159 Smaller Than 810 OR 609
                                                                     //NOT Greater Than 840.
Console.Write("Hit Enter Key For Next Message.....");
Console.ReadLine();

string tabSpace = "\t\t\t\t"; //For Tab Spaces
string newLine = "\n"; //For new Line
string tab = "\t"; //For single tab
string heading = "Short Story(The Student)"; //Heading Line
string contentParagraph1 = "AT first the weather was fine and still. The thrushes were calling, " + "and in the swamps close by something alive droned pitifully with a sound like blowing " +
    "into an empty bottle. A snipe flew by, and the shot aimed at it rang out with a gay, resounding " +"note in the spring air. But when it began to get dark in the forest a cold, penetrating wind blew " +
    "inappropriately from the east, and everything sank into silence. Needles of ice stretched across the " +"pools, and it felt cheerless, remote, and lonely in the forest. There was a whiff of winter." + newLine + tab +
    "Ivan Velikopolsky, the son of a sacristan, and a student of the clerical academy, returning home " +"from shooting, walked all the time by the path in the water-side meadow. His fingers were numb and " +
    "his face was burning with the wind. It seemed to him that the cold that had suddenly come on had " +"destroyed the order and harmony of things, that nature itself felt ill at ease, and that was why " +
    "the evening darkness was falling more rapidly than usual. All around it was deserted and peculiarly " +"gloomy. The only light was one gleaming in the widows' gardens near the river; the village, over " +
    "three miles away, and everything in the distance all round was plunged in the cold evening mist." +" The student remembered that, as he went out from the house, his mother was sitting barefoot on " +
    "the floor in the entry, cleaning the samovar, while his father lay on the stove coughing; as " +"it was Good Friday nothing had been cooked, and the student was terribly hungry. And now, " +
    "shrinking from the cold, he thought that just such a wind had blown in the days of Rurik " +"and in the time of Ivan the Terrible and Peter, and in their time there had been just the " +
    "same desperate poverty and hunger, the same thatched roofs with holes in them, ignorance, " +"misery, the same desolation around, the same darkness, the same feeling of oppression—all " +
    "these had existed, did exist, and would exist, and the lapse of a thousand years would make life " +"no better. And he did not want to go home."; //Main Paragraph
string contentParagraph2 = "The gardens were called the widows' because they were kept by two widows, " +
    "mother and daughter. A camp fire was burning brightly with a crackling sound, throwing out " +
    "light far around on the ploughed earth. The widow Vasilisa, a tall, fat old woman in a man's " +
    "coat, was standing by and looking thoughtfully into the fire; her daughter Lukerya, a little " +
    "pock-marked woman with a stupid-looking face, was sitting on the ground, washing a caldron and spoons." +
    " Apparently they had just had supper. There was a sound of men's voices; it was the " +
    "labourers watering their horses at the river."; //Ending Paragraph
string goodByeMessage = "Press Any Key to Next Views..."; //End Line
Console.WriteLine(tabSpace + heading); //Calling Heading With Some Extra Tabs
Console.WriteLine(tab + contentParagraph1); //Calling Single Tab and Main Paragraph
Console.WriteLine(tab + contentParagraph2); //Calling Ending Paragraph with Single Tab
Console.Write(goodByeMessage);  //Calling End Line
Console.ReadKey();  //Waiting for input


//Starting Heading
//BitWise
Console.WriteLine("BitWise");
//Bitwise will gives us (and) and (or) answers from binary to decimal
Console.Write("16 | 10 OR Bitwise is = ");
Console.WriteLine(16 | 10); //OR Bitwise
//64  32  16  8  4  2  1  0
//         1  0  0  0  0  0     Toget 16 Machine active one bit that's 16
//         0  1  0  1  0  0     Toget 10 Machine active two bits that's 8 and 2
//--------------------------
//         1  1  0  1  0  0     Performed OR Operation on Both we get this answer
//                       27     By adding bit's Numbers(16+8+2+1) we get 27
Console.Write("16 & 10 AND Bitwise is = ");
Console.WriteLine(16 & 10); //AND Bitwise
//64  32  16  8  4  2  1  0
//         1  0  0  0  0  0     Toget 16 Machine active one bit that's 16
//         0  1  0  1  0  0     Toget 10 Machine active two bits that's 8 and 2
//--------------------------
//         0  0  0  0  0  0     Performed AND Operation on Both we get this answer
//                        0     because of zero bit active we'll get the answer as Zero

//Variables And Constants
Console.WriteLine("Variables And Constants");
Console.WriteLine("Variables");
//Variables
//Decleration and Initilization of a variable
int age = 25; //Data Type Integer
Console.WriteLine("My Age is " + age); //Concatination with string
//Decleration of a variable
int price;  //Data Type Integer
//Initilization of a variable
price = 100;
Console.WriteLine("Todays Soap Price is " + price); //Concatination with string
float marksPercentage;
marksPercentage = 60.65F; //Add Float Value with Capital F in the end of number
Console.WriteLine("I obtained " + marksPercentage + "% out of 100%");
double mapCoordinatX, mapCoordinatY; //Decleration of Two Variables
mapCoordinatX = 0.498721356423; //double add more numbers then float after dot
mapCoordinatY = 0.482973237234;
Console.WriteLine("My Current Location's Coordinates are " + mapCoordinatX + "X " + mapCoordinatY + "Y");
char firstLaterOfMyName;
firstLaterOfMyName = 'F'; //Char can Store only one charater
Console.WriteLine("My Name is Fasih and the First Word of my Name is " + firstLaterOfMyName);
string collegeName = "The Tips"; //string Can Store as Many Charaters as We Want
Console.WriteLine("My College Name is " + collegeName);
mapCoordinatX = 0.742937423683; //Variables can be change at any time according to requirement
mapCoordinatY = 0.742856294239;
Console.WriteLine("Now My New Current Location's Coordinates are " + mapCoordinatX + "X " + mapCoordinatY + "Y");
bool workDone = true; //bool is the short form of Boolean and it's Used for getting the value as 1 or 0 | True or False
Console.WriteLine(workDone);

//Constant
Console.WriteLine("Constants");
const string companyName = "AgencyPrism"; //const is short form of Constant and can not be changed after once it's value done
Console.WriteLine("My Company's Name is " + companyName + ". In " + companyName + " We all work together.");

//A Small Working Discount Function
Console.WriteLine("Application of Variable and Constant with Operators");
const int totalDiscountInPercentage = 30; //constant initilization
int productPrice, discountPrice, totalPriceAfterDiscount; //variable initilization
productPrice = 200;
discountPrice = (productPrice * totalDiscountInPercentage) / 100; //formula for discount price
totalPriceAfterDiscount = productPrice - discountPrice; //Actual Price after Discount
Console.WriteLine("You Purchase the Product at Cost Rs." + productPrice + ". On this product you'll get the Discount of " + totalDiscountInPercentage + "%. Your Current " +
    "Price that you have to pay after Discount is Rs." + totalPriceAfterDiscount);

Console.WriteLine("Press Any Key to End...");
Console.ReadKey();
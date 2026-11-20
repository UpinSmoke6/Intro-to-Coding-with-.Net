char chrLetter = 'B'; //creates a character variable ad assigns the letter "B" to it.
int intNumber = 45; //Creates a whole number/integer variable the holds the value of 45.
float fltDecimal = 32.4f; //creates a decimal/float number that is accurates 7 digits to the right of the decimal point.
double dblNumber = 32.3232323232323; // creates adecimal/double number that is accurate to the 15 digits to the right of the decimal point.
decimal decNumber = 54.900003434344489m; //creates a decimal number that is accurate to 28 digits to the right of the decimal point.
bool bloTrueFalse = false; //creates a boolean variable that can only be true or false.
string strText = "This is a string."; //creates a string varibale to hold a string of characters.

Console.WriteLine("This is the Character variable's value\t" + chrLetter); //sends a string to the console.
Console.WriteLine("This is the Integer variabl's value\t" + intNumber); //sends a integer variable to the console.
Console.WriteLine("This is the Float variable's value\t" + fltDecimal); //sends a float variable to the console.
Console.WriteLine("This is the Double variable's value\t" + dblNumber); //sends a double variable to the console.
Console.WriteLine("This is the Decimal variable's value\t" + decNumber); //sends a decimal variable to the console.
Console.WriteLine("This is the Boolean variable's value\t" + bloTrueFalse); //sends a boolean variable to the console.
Console.WriteLine("This is the String variable's value\t" + strText); //sends a string variable to the console.

Console.WriteLine("What is your name?");
strText = Console.ReadLine(); //puts whatever was typed into the console into a strText variable.
Console.WriteLine("This is the name inputed: " + strText); //sends the name inputed to the console.
Console.WriteLine("How old are you? ");
intNumber = Convert.ToInt16(Console.ReadLine()); //puts whatever was typed into the console into a intNumber variable.

Console.WriteLine("Welcome " + strText + "! You are " + Convert.ToString(intNumber) + " years old!"); 

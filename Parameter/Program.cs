//Passing Arguments to the Main Method
double weight;
string num;

static string getWeight( out double kilos)
{
    kilos = 10;
    return "Ten";
}

static double poundsToKilos(double pounds = 5)
{
    return (pounds * 0.45359237);
}

static void kilosToPounds(ref double weight)
{
    weight = weight / 0.45359237;
}

num = getWeight(out weight);
Console.WriteLine($"{num} pounds = " + $"{poundsToKilos(weight)} kilos");

kilosToPounds(ref weight);
{
    Console.WriteLine($"{num} kilos = {weight} pounds");
}
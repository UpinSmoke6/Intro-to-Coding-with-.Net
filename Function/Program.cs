//Creating Functions to display body temperature in Celcius, Fahrenheit and Kelvin
static void bodyTempC()
{
    Console.WriteLine(" Body Temperature... ");
    Console.WriteLine(" 37 Degrees Celcius");
}

static double bodyTempF()
{
    double temperature = 98.6;
    return temperature; 
}

static int bodyTempK()
{
    int temperature = 310;
    return temperature;
}

bodyTempC();
{
    Console.WriteLine($" {bodyTempF()} Degrees Fahrenheit");
    Console.WriteLine($" {bodyTempK()} Degrees Kelvin");
}
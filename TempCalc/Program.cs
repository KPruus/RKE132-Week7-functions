//küsi kas teisendada celsius v fahrenheit
//küsi väärtust
//teisenda
//kuva tulemus


Console.WriteLine("Enter Temperature Unit to convert (C/F)");
char tempUnit = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter the Temperature (value):");
int tempValue = Int32.Parse(Console.ReadLine());


switch (tempUnit)
{
    case 'C':
        ConvertToFahrenheit(tempValue);
        break;
    case 'F':
        ConvertToCelsius(tempValue);
        break;
    default:
        Console.WriteLine("bad input :(");
        Console.WriteLine("(NB: Make sure you're using UPPERCASE letters for entering units)");
        break;
}
static void ConvertToFahrenheit(int a)
{
    Console.WriteLine($"{a} degrees in Celsius = ({a} * 9) / 5 + 32 = {(a * 9) / 5 + 32} degrees in Fahrenheit ");
}

static void ConvertToCelsius(int a)
{
    Console.WriteLine($"{a} degrees in Fahrenheit = ({a} - 32) * 5/9 = {(a - 32) * 5/9} degrees in Celsius");
}



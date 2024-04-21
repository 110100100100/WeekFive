
double fahrenheit;
double celsius;
int choice;

do
{
    System.Console.WriteLine("Menu");
    System.Console.WriteLine("1.*F sang *C");
    System.Console.WriteLine("2.*C sang *F");
    System.Console.WriteLine("0.Thoát");
    System.Console.WriteLine("Hãy chọn lựa chọn của bạn: ");
    choice = Int32.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            break;
        case 2:
            break;
        case 0:
            Environment.Exit(0);
            break;
    }
} while (choice != 0);

System.Console.WriteLine("Nhập *F: ");
fahrenheit = Double.Parse(Console.ReadLine());
System.Console.WriteLine("*F sang *C : " + FahrenheitToCelsius(fahrenheit));

System.Console.WriteLine("Nhập *C: ");
celsius = Double.Parse(Console.ReadLine());
System.Console.WriteLine("*C sang *F: " + CelsiusToFahrenheit(celsius));


static double CelsiusToFahrenheit(double celsius)
{
    double fahrenheit = (9.0 / 5) * celsius + 32;
    return fahrenheit;
}

static double FahrenheitToCelsius(double fahrenheit)
{
    double celsius = (5.0 / 9) * (fahrenheit - 32);
    return celsius;
}



// See https://aka.ms/new-console-template for more information
using Bezao_TestApp_Anyanwaokoro;

Console.WriteLine("Hello, World!");


int number = int.Parse(Console.ReadLine());
Console.WriteLine(number.ToString() + " with a legth of " + number.ToString().Length);
if (number != null)
{

    Number2WordConverter Converter = new Number2WordConverter();
   string convertedWord =  Converter.Convert2Words(number);
    Console.WriteLine(convertedWord);

}

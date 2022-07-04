// программa принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine(" Input 5-digits number ");
string number = Console.ReadLine();

if(number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine("This number is polindrom");
}
else
{
    Console.WriteLine("This number is not polindrom");
}
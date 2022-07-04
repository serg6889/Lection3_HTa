// программa принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//void CubeOfNum(int number)
//{
//    int CubeOfNum = 1;
//    int j = 1;
//    if(number > 0)
//    {
//        while(j <= number)
//        {
//            System.Console.WriteLine(j*j*j);
//            j+=1;
//        }    
//    }
//    else if (number == 0)
//    { 
//        System.Console.Write("Cube is  ");
//        System.Console.WriteLine(0);
//   }
//}

//int number;
//Console.WriteLine("input number");
//while (! int.TryParse(Console.ReadLine(), out number));
//{
//  System.Console.WriteLine("Incorrect input !!!");
//}

//CubeOfNum(number);


Console.WriteLine ("Введите число: ");
int number = int.Parse (Console.ReadLine ()!);
int j = 1;

while (j <= number)
{
    Console.Write("Cube = ");
    Console.WriteLine($"{j*j*j},");
    j ++;
}
Console.Write("\b \b");

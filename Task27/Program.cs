/*Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.*/

/*int Input (int number);
{
    Console.WriteLine("Enter number: ");
    int number = int.Parse(Console.ReadLine());
}*/

int SumDigital (int number)
{
    int result = 0;
  
    for (int i = 0; i <= number; i++)
    {
        result = result + i;
    }
    return result;
}

Console.WriteLine("Enter number: ");
Console.WriteLine(SumDigital(int.Parse(Console.ReadLine())));
/*Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.*/
int a,b;
void EnterNumber() 
{
    Console.WriteLine("Enter number a: ");
    a = int.Parse (Console.ReadLine());
    Console.WriteLine("Enter number b: ");
    b = int.Parse (Console.ReadLine());    
}

bool isNatural(int number) 
{
    if (number < 0)
    {
        Console.WriteLine("Введите положительное число!");
        return false;
    }
    return true;
}

int NaturalPow(int a, int b)
{
    return (int)Math.Pow(a,b);
}

EnterNumber();
if (isNatural(b))
    Console.WriteLine(NaturalPow(a, b));


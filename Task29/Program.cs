//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] Random(int number)
{
    int[] result = new int [number]; //int [number] - задаем длину массива
    for (int i = 0; i < number; i++)
    {
    result [i] = (new Random().Next(0, 100000000));
    }
    return result;
}

Console.WriteLine("Введите длину массива");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(String.Join(", ",Random(number)));
// Напишите программу, которая принимает на вход число N и выдает факториал этого числа
Console.WriteLine("введите число и программа посчитает его факториал!");

int number = Convert.ToInt32(Console.ReadLine());

int factorial(int num)
{
    int count = 1;
    for (int i = 1; i <= num; i++)
    {
        count = count * i;
    }
    return count;
}
int result = factorial(number);
Console.WriteLine($"Факториал числа {number} = {result} ");

Console.WriteLine("Задание 25");
Console.Clear();

int Count(int number, int number2)
{
    int summ = 1;
    for(int i = 1; i <= number2; i++)
    {
        summ *= number; 
    }
    return summ;
}

Console.Write("Число: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Степень: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine(Count(num, num1));

Console.WriteLine("Задание 27");

int AllCounter(int number3)
{
    int summ1 = 0;
    while(number3 / 10 > 1)
    {
        int del = number3 % 10;
        summ1 += del; 
        number3 /= 10;
    }
    summ1 += number3;
    return summ1;
}

Console.Write("Число: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(AllCounter(num2));

Console.WriteLine("Задание 29");

int[] AllCounter2(int n)
{
    int[] num7 = new int[n];
    for(int i = 0; i < 8; i++)
    {
        num7[i] = new Random().Next(101);
    }
    return num7;
}

int[] arr = AllCounter2(8);

for(int j = 0; j < 8; j++)
{
    Console.Write($"{arr[j]}, ");
    
}
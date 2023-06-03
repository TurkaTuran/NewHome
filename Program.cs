Console.Clear();
Console.WriteLine("Задание 1");

int Check (int size)
{
    int count = 0;
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }

    Console.WriteLine($"[{String.Join(",", arr)}]");
    
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("list_size: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(Check(num));

Console.WriteLine("Задание 2");

int Check2 (int size)
{
    int summ = 0;
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }

    Console.WriteLine($"[{String.Join(",", arr)}]");
    
    for(int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ += arr[i];
        }
    }
    return summ;
}

Console.Write("list_size: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(Check2(num2));

Console.WriteLine("Задание 3");

double Check3 (int size)
{
    double summ = 0;
    double[] arr = new double[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble();
    }

    Console.WriteLine($"[{String.Join(",", arr)}]");
    
    double max = arr[0];
    double min = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            if (max <= min)
            {
                max = min;
            }
            max = arr[i];
        }
        else
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
    }
    Console.WriteLine($"max -> {max}");
    Console.WriteLine($"min -> {min}");
    return max - min;
}

Console.Write("list_size: ");
int num3 = int.Parse(Console.ReadLine());

Console.WriteLine(Check3(num3));
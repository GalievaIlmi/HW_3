// Задача 24: Найти кубы чисел от 1 до N
// Console.WriteLine("Введите число от 1 до N ");
// int num = int.Parse(Console.ReadLine());
// int result = (num * num * num);

// Console.WriteLine($"Число в кубе равняется: {result}");

int[] array = new int[10];
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = array[i] * array[i] * array[i];
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int InNumber()
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            return number;
        }
        else
        {
            Console.Write("Не удалось распознать число. \nВведите число ещё раз: ");
        }
    }
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число № {i + 1}: ");
        array[i] = InNumber();
    }
}
void PrintArray(double[] array)
{
    Console.Write("Массив заполнен: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

Console.Write("Введите размер массива: ");

int size = InNumber();
double[] array = new double[size];

FillArray(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

PrintArray(array);
Console.WriteLine($"\nКоличество положительных чисел: {count}");

Console.Clear();
Console.WriteLine("Введите элементы массива через пробел: ");
string? inserted = Console.ReadLine();
string[] elements = inserted.Split(" ", StringSplitOptions.RemoveEmptyEntries);
GetAndPrintResult(elements);

void GetAndPrintResult(string[] elements)
{
    string[] resMass = new string [elements.GetLength(0)];
    int j = 0;
    for (int i = 0; i < elements.GetLength(0); i++)
    {
        if (elements[i].Length < 4)
        {
            resMass[j] = elements[i];
            Console.Write($"{resMass[j]} ");
            j++;
        }
    }
}


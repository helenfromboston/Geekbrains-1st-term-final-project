void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Задайте длину массива: ");
int L = int.Parse(Console.ReadLine());
string[] array = new string[L];
Console.WriteLine("Введите поочерёдно элементы массива: ");

for (int l = 0; l < array.Length; l++)
{
    array[l] = Console.ReadLine();
}

Console.WriteLine();

int index = 0;
string[] array2 = new string[L];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array2[index] = array[i];
        index++;
    }
}

Print(array2);
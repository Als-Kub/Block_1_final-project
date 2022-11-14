Console.Clear();

Console.WriteLine("Enter array elements separated by space");

string inputString = Console.ReadLine()!;
string[] arrayOriginal = inputString.Split(" ");

int newArrayElements = CountArrayElements(arrayOriginal);
string[] resultArray = CreateNewArray(arrayOriginal);

Console.WriteLine();
Console.WriteLine("Origin array:");
Console.Write("[" + $"{String.Join(", ", arrayOriginal)}" + "]");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("New array:");
Console.Write("[" + $"{String.Join(", ", resultArray)}" + "]");

int CountArrayElements(string[] stringArray)
{
    int newArrayElements = 0;

    for (int i = 0; i < arrayOriginal.Length; i++)
    {
        int elementMaxLength = arrayOriginal[i].Length;
        if (elementMaxLength <= 3)
        {
            newArrayElements++;
        }
    }
    return newArrayElements;
}

string[] CreateNewArray(string[] stringArray)
{
    string[] newArray = new string[newArrayElements];
    int j = 0;
    for (int i = 0; i < arrayOriginal.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newArray[j] = stringArray[i];
            j++;
        }
    }
    return newArray;
}

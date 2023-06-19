void CreateArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        stringArray[i] = Console.ReadLine();
    }
}
void PrintAray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{stringArray[i]} ");
    }
}
int SearchSize3Char(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
void CreateNewArray(string[] oldArray, string[] newArray)
{
    for (int i = 0, j = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3)
        {
            newArray[j] = oldArray[i];
            j++;
        }
    }
}
string[] stringArray = new string[5];
Console.WriteLine("Введите 5 слов:");
CreateArray(stringArray);
PrintAray(stringArray);
Console.WriteLine();
string[] newStringArray = new string[SearchSize3Char(stringArray)];
CreateNewArray(stringArray, newStringArray);
PrintAray(newStringArray);
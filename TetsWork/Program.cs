void CreateArray(string[] stringArray){
    for (int i = 0; i < stringArray.Length; i++)
    {
        stringArray[i] = Console.ReadLine();   
    }
}
void PrintAray(string[] stringArray){
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{stringArray[i]} ");
    }
}
void SearchFor3Char(string[] stringArray){
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        count = 0;
       for (int j = 0; j < stringArray[i].Length; j++)
       {
         count++;
       }
       if(count <= 3){
        Console.Write($"{stringArray[i]} ");
       }
    }
}
string[] stringArray = new string[5];
System.Console.WriteLine("Введите 5 слов:");
CreateArray(stringArray);
PrintAray(stringArray);
System.Console.WriteLine();
SearchFor3Char(stringArray);


void ResultArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] firstArray = new string [5] {"123", "-2", "hello", "world", "Russia"};
string[] secondArray = new string[firstArray.Length];
Console.WriteLine( "Первоначальный массив:");
PrintArray(firstArray);
ResultArray(firstArray, secondArray);
Console.WriteLine( "Массив из строк меньше, либо равных трем:");
PrintArray(secondArray);

string[] ElementsWithLengthLess4(string[] initialArray)
{
    int finalArrayLength = 0;
    int initialArrayLength = initialArray.Length;
    int j = 0;

    for (int i = 0; i < initialArrayLength; i++)
    {
        int elementLength = initialArray[i].Length;

        if (elementLength <= 3)
            finalArrayLength = finalArrayLength + 1;
    }

    string[] finalArray = new string[finalArrayLength];

    for (int i = 0; i < initialArrayLength; i++)
    {
        int elementLength = initialArray[i].Length;

        if (elementLength <= 3)
        {
            finalArray[j] = initialArray[i];
            j = j + 1;
        }
    }
    return finalArray;
}


void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "; ");
    Console.WriteLine();
}

string[] initialArray = {"Hello", "2", "-7", "world", "//", "мяу"};
PrintArray(ElementsWithLengthLess4(initialArray));

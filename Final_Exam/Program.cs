// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых равна или меньше 3 символов.

string[] text = {"хвост","за","хвост","глаз","за","глаз","никуда","ты","не","уйдешь","от","нас"};

void PrintText(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'");
        Console.Write($"{array[i]}");
        Console.Write($"'");
        if (i != array.Length - 1) Console.Write($", ");
    }
}

Console.Write($"[");
PrintText(text);
Console.Write($"]");

int FindLength(string[] array)
{
    string position = string.Empty;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        position = array[i];
        if (position.Length <= 3) count ++;
    }
    return count;
}

string[] FillArray (string[] array, int arrayLength)
{
    string[] sort = new string[arrayLength];
    string position = string.Empty;
    int sortIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        position = array[i];
        if (position.Length <= 3)
        {
            sort[sortIndex] = position;
            sortIndex ++;
        }
    }
    return sort;
}
int lengthArray = FindLength(text);
string[] sortArray = FillArray(text, lengthArray);

Console.Write($" -> [");
PrintText(sortArray);
Console.Write($"]");
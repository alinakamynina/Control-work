string[] array = new string[] { "hello", "2", "world", ":-)" };

string[] array2 = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    string elements = "";

    for (int j = 0; j < array[i].Length; j++)
    {
        elements += array[i][j];
        array2[i] = elements;
        if (elements.Length == 3)
        {
            break;
        }
    }
}
Console.WriteLine(string.Join(", ", array2));

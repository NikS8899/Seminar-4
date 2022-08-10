
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}
int[] array = GetArray(8);
Console.Write($"[{String.Join(", ", array)}]");
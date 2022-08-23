void FillArray(int[] collection)
{
    int lengthOfArr = collection.Length;
    int i = 0;
    while (i < lengthOfArr)
    {
        collection[i] = new Random().Next(1, 100);
        i++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[8];

FillArray(array);

PrintArray(array);
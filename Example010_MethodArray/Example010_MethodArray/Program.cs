int[] array = {122, 2543, 122, 45456, 5332, 5346, 7534, 856435};

int n = array.Length;

int find = 122;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
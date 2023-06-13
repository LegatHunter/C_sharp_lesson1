int[] array = { 1, 2, 13, 45, 68, 62, 45, 77 };
int n = array.Length;
int find = 13;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}
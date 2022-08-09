//              0   1   2   3   4   5   6   7   8   9
int[] array = { 18, 72, 63, 54, 45, 18, 27, 17, 15, 65 };

int n = array.Length;
int find = 18;

int index=0;

while (index < n)
{
    if (array[index] == find)
        {
            Console.WriteLine(index);
            break;
        }
    index++;
}
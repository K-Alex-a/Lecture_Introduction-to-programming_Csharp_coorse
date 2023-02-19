int[] array = { 10, 20, 30, 4, 50, 16, 17, 18, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;                                        //index = index +1;
}
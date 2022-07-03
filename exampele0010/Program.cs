// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = {1, 12, 4, 48, 4, 15, 26, 37, 48};

int n = array.Length;
int find = 48; 
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
         Console.WriteLine(index);
         break;
    }

    index++;
}

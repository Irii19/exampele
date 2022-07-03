void FillArray(int[] collection)     // метод (функция) заполнения масива рамдомными числами от 1 до 10
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArrey(int[] coll)      // метод (функция) печать масива
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)  // метод (функция) нахождения значения
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;                       // остановка поика значения индекса на первом совпадении
        }
        index++;
    }
    return position;
}

int[] array = new int[10];  // пустой массив

FillArray(array);           // заполнени массива
array[2] = 4;              // замена значения индекса "2" масива назначение "4"
array[6] = 7;               //  замена значения индекса "6" масива на значение "7"
PrintArrey(array);     // печать массива
Console.WriteLine();

int pos = IndexOf(array, 4); // поиск число "4" по индексам массива
Console.WriteLine(pos); // вывод индекса "" со значением "4"
// Метод заполнения массива и печати его на экран:

void FillArray(int[] collection)                            // даем наименование методу (void) coolection
{
    int length = collection.Length;                         // получаем длинну массива
    int index = 0;                                          // индес по умолчанию устанавливаем на 0
    while (index < length)                                  // пока index меньше чем length будем делать ->
    {
        collection[index] = new Random().Next(1, 10);       // берем аргумент coolection с индексом 0 и далее вкладываем рандомное число -> по кругу в диапозоне чисел от 1 до 10
        index++;                                            // index = inex + 1
    }
}

void PrintArray(int[] col)                                  // делаем метод для печати массива с названием col
{
    int count = col.Length;                                 // получаем кол-во элементов
    int position = 0;                                       // задаем позицию
    while (position < count)                                // пока position меньше count делаем ->
    {
        Console.WriteLine(col[position]);                   // выводим значение текущего элемента
        position++;                                         // прибавляем к position по единице на каждом круге
    }
}

int IndexOf(int[] collection, int find)                     // создаем метод с названием IndexOf имеющий 2 аргумента: массив-collection и элемент-find
{
    int count = collection.Length;                          // получаем кол-во элементов
    int index = 0;                                          // устанавливаем index как 0
    int position = -1;                                      // вводим переменную position со значением -1 (элемент не найден)
    while (index < count)                                   // пока index меньше count делай ->
    {
        if (collection[index] == find)                      // если массив с индексом равен find-у, то ->
        {
            position = index;                               // кладем в position наш index
            break;
        }
        index++;                                            // к индексу прибавляем единичку
    }
    return position;                                        // возвращаем position
}

int[] array = new int[10];                                  // создание массива из 10 чисел <- его же мы обозвали coolection и col

FillArray(array);                                           // запускаем метод FillArray   
PrintArray(array);                                          // запускаем метод PrintArray
Console.WriteLine();                                        // выводим на печать пустую строку

int pos = IndexOf(array, 2);                                // вводим пермеменную pos которая является методом IndexOf (25)
Console.WriteLine(pos);                                     // как метод отработаем, то выводим на печать pos
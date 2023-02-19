// Вид 1: ничего не принимает и ничего не возвращает:

// void Method1()
// {
//     Console.Write("Автор ...");
// }
// Method1();



// Вид 2: что-то принимает и ничего не возвращает:

// 2.0:
// void Method2(string msg)                 // msg -> mesage
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// 2.1:
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4);            // первый вариант
// Method21(count: 4, msg: "новый текст");      // второй вариант   <- говорят о том что порядок не важен!



// Вид 3: ничего не принимают и что-то возвращают:

// int Method3()                       // задаем метод----почему не через void?
// {
//     return DateTime.Now.Year;       // возвращаем дату сейчашнего года
// }
// int year = Method3();               // вводим переменную year
// Console.WriteLine(year);            // печатаем year ----- можно и сразу на печать "Console.WriteLine(Method3())"



// Вид 4: что-то принимает и что-то возвращает:

// string Method4(int count, string text)  
// {
//     int i = 0;
//     string result = String.Empty;       // ввод переменной result с присвоением пустого значения (String.Empty)
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);  




// Про цикл `for`:

// string Method4(int count, string text)
// {
//     string result = String.Empty;       // ввод переменной result с присвоением пустого значения (String.Empty)
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text; ;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);



// Запихиваем цикл в цикл (for in for):
// for (int i = 1; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)                   // закцикливание уловия
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }



// =====Работа с текстом
// Задача: Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с":

// string text = "- Я думаю, - сказал князь, улабаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012345
// // s [3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;                           // выводим пустую строку

//     int leangth = text.Length;                              //  команда подсчета символов в тексте (text.Length)
//     for (int i=0; i<leangth; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// string newText2 = Replace(newText, 'C', 'c');
// Console.WriteLine(newText2);
// Console.WriteLine();
// string newText3 = Replace(newText2, 'к', 'К');
// Console.WriteLine(newText3);
// Console.WriteLine();



// Упорядочивание массива по возврастанию: 
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)                    // ищет максимальный элемент
        {                                                           // ищет максимальный элемент
            if (array[j] < array[minPosition]) minPosition = j;      // ищет максимальный элемент
        }                                                           // ищет максимальный элемент

        int teemporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = teemporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
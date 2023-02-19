// Задача #:
// Собрать строку с числами от а до b, a <= b:
// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10




// Задача #:
// Собрать строку с числами от а до b, a <= b, по убыванию:
// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i >= b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1 
// Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1 




// Задача #:
// Сумма чисел от 1 до N:
// int SumFor(int n) // обычный метод
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }
// int SumRec(int n) // через рекурсию
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumFor(10));  // 55
// Console.WriteLine(SumRec(10));  // 55



// Задача #:
// Факториал числа(произведение чисел от 1 до N):
// int FactorialFor(int n) // обычный метод
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }
// int FactorialRec(int n) // через рекурсию
// {
//     if (n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }
// Console.WriteLine (FactorialFor(10));   // 3628800
// Console.WriteLine (FactorialRec(10));   // 3628800



// Задача #:
// Вычислить a в n-ой степени:
// int PowerFor(int a, int n) // обычный метод
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }
// int PowerRec(int a, int n)    // через рекурсию  
// {
//     // return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }
// int PowerRecMath(int a, int n)    // через математическую рекурсию  
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024
// Console.WriteLine(PowerRecMath(2, 10)); // 1024



// Задача #:
// В алфавите дано 4 буквы: а, и, с, в.
// Покажите все слова состояжие из Т(кол-во) букв, которые можно построить из букв этого алфавита:
// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;

// for (int i = 0; i < count; i++)
// {
//     Console.WriteLine($"{n++,-5}{s[i]}");
// }

// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}");
//         return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length +1 );
//     }
// }
// FindWords("аисв", new char [5]);    // 1028 вариантов из 1 до 5 букв



//*****-----Про директории----*****
// string path = "Q:/01_Studies/C#_lessons/Lecture/01_Examples/Example001_HelloConsole";
// CatalogInfo(path);
// // DirectoryInfo di = new DirectoryInfo(path);
// // System.Console.WriteLine(di.CreationTime);  // последние изменения
// // FileInfo[] fi = di.GetFiles();  // выводит инфо о файлах внутри

// // for (int i = 0; i < fi.Length; i++)
// // {
// //     System.Console.WriteLine(fi[i].Name);
// // }

// void CatalogInfo(string path, string indent = "")    // искусственный пробел для иерархии удобной
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);    // получаем инфо о директории в которую зашли
//     DirectoryInfo[] catalogs = catalog.GetDirectories();    // получаем массив всех фалов, находящихся внутри
//     for (int i = 0; i < catalogs.Length; i++)   // пробегаем по массиву проверяя все папки внутри папки через рекурсию
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}"); 
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();  // получаем весь список файлов

//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }



// Задача # (про пирамдки через рекурсию):
// void Towers(string with = "1", string on = "3", string some = "2", int count = 4)   // 3 шпиля и 4 блина
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();


// Задача # (обход узлов дерева через рекурсию):
// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

// void InorderTraversal(int pos = 1)  // метод обхода
// {
//     if (pos < tree.Length) // если позиция вылетела за кол-во элементов, то делаем ->
//     {
//         int left = 2 * pos; // 2a
//         int right = 2 * pos + 1;    // 2a+1
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InorderTraversal(left);    // если левое дерево имеется и фрагмент внутри его не является пустым, то необходимо запустить обход дерева с текцущей позиции
//         Console.WriteLine(tree[pos]);   // выводем узел(значение)
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InorderTraversal(right); // и аналогично делаем для правого поддерева
//     }
// }
// InorderTraversal();



// Задача # (Фибоначи через условие и рекурсию с отражением вол-ва шагов и потраченного временеи):
decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}


//
//
Console.ReadLine ();
DateTime dt = DateTime.Now;

for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();


dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

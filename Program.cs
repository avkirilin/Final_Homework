// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] --> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -->["-2"]
// ["Russia", "Denmark", "Kazan"] --> []

Console.Clear();
void SearchShortElemnents(string[] inputArray, string[] resultArray)    //метод поиска значений массива
{                                                                       //с длинной элемента менее 4 знаков
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length < 4)
        {
            resultArray[count] = inputArray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)                                         //метод вывода массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите массив строк через пробел");
string inputString = Console.ReadLine()!;
string[] userArray = inputString.Split(' ')!;
string[] resultArray = new string[userArray.Length];
SearchShortElemnents(userArray, resultArray);
Console.WriteLine();
Console.Write($"Изначально заданный массив: ");
PrintArray(userArray);
Console.WriteLine();
Console.Write($"Элементы со значением меньше либо равно 3 символам: ");
PrintArray(resultArray);
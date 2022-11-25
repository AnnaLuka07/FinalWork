// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// например: 
// ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer sciense"]
// ["Россия", "Дания", "Казань"] -> []

Console.Clear();          

void PrintArray (string [] array)                               // функция вывода на экран
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{array[i]}\t");
    }  
}

string[] ResultArray (string[] array)                             // функция поиска элементов длиной <= 3 символов
{
    string[] result = new string [array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count ++;
        }
    }
    return result;
}

Console.WriteLine("Задан массив строк:");
string[] arr = new string [6] {"Россия", "Рим", "Дания", "Казань", "Уфа", ";-)"};
PrintArray (arr);
string[] result = ResultArray(arr);
Console.WriteLine();
Console.Write("Элементы в массиве, в которых меньше либо равно 3 символа -->  ");
PrintArray (result);

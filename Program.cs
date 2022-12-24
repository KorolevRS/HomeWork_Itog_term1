/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/
Console.WriteLine($"Введите массив строк через (без пробелов) ','");
string[] array = Console.ReadLine()!.Split(',');
string[] newArray = new string[array.Length];
int j = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        // Console.WriteLine($"{newArray[j]}");
        j++;
    }
Print(array);
Console.WriteLine();
Print(newArray);

void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}



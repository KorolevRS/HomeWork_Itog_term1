/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

Console.WriteLine($"Введите массив строк через (без пробелов) ','");
string[] array = Console.ReadLine()!.Split(',');
int j = 0;
for (int i = 0; i < array.Length; i++) //подсчет количества элементов нового массива
    if (array[i].Length <= 3) j++;
string[] newArray = new string[j + 1]; // опрелили размерность нового массива
if (j == 0) //если элементов с длиной менее 3 символов нет в массив, 
            //прерываем программу и далее по коду не идем
{
    Console.WriteLine("Элементов с длиной <= 3 символов нет");
    Environment.Exit(0);
}
j = 0;
for (int i = 0; i < array.Length; i++) //заполняем новый массив элементами, длина которых <= 3 символов
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
Console.Write($"Первоначальный массив: ");
Print(array);
Console.Write($"Новый массив: ");
Print(newArray);

void Print(string[] arr)//вывод массива на экран
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

/* решение задачи с помощью списка List
using System.Collections.Generic;
Console.WriteLine($"Введите массив строк через (без пробелов) ','");
string[] array = Console.ReadLine()!.Split(',');
List<string> newArray = new List<string>();
for (int i = 0; i < array.Length; i++)
   if (array[i].Length <= 3) newArray.Add(array[i]);
Console.WriteLine();
Print(array);

for (int i = 0; i < newArray.Count; i++) //вывод массива(списка) типа list
   Console.Write($"{newArray[i]} ");
Console.WriteLine();
void Print(string[] arr)//вывод массива на экран
{
   for (int i = 0; i < arr.Length; i++)
       Console.Write($"{arr[i]} ");
   Console.WriteLine();
}
*/

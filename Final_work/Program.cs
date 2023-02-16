/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше, либо равна трем символам.
*/

Console.Write("Введите текст, слова и символы разделяя пробелами: ");

var text = Console.ReadLine().Split();
string[] array1 = text.ToArray();
string[] array2 = new string[array1.Length];

{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array.Length > 0)
        {
            Console.Write(array[i] + " ");
        }
        else if (array.Length == 0)
        {
            Console.WriteLine("В тексте нет слов, состоящих не более, чем из трех букв и/или символов!");
        }      
    }
}

PrintArray(array2);
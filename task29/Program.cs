using static Library;
//  Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

// метод, который создаёт массив
// печать массива

int[] array = CreateArray(8);
Console.WriteLine(PrintGood(array));

// int[] array = {1, 2, 5, 7, 19, 6, 1, 33};

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for(int i = 0; i < count; i++)
//     {
//         Console.Write ($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// PrintArray(array);
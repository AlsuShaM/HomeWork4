public static class Library
{
    // обязательно в новом файле прописываем 
    // using static Library


    // метод, который создаёт массив
    public static int[] CreateArray(int count)
    {
     return new int[count];
    }

    // заполняет массив
    public static void Fill(int[] array, int min, int max)
    { 
        int size = array.Length; 
        for (int i = 0; i < size; i++)
        {
            array[i] = Random.Shared.Next(min, max + 1);
            //array[i] = new Random().Next(min, max);
        }
    }

    // печать массив
    public static string PrintGood(int[] numbers)
    {
        int size = numbers.Length;
        int i = 0;
        string result = "[ ";

        while (i < size)
        {
            result += ($"{numbers[i],3} ");
            i++;
        }
        return result + "]";
    }

    // вычисление суммы положительных значений
    public static int SumPositive(int[] numbers)
    {
        int result = 0;
        int size = numbers.Length;
        for (int i = 0; i < size; i++)
        {
            if (numbers[i] > 0) result += numbers[i];
        }
        return result;
    }

    // вычисление суммы отрицательных значений
    public static int SumNegative(int[] numbers)
    {
        int result = 0;
        int size = numbers.Length;
        for (int i = 0; i < size; i++)
        {
            if (numbers[i] < 0) result += numbers[i];
        }
        return result;
    }

    // метод упорядочивания элементов
    public static void SelectionSort(int[] array)
    {
        for(int i = 0; i < array.Length - 1; i++)
        {
            int minPosition = i;
            for(int j = i + 1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) minPosition = j;
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
    }
}

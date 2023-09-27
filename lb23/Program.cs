//197
//Разделить массив на две части, поместив в первую элементы,
//большие среднего арифметического их суммы,
//а во вторую — меньшие 

class Program
{
    static void Main()
    {
      
        int[] array = new int[10];

        // Находим среднее арифметическое
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 20);
            sum += array[i];
        }
        int average = sum / array.Length;

        // Разделяем массив
        int firstPartStartIndex = 0;
        int firstPartLength = 0;
        int secondPartStartIndex = 0;
        int secondPartLength = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > average)
            {
                firstPartLength++;
            }
            else
            {
                secondPartLength++;
            }
        }

        
        int[] firstPart = new int[firstPartLength];
        int[] secondPart = new int[secondPartLength];

   
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > average)
            {
                firstPart[firstPartStartIndex++] = array[i];
            }
            else
            {
                secondPart[secondPartStartIndex++] = array[i];
            }
        }

      
        Array.Sort(firstPart);
        Array.Sort(secondPart);

      
        Console.WriteLine("Первая часть:");
        foreach (int element in firstPart)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine();
        Console.WriteLine("Вторая часть:");
        foreach (int element in secondPart)
        {
            Console.WriteLine(element);
        }
    }
}

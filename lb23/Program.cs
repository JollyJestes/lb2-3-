//197
//Разделить массив на две части, поместив в первую элементы,
//большие среднего арифметического их суммы,
//а во вторую — меньшие (части не сортировать).

class Program
{
    static void DivideArray(int[] arr, out List<int> greater, out List<int> lesser)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        double average = (double)sum / arr.Length;

        greater = new List<int>();
        lesser = new List<int>();

        foreach (int num in arr)
        {
            if (num > average)
            {
                greater.Add(num);
            }
            else
            {
                lesser.Add(num);
            }
        }
    }

    static void Main()
    {
        Console.Write("Введите длину массива: ");
        if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
        {
            int[] arr = new int[length];

            Console.WriteLine("Введите элементы массива:");

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    arr[i] = element;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                    i--;
                }
            }

            List<int> greater;
            List<int> lesser;

            DivideArray(arr, out greater, out lesser);

            Console.WriteLine("\nЭлементы больше среднего арифметического:");
            foreach (int num in greater)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nЭлементы меньше или равные среднему арифметическому:");
            foreach (int num in lesser)
            {
                Console.Write(num + " ");
            }
        }
        else
        {
            Console.WriteLine("Некорректная длина массива.");
        }

        Console.ReadLine();
    }
}
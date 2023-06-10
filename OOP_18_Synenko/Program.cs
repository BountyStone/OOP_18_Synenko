using System;

class Program
{
    static void Main(string[] args)
    {
        // Завдання 1

        // Оголошення та iнiцiалiзацiя одномiрного масиву
        double[] array = { 1.5, -2.7, 3.2, -4.8, 5.1 };

        // Обчислення добутку вiд'ємних елементiв
        double negativeProduct = 1;
        foreach (double num in array)
        {
            if (num < 0)
                negativeProduct *= num;
        }

        // Обчислення суми додатних елементiв до максимального
        double maxElement = array[0];
        double sumPositiveBeforeMax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElement)
                maxElement = array[i];

            if (array[i] > 0 && array[i] != maxElement)
                sumPositiveBeforeMax += array[i];
        }

        // Змiна порядку елементiв у масивi на протилежний
        Array.Reverse(array);

        // Виведення результатiв розрахункiв та змiн у масивi
        Console.WriteLine("Добуток вiд'ємних елементiв: " + negativeProduct);
        Console.WriteLine("Сума додатних елементiв до максимального: " + sumPositiveBeforeMax);
        Console.WriteLine("Масив зi змiненим порядком елементiв:");
        foreach (double num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Завдання 2

        // Оголошення та iнiцiалiзацiя двовимiрного масиву
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Виведення усього масиву
        Console.WriteLine("Двовимiрний масив:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Виведення будь-якого елемента другого рядку
        int elementInSecondRow = matrix[1, 0];
        Console.WriteLine("Елемент другого рядку: " + elementInSecondRow);

        // Виведення будь-якого елемента масиву
        int element = matrix[2, 1];
        Console.WriteLine("Будь-який елемент масиву: " + element);

        Console.ReadLine();
    }
}

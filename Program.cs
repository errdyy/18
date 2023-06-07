using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };  //наверное так удобнее изменять...

        Console.WriteLine("Исходный двумерный массив:");
        PrintMatrix(matrix);

        int rows = matrix.GetLength(0);//последствия инициативы
        int columns = matrix.GetLength(1);

        Console.WriteLine("Элементы окантовки:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (i == 0 || i == rows - 1 || j == 0 || j == columns - 1)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();//главное не то что криво, а то что старался
        }

        Console.ReadLine();
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
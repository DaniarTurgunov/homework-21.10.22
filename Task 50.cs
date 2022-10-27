// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.WriteLine("Введите m");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите позицию");
// int numP = Convert.ToInt32(Console.ReadLine());
// int numP1 = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[numM, numN];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(10,100);
//     }
// }
// printArray(array);
// void printArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// if (numP < 0 | numP >= array.GetLength(0) | numP1 < 0 | numP1 >= array.GetLength(1))
// {
//      Console.WriteLine("Такого элемента нет ");
// }
// else
// {
//     Console.WriteLine("Значение элемента массива = {0}", array[numP, numP1]);
// }
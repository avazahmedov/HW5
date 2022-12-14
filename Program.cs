// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2,


// int [] NewArray(int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i<size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void PrintArray(int [] array)
// {
//     for (int i = 0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void ShowPositive(int [] array)
// {
//     int count = 0;
//     int i = 0;
//     while ( i<array.Length)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//             i++;
//         }
//         else
//             i++;
//     }
//     Console.WriteLine($"Количество четных чисел в массиве - {count}");
// }

// Console.WriteLine($"Enter size:");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] createdarray = NewArray(size);
// PrintArray(createdarray);
// ShowPositive(createdarray);





// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int [] NewArray(int size, int min, int max)
// {
//     int [] array = new int[size];
//     for (int i = 0; i<size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// void ShowArray(int [] array)
// {
//     int count = 0;
//     int i = 0;
//     while ( i<array.Length)
//     {
//         if (array[i] >=10 && array[i] <=99)
//         {
//             Console.Write($"|{array[i]}| ");
//             count++;
//             i++;
//         }
//         else
//         {
//             Console.Write($"{array[i]} ");
//             i++;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Количество элементов, значения которых лежат в отрезке [10,99] - {count}");
//     Console.WriteLine();
// }

// Console.WriteLine($"Enter size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max ");
// int max = Convert.ToInt32(Console.ReadLine());

// ShowArray(NewArray(size, min, max));



// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.


// int [] NewArray(int size, int min, int max)
// {
//     int [] array = new int[size];
//     for (int i = 0; i<size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void PrintArray(int [] array)
// {
//     for (int i = 0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int Summ(int [] array)
// {
//     int sum = 0;
//     int i = 0;
//     while ( i<array.Length)
//     {
//         if (i % 2 != 0)
//         {
//             sum = sum + array[i];
//             i++;
//         }
//         else
//             i++;
//     }
//     return sum;
// }

// Console.WriteLine($"Enter size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] createdarray = NewArray(size, min, max);
// PrintArray(createdarray);
// int sum = Summ(createdarray);
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях - {sum}");


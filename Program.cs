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



// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// int [] NewArray(int size, int min, int max)
// {
//     int [] array = new int[size];
//     for (int i = 0; i<size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void ShowArray(int [] array)
// {
//     for (int i = 0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void FindMinMax(int [] array)
// {
//     int i = 0;
//     int minv = array[0];
//     int maxv = array[1];
//     int temp = 0;
//     if (minv>maxv)
//     {
//         temp = maxv;
//         maxv = minv;
//         minv = temp; 
//     }
//     while (i<array.Length){
//     if (array[i]>maxv)
//     {
//         maxv = array[i];
//         i++;
//     }
//     else if (array[i]<minv)
//     {
//         minv = array[i];
//         i++;
//     }
//     else i++;
//     }
//     Console.WriteLine($"Максимальный элемент массива - {maxv}");
//     Console.WriteLine($"Минимальный элемент массива - {minv}");
//     Console.WriteLine($"Разница между максимальным и минимальным элементом массива - {maxv-minv}");
// }

// Console.WriteLine($"Enter size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] myarray = NewArray(size, min, max);
// ShowArray(myarray);
// FindMinMax(myarray);


// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// int [] NewArray(int size, int min, int max)
// {
//     int [] array = new int[size];
//     for (int i = 0; i<size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void ShowArray(int [] array)
// {
//     for (int i = 0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void FindPr(int [] array)
// {
//     int i = 0;
//     int j = array.Length-1;
//     while (i != j)
//     { 
//         Console.Write($"{array[i]*array[j]} ");
//         i++;
//         j--;
//     }
//         if (i == j){
//         Console.Write($"{array[i]} ");}
// }

// Console.WriteLine($"Enter size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] myarray = NewArray(size, min, max);
// ShowArray(myarray);
// FindPr(myarray);

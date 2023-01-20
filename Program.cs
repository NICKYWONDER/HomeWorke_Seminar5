// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Решение:

// int[] startArray = GetArray(6, 100, 999);
// Console.Write($"[{String.Join(",", startArray)}]");
// Console.Write($" Количество четных элементов в массиве = {GetEvenCount(startArray)}");
// int[] GetArray(int size, int minValue, int maxValue){
//     int [] res = new int[size];
//     for(int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// int GetEvenCount(int[] array){
//     int count = 0;
//     foreach(var item in array){
//         if(item % 2 == 0) count++;
//     }
//     return count;
// }

// ______________________________________________________________________________________________________________________________________________________________________________________________
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Решение:

// int[] startArray = GetArray(6, 0, 999);
// Console.Write($"[{String.Join(",", startArray)}]");
// Console.Write($" Количество четных элементов в массиве = {GetSum(startArray)}");
//  int[] GetArray(int size, int minValue, int maxValue){
//     int [] res = new int[size];
//     for(int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// int GetSum(int[] array){
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(i % 2 == 1) sum += array[i];
//     }
//     return sum;
// }

// ______________________________________________________________________________________________________________________________________________________________________________________________
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

// Решение:

// int[] startArray = GetArray (5, 0, 5);
// Console.WriteLine(String.Join(" ", startArray));
// Console.WriteLine(String.Join(" ", resultArray(startArray)));
// int[] GetArray(int size, int minValue, int maxValue){
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// int[] resultArray(int[] array){
//     int size = array.Length / 2;
//     if(array.Length % 2 == 1) size++;
//     int[] result = new int[size];
//     for (int i = 0; i < array.Length / 2; i++){
//         result[i] = array[i] * array[array.Length - 1 - i];
//     }
//     if(array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];
//     return result;
// }
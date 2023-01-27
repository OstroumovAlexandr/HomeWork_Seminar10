// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
/*
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
float[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
// -------------Метод---заполнения массива----------------
float[,] GetArray(int m, int n, double minValue, double maxValue){
    double[,] result = new double[m,n];
    double digit = 0;
    float[,] resultNew = new float[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().NextDouble();
            digit = new Random().NextDouble();
            if(digit > 0.5){
            resultNew[i,j] = (float)result[i,j] * 10;
            }
            else {
                resultNew [i,j] = (float)result [i,j] * -10;
            }
        }
    }
    return resultNew;
}
// метод вывода массива на экран
void PrintArray(float[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]:f1}  ");
        }
        Console.WriteLine();
    }
}
*/




//Задача 50. Напишите программу, которая на вход принимает число, 
//проверяя есть ли такое число в двумерном массиве и возвращает сообщение 
//о том, что оно найдено или же указание, что такого элемента нет.
/*
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(3, 4, 0, 10);
PrintArray(array);

if(findElement(array, num)){
    Console.WriteLine("Данное число в массиве есть");
} 
else{
    Console.WriteLine("Данное число в массиве отсутствует");
}
// ----------------Булевый метод----------
bool findElement(int [,] array, int a){
foreach (int el in array){
    if(el == a){
        return true;
    }
} return false;
}

// -------------Метод---заполнения массива----------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
// метод вывода массива на экран
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}
*/




//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Console.WriteLine($"Введите размерность массива:");
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 9);
// PrintArray(array);
// double [] NewArray = GetNewArray(array);
// Console.WriteLine($"Среднее арифметическое столбцов равно:");
// Console.WriteLine($"{String.Join("  ", NewArray)}");

//    //------МЕТОД заполнения нового массива--------
// double [] GetNewArray(int [,] array){
//  double[] res = new double[array.GetLength(1)];
//  for(int i = 0; i < array.GetLength(1); i++)
//  {
//   double sum = 0;
//   for( int j = 0; j < array.GetLength(0); j++){
//     sum += array[j,i];
//  }   
//  res [i] = Math.Round(sum/array.GetLength(0),2);
//  }
//  return res;
// }

// // -------------Метод---заполнения массива----------------
// int[,] GetArray(int rows, int columns, int minValue, int maxValue){
//     int[,] result = new int[rows,columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < columns; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// // метод вывода двухмерного массива на экран
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{ array[i,j]}   ");
//         }
//         Console.WriteLine();
//     }
// }


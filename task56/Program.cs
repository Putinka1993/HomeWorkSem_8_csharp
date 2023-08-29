// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер, 
// строки с наименьшей суммой элементов: 1 строка

int[,] matrix = new int[3, 6];

PrintSumArray(GetMatrix(matrix));


int[,] GetMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(1, 13);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintSumArray(int[,] array){
    int count = 0; // index row color
    int sum = 6 * 13 + 1; // sum row
    int tempSum = 0; // temp sum
    int[] TempArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            TempArray[j] = array[i,j];
        }
        for(int r = 0; r < TempArray.Length; r++){
            tempSum += TempArray[r];
        }
        if(tempSum < sum){
            sum = tempSum;
            tempSum = 0;
            count = i;
        }
        else {
            tempSum = 0;
        }
    }
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            TempArray[j] = array[i, j];
        }
        if (count == i){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{String.Join(", ", TempArray)}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{String.Join(", ", TempArray)}");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"min sum row = {sum} находиться на строке {count+1}");
}
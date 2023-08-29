// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = new int[,] { 
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
    };

PrintArray(array);
PrintSortArray(array);

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
}



void PrintSortArray(int[,] array){
    int[] TempArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            TempArray[j] = array[i,j];
        } // buble sort
        for(int r = 1; r < array.GetLength(1); r++){
            for(int c = 0; c < array.GetLength(1)-1; c++){
                if(TempArray[r] > TempArray[c]){
                    int temp = TempArray[c];
                    TempArray[c] = TempArray[r];
                    TempArray[r] = temp;
                }
            }
        }
        Console.WriteLine($"{String.Join(", ", TempArray)}");

    }
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] matrix = new int[2,2,2];

GetMatrix(matrix);

PrintMatrix(matrix);

void GetMatrix(int[,,] matrix){
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            for (int k = 0; k < matrix.GetLength(2); k++){
                while (true) {
                    temp = new Random().Next(10,99);
                    if (!EqualNum(matrix, temp)){
                        matrix[i,j,k] = temp;
                        break;
                    }
                }
            }
        }
    }
}

void PrintMatrix(int[,,] result){
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1); j++){
            for (int k = 0; k < result.GetLength(2); k++){
                Console.Write($"{result[i, j, k]} ({i} {j} {k}) ");
            }
            Console.WriteLine();
        }
    }
}

bool EqualNum(int[,,] matrix, int rN){
    bool res = false;
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            for (int k = 0; k < matrix.GetLength(2); k++){
                if  (matrix[i,j,k] == rN){
                    res = true;
                    break;
                    
                }
            }
        }
    }
    return res;
}
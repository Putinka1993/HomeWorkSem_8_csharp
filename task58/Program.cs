// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] m1 = new int[,] {
    {2, 4},
    {3, 2}
    };

int[,] m2 = new int[,] {
    {3, 4},
    {3, 3}
    };

int[,] res = GetMultiMatrix(m1, m2);

PrintMatrix(res);

int[,] GetMultiMatrix(int[,] m1, int[,] m2){
    int[,] r = new int[m1.GetLength(0), m2.GetLength(1)]; 
    for (int i = 0; i < m1.GetLength(0); i++){
        for (int j = 0; j < m2.GetLength(1); j++) {
            for (int k = 0; k < m1.GetLength(0); k++) {
                r[i, j] += m1[i, k] * m2[k, j];
            }
        }
    }
    return r;
}


void PrintMatrix(int[,] res){
    for (int i = 0; i < res.GetLength(0); i++){
        for (int j = 0; j < res.GetLength(1); j++){
            Console.Write(res[i, j] + " ");
        }
        Console.WriteLine();
    }
}
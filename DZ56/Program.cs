// Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

void Printmatr(int[,] matr)  // метод для печати двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - чтобы не писать каждый раз кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - чтобы не писать каждый раз кол-во столбцов
        {
            Console.Write($"{matr[i, j]} " + "\t");
        }
        Console.WriteLine();
    }
}
void Fillmatr(int[,] matr)// метод для заполнения матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}
// Функция вывода номера строки с наименьшей суммой элементов 
void NumberRow(int[,] matr)
{
    int Row = 0;
    int SumRow = 0;
    int sum = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        Row += matr[0, i];
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) sum += matr[i, j];
        if (sum < Row)
        {
            Row = sum;
            SumRow = i;
        }
        sum = 0;
    }
    Console.Write($"В {SumRow} строке наименьшая сумма элементов");
}

int[,] matrix = new int[3, 4];
Fillmatr(matrix);
Printmatr(matrix);
NumberRow(matrix);



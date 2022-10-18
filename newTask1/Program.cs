/* Задача 54: Задайте двумерный массив.
 Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

using static System.Console; 
Clear();
WriteLine("Введите кол-во строк: ");
int rows = int.Parse(ReadLine()!);
WriteLine("Введите кол-во стобцов: ");
int columns = int.Parse(ReadLine()!);
WriteLine("Введите диапозон от 1 до: ");;
int randomNumber = int.Parse(ReadLine()!);
int[,] array = new int[rows, columns];

GetArray(array);
ElementsDescending(array);
PrintArray(array); 






void ElementsDescending (int[,] inArray) {
    for(int i = 0; i < inArray.GetLength(0); i++) {

        for(int j = 0; j < inArray.GetLength(1); j++) {

            for(int c = 0; c < inArray.GetLength(1) -1; c++) {

                if(inArray[i, c] < inArray[i, c+1]){
                    int temp = inArray[i, c+1];
                    inArray[i, c+1] = inArray[i, c];
                    inArray[i, c] = temp;
                }
            }
        }
    }
}


void GetArray(int[,] inArray) {
    for(int i = 0; i < inArray.GetLength(0); i++) {

        for(int j = 0; j < inArray.GetLength(1); j++) {

            inArray[i,j] = new Random().Next(randomNumber);
        }
    }
}


void PrintArray(int[,] inArray) {
    for(int i = 0; i < inArray.GetLength(0); i++) {

        for(int j = 0; j < inArray.GetLength(0); j++) {

            Write(inArray[i,j] + " ");
        }
        WriteLine();
    }
}
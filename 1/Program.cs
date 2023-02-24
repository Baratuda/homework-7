// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

double[,] arrayFillerHelpMethod(double[,] twoDecimalArray){
   Random randomNumber = new Random();
   for(int i = 0; i<twoDecimalArray.GetLength(0); i++)
      for(int j = 0; j<twoDecimalArray.GetLength(1); j++)
         twoDecimalArray[i,j] = 20.0*randomNumber.Next()/2147483648-10;
   return twoDecimalArray;
}

double[,] arrayFiller() { 
   Console.Write("Please enter the array size (count arrays, length array): ");
   var arrayLength = Console.ReadLine().Split(",");
   int countArrays = int.Parse(arrayLength[0]);
   int lengthArrays = int.Parse(arrayLength[1]);
   double[,] twoDecimalArray = arrayFillerHelpMethod(new double[countArrays, lengthArrays]);
   return twoDecimalArray;
}

Console.Clear();
Console.Write("Please enter the search number: ");
int searchNumber  = int.Parse(Console.ReadLine());
double[,] twoDecimalArray = arrayFiller();
int countArrays = twoDecimalArray.GetLength(0);
int lengthArrays = twoDecimalArray.GetLength(1);
string message = searchNumber<=(countArrays-1)*(lengthArrays-1)?
               twoDecimalArray[searchNumber/3,searchNumber%(searchNumber/3)].ToString():
               "Array hasn't the searched number";
Console.Write(message);    

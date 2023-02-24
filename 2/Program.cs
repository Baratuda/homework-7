// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
double[,] twoDecimalArray = arrayFiller();
int countArrays = twoDecimalArray.GetLength(0);
int lengthArrays = twoDecimalArray.GetLength(1);
double sum = 0;
for(int i = 0; i<twoDecimalArray.GetLength(0); i++){
      if(sum!=0) Console.Write(sum);
      sum = 0;
      for(int j = 0; j<twoDecimalArray.GetLength(1); j++)
      sum+=twoDecimalArray[i,j];      
   
}


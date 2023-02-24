// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] arrayFiller(double[,] twoDecimalArray){
   Random randomNumber = new Random();
   for(int i = 0; i<twoDecimalArray.GetLength(0); i++){
      for(int j = 0; j<twoDecimalArray.GetLength(1); j++){
         twoDecimalArray[i,j] = 20.0*randomNumber.Next()/2147483648-10;
      }
   }
   return twoDecimalArray;
}
Console.Clear();
Console.Write("Please enter the two-desimal array size (count array, length array): ");
var arrayLength = Console.ReadLine().Split(",");
int countArrays = int.Parse(arrayLength[0]);
int lengthArrays = int.Parse(arrayLength[1]);
double[,] twoDecimalArray = arrayFiller(new double[countArrays, lengthArrays]);
for(int i = 0; i<twoDecimalArray.GetLength(0); i++){
   Console.Write("\n");
   for(int j = 0; j<twoDecimalArray.GetLength(1); j++)
   Console.Write(String.Format("{0,5:f1}",twoDecimalArray[i,j]));
}
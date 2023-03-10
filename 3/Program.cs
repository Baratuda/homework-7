// *Доп1
// На днях Иван у себя в прихожей выложил кафель,
// состоящий из квадратных черных и белых плиток.
// Прихожая Ивана имеет квадратную форму 4х4, вмещающую 16 плиток.
// Теперь Иван переживает, что узор из плиток, который у него получился,
// может быть не симпатичным. С точки зрения дизайна симпатичным узором считается тот,
// который не содержит в себе квадрата 2х2, состоящего из плиток одного цвета.
// Входные данные:
// BWBW
// BBWB
// WWBB
// BWWW
// Ответ:
// Yes

// Входные данные:
// BBWB
// BBWB
// WWBW
// BBWB
// Ответ:
// No
char[,] arrayFillerHelpMethod(char[,] twoDecimalArray){
   Random rnd = new Random();
   for(int i = 0; i<twoDecimalArray.GetLength(0); i++)
      for(int j = 0; j<twoDecimalArray.GetLength(1); j++){
         twoDecimalArray[i,j] = Convert.ToChar(rnd.Next('0', '2'));
         if(twoDecimalArray[i,j].Equals('0')) twoDecimalArray[i,j]='B';
         else twoDecimalArray[i,j]='W';
      }
   return twoDecimalArray;
}

char[,] arrayFiller() { 
   Console.Write("Please enter the array size (count arrays, length array): ");
   var arrayLength = Console.ReadLine().Split(",");
   int countArrays = int.Parse(arrayLength[0]);
   int lengthArrays = int.Parse(arrayLength[1]);
   char[,] twoDecimalArray = arrayFillerHelpMethod(new char[countArrays, lengthArrays]);
   return twoDecimalArray;
}
Console.Clear();
char[,] twoDecimalArray = arrayFiller();
for(int i = 0; i<twoDecimalArray.GetLength(0)-1; i++){
   Console.Write("\n");
   for(int j = 0; j<twoDecimalArray.GetLength(1)-1; j++){
      Console.Write(twoDecimalArray[i,j]);
   }
}

bool result = false;
for(int i = 0; i<twoDecimalArray.GetLength(0)-2; i++){
   Console.Write("\n");
   for(int j = 0; j<twoDecimalArray.GetLength(1)-2; j++){
   
   if(findSimmilarChars(twoDecimalArray,i,j)) {
      result = true;
      Console.WriteLine("Yes");
      break;
   }    
   }
   
}
if(!result)Console.WriteLine("No");
 
   


bool findSimmilarChars(char[,] chatArr, int i, int j){
   return chatArr[i,j]==chatArr[i,j+1] &&
          chatArr[i,j]==chatArr[i+1,j+1] &&
          chatArr[i,j]==chatArr[i+1,j]?true:false;
}
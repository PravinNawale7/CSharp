using System;
class JaggedDemo{
 static void Main(){ 
  int[][] arr = new int[4][];
  arr[0] = new int[5];
  arr[1] = new int[6];
  arr[2] = new int[8];
  arr[3] = new int[4];
 
 foreach(int[] iarr in arr){
foreach(int i in iarr)
   Console.Write(i + " ");
Console.WriteLine();
} 

Console.WriteLine("------------------- NESTED FOR LOOP -------------");

for(int i=0;i<4;i++){
   for(int j=0;j<arr[i].Length;j++){
    Console.Write(arr[i][j] + " ");
}
Console.WriteLine();
}
  }

}




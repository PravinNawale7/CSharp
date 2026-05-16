using System;
class SDArray{
static void Main(){
int x = 0;
 int[] arr = new int[5];
  for(int i=0;i<5;i++){  
Console.Write(arr[i] + " ");

}
for(int i=0;i<5;i++){
x+=10;
arr[i]=x;
Console.Write(arr[i]);
Console.WriteLine();
}
foreach(int i in arr){
Console.Write(i);
}
}
}

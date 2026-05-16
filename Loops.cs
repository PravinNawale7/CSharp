 using System;
 class Loops{
  static void Main(){
   Console.Write("Enter the Starting Number ");
   int a = int.Parse(Console.ReadLine());
   Console.Write("Enter the Ending Number:" );
   int b = int.Parse(Console.ReadLine());
   int i=a;
   while(i<=b){
  if(i%2==1){
   Console.WriteLine(i);
 
  }
 i++;
}   
}
}

